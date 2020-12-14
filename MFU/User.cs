using System;

namespace MFU
{
    class User
    {
        public string Name;
        private string adress;
        private double balance;
        private double spent;

        public User(string name, string adress, int balance, int spent)
        {
            Name = name;
            this.adress = adress;
            this.balance = balance;
            this.spent = spent;
        }
        public void Info()
        {
            Console.WriteLine($"\nName:\t\t{Name}");
            Console.WriteLine($"\nAdress:\t\t{adress}");
            Console.WriteLine($"\nBalance:\t{balance}$");
            Console.WriteLine($"\nSpent:\t\t{spent}$");
        }
        public void ReduceBalance(double price)
        {
            balance -= price;
            spent += price;
        }
    }
}
