using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class PhysicalPayment : IProcessActivity
    {
        public async Task<string> Process()
        {
            return GeneratePackagingSlipforShipping();
        }

        public string GeneratePackagingSlipforShipping()
        {
            return "Processed packaging slip";
        }

    }
}
