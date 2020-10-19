using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horizon.Payment.Alipay;
using Horizon.Payment.Alipay.Domain;
using Horizon.Payment.Alipay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Horizon.Services.PayCenter.Models;
using Microsoft.Extensions.Options;
using Activity = System.Diagnostics.Activity;
using QRCoder;
using SkyApm.Diagnostics.Grpc.Server;

namespace Horizon.Services.PayCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlipayClient _client;
        private readonly IOptions<AlipayOptions> _optionsAccessor;
        public readonly ServerDiagnosticInterceptor _Interceptor; 
        public HomeController(ILogger<HomeController> logger,IAlipayClient client, IOptions<AlipayOptions> optionsAccessor,ServerDiagnosticInterceptor interceptor)
        {
            _logger = logger;
            _client = client;
            _optionsAccessor = optionsAccessor;
            _Interceptor = interceptor?? throw new ArgumentNullException(nameof(interceptor));;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// 当面付-二维码/条码/声波支付
        /// </summary>
        [HttpGet]
        public IActionResult Pay()
        {
            return View();
        }

        /// <summary>
        /// 当面付-二维码/条码/声波支付
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Pay(AlipayTradePayViewModel viewModel)
        {
            if (_Interceptor!=null)
            {
                return Ok("this is _Interceptor");
            }
            var model = new AlipayTradePayModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                Scene = viewModel.Scene,
                AuthCode = viewModel.AuthCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePayRequest();
            req.SetBizModel(model);

            var response = await _client.CertificateExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Test()
        {
            if (_Interceptor!=null)
            {
                return Ok("this is  _Interceptor");
            }

            return Ok("_Interceptor is null");
        }


        /// <summary>
        /// 当面付-扫码支付
        /// </summary>
        [HttpGet]
        public IActionResult PreCreate()
        {
            return View();
        }

        /// <summary>
        /// 当面付-扫码支付
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PreCreate(AlipayTradePreCreateViewModel viewModel)
        {
            if (_Interceptor!=null)
            {
                return Ok("this is _Interceptor");
            }
            var model = new AlipayTradePrecreateModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePrecreateRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            //var response = await _client.CertificateExecuteAsync(req, _optionsAccessor.Value);
            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["qrcode"] = response.QrCode;
            ViewData["response"] = response.Body;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        /// <summary>
        /// 生成二维码SVG
        /// </summary>
        /// <param name="data"></param>
        /// <param name="size"></param>
        [HttpGet]
        public IActionResult QrCode(string data, int size = 168)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (var svgQrCode = new SvgQRCode(qrCodeData))
            {
                var svgText = svgQrCode.GetGraphic(new Size(size, size));
                return File(Encoding.UTF8.GetBytes(svgText), "text/xml");
            }
        }



    }
}
