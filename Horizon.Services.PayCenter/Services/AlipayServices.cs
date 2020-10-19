using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Horizon.Payment.Alipay;
using Horizon.Payment.Alipay.Domain;
using Horizon.Payment.Alipay.Request;
using Horizon.Services.proto3;
using Microsoft.Extensions.Options;


namespace Horizon.Services.PayCenter.Services
{
    public class AlipayServices:AliPayment.AliPaymentBase
    {
        private readonly IAlipayClient _client;

        private readonly IOptions<AlipayOptions> _optionsAccessor;

        public AlipayServices(IAlipayClient client,IOptions<AlipayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        //扫码支付
        public override async Task<AlipayReponse> ExecuteAsync(TradeModel request, ServerCallContext context)
        {
            var model = new AlipayTradePrecreateModel
            {
                OutTradeNo = request.OutTradeNo,
                Subject = request.Subject,
                TotalAmount = request.TotalAmount,
                Body = request.Body
            };



            var req = new AlipayTradePrecreateRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl("http://domain.com/alipay/notify/precreate");

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);

            return  new AlipayReponse
            {
                Message = response.Body,
                Qrcode = response.QrCode
                
            };

            //return base.ExecuteAsync(request, context);
        }
    }
}
