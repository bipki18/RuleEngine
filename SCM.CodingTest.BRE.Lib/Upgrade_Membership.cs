using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public class Upgrade_Membership : IProcessActivity
    {
        public async Task<string> Process()
        {
            return UpgradeMembership();
        }


        public string UpgradeMembership()
        {
            // logic for memebership upgraded
            //
            /////////
            return "Membership upgraded";
        }

    }
}
