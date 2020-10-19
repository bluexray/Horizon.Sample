using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Horizon.Services.proto3;
using Microsoft.AspNetCore.Mvc;
using SkyApm.Diagnostics.Grpc.Client;

namespace Horizon.Services.PaySuff.Controllers
{
    [Route("api/[controller]")]
    public class AlipayController : Controller
    {

        private ClientDiagnosticInterceptor _interceptor;

        public AlipayController(ClientDiagnosticInterceptor interceptor)
        {
            _interceptor = interceptor;
        }

        public IActionResult Get()
        {
            return Ok("Hello");
        }

        [HttpGet]
        [Route("prePay")]
        public async Task<string> PrePay()
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2Support", true);

            var ch = GrpcChannel.ForAddress("http://127.0.0.1:5021");
            ch.Intercept(_interceptor);

            //Channel channel = new Channel("127.0.0.1:5021", ChannelCredentials.Insecure);

            var client = new AliPayment.AliPaymentClient(ch);


          var rp=  await client.ExecuteAsyncAsync(new TradeModel
            {
                OutTradeNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Body = "扫码支付描述信息",
                Subject = "扫码支付",
                TotalAmount = "0.01"

            });

          return rp.Qrcode; 

          //var reponse = await client.ExecuteAsync(new TradeModel
          //{
          //    OutTradeNo = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
          //    Body = "扫码支付描述信息",
          //    Subject = "扫码支付",
          //    TotalAmount = "0.01"

          //});

          //return  reponse.Qrcode;


          //await GrpcServiceManager.CallService("http://localhost:10042", async channel =>
          //{


          //});

        }
    }



}
