using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class Activate_Membership : IProcessActivity
    {
        public async Task<string> Process()
        {
            return ActivateMembership();
        }

        public string ActivateMembership()
        {
            // logic for activating memebership
            ///
            ////////////////////////
            return "Membership activated";
        }


    }
}
