using BankaGiseProje.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaGiseProje.Concrete
{
    public delegate int GetNumberEventHandler();
    public class Bank : IBank
    {
        public string Name { get; set; }
        public string BankAdress { get; set; }
        public List<IDesk> Desks { get; set; }

        public void StartWork()
        {
            CreateDesk(3);
            foreach (IDesk desk in Desks)
            {
                Console.WriteLine($"{desk.Name} Sıra No:{desk.ProcessNumber} Durum:{desk.Status}");
            }
            // Banka 1 kere açılacak ve ilk açılışta listelerimi new lemem lazım oluşturduğum class ta new lersem sürekli numaraları sıfırlarım
            CustomerWaiting.waitingCustomerStandart = new List<CustomerStandart>();
            CustomerWaiting.waitingCustomerVip = new List<CustomerVip>();
            CustomerWaiting.waitingCustomerDesk = new List<CustomerDesk>();
        }

        private void CreateDesk(int deskCount)
        {
            if (deskCount <= 3)
            {
                Desks = new List<IDesk>();
                for (int i = 0; i < deskCount; i++)
                {
                    Desk desk = new Desk()
                    {
                        Name = "BA-" + i,
                        Status = false,
                        ProcessNumber = 0
                    };
                    Desks.Add(desk);
                    desk.OnNumbered += Control.SendNumberToDesk;
                }
            }
            else throw new Exception("En fazla 3 gişe olabilir");
        }
    }
}
