using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCM.CodingTest.BRE.Lib
{
    public interface IProcessActivity
    {
        Task<string> Process();
    }
}
