using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Abstract
{
    public interface IBank
    {
        string Name { get; set; }
        string BankAdress { get; set; }
        List<IDesk> Desks { get; set; }
        void StartWork();
    }
}
