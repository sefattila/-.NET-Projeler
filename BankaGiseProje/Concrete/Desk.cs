using BankaGiseProje.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public class Desk : IDesk
    {
        public event GetNumberEventHandler OnNumbered;
        public string Name { get; set; }
        public int ProcessNumber { get; set; }
        public bool Status { get; set; }

        public void DoAction()
        {
            OnNumbered?.Invoke();
        }
    }
}
