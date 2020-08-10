using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class Mailing : IProcessActivity
    {
        public async Task<string> Process()
        {
            return SendMail();
        }

        public string SendMail()
        { 
            // Mail sending logic 
            ///
            ///////////////////
            return "Mail sent";
        }
    }
}
