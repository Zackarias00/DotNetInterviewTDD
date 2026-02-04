using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewTDD.Core
{
    public class OrderProcessor
    {
        private FakePaymentService fakePaymentService;

        public OrderProcessor(FakePaymentService fakePaymentService)
        {
            this.fakePaymentService = fakePaymentService;
        }

        public bool Process(decimal v)
        {
            throw new NotImplementedException();
        }
    }
}
