using System;
using System.Collections.Generic;
using System.Text;

namespace PIS.Common
{
    public class ErrorMessage
    {
        public ErrorMessage(string message)
        {
        }
        public ErrorMessage(ErrorMessage message)
        {
            Message = Message;
        }

        public string Message { get; set; }
    }
}
