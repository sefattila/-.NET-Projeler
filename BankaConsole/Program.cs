
using BankaGiseProje.Concrete;

Bank bank = new Bank();
bank.Name = "HalkBank";
bank.BankAdress = "İstanbul";
bank.StartWork();

CustomerDesk customerDesk=new CustomerDesk("111","Sefa");
customerDesk.GetNumber();

CustomerDesk customer2 = new CustomerDesk("112", "Fatih2");
customer2.GetNumber();

CustomerStandart customer3 = new CustomerStandart("113", "Fatih3");
customer3.GetNumber();

CustomerDesk customer4 = new CustomerDesk("114", "Fatih4");
customer4.GetNumber();

CustomerDesk customer5 = new CustomerDesk("115", "Fatih5");
customer5.GetNumber();

CustomerVip customer6 = new CustomerVip("116", "Fatih6");
customer6.GetNumber();

CustomerVip customer7 = new CustomerVip("116", "Fatih6");
customer7.GetNumber();

bank.Desks[0].DoAction();
bank.Desks[0].DoAction();
bank.Desks[0].DoAction();
bank.Desks[2].DoAction();
bank.Desks[2].DoAction();
bank.Desks[2].DoAction();
bank.Desks[1].DoAction();

Console.WriteLine($"Vip Sayısı:{DailyProcess.VipNumber} Gişe Sayısı:{DailyProcess.DeskNumber} Standart Sayısı:{DailyProcess.StandartNumber}");
