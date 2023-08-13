using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Abstract
{
    public interface IDesk
    {
        string Name { get; set; }
        int ProcessNumber { get; set; }
        bool Status { get; set; }

        void DoAction();
    }
}
