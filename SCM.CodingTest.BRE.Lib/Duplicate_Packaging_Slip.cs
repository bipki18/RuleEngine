using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class Duplicate_Packaging_Slip : IProcessActivity
    {
        public async Task<string> Process()
        {
            return ProcessDuplicateSlip();
        }

        public string ProcessDuplicateSlip()
        {
            // logic for processing duplicate slip
            //
            //////////////////
            return "Duplicate slip processed";
        }
    }
}
