using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class Commision_Payment : IProcessActivity
    {
        public async Task<string> Process()
        {
           return  ProcessCommission();
        }

        public string ProcessCommission()
        {
            // Logic for commission processing 
            //
            /////////////////////////////////////
            return "Commission processed";
        }
    }
}
