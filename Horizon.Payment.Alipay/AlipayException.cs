using System;

namespace Horizon.Payment.Alipay
{
    public class AlipayException : Exception
    {
        public AlipayException()
        {
        }

        public AlipayException(string messages) : base(messages)
        {
        }

        public AlipayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
