using System;

namespace MFU
{
    class User
    {
        private string name;
        private string adress;
        private double balance;
        private double spent;

        public User(string name, string adress, int balance, int spent)
        {
            this.name = name;
            this.adress = adress;
            this.balance = balance;
            this.spent = spent;
        }
        public void Info()
        {
            Console.WriteLine($"\n{name}");
            Console.WriteLine($"\n{adress}");
            Console.WriteLine($"\n{balance}$");
            Console.WriteLine($"\n{spent}$");
        }
        public void ReduceBalance(double price)
        {
            balance -= price;
            spent += price;
        }
    }
}
