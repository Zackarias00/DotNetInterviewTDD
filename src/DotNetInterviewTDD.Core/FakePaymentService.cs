using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewTDD.Core
{
    public class FakePaymentService
    {
        private bool success;

        public FakePaymentService(bool success)
        {
            this.success = success;
        }

        public decimal LastChargedAmount { get; set; }
    }
}
