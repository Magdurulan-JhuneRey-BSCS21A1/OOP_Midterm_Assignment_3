using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class OrderProcessor
    {
        private readonly EmailSender _emailSender;

        public OrderProcessor(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public bool ProcessOrder(Order order)
        {
            return _emailSender.SendEmail(order);
        }
    }
}
