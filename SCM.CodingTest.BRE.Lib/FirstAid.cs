using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class FirstAid : IProcessActivity
    {
        public async Task<string> Process()
        {
            return AddFirstAid();
        }


        public string AddFirstAid()
        {
            // logic to add video to packaging slip
            //
            ///////////////////////////////////
            ///
            return "processed request";
        }

    }
}
