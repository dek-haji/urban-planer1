using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building NSS = new Building("500 interstate blvd");
            FiveOneTwoEigth.Width = 13;
            FiveOneTwoEigth.Depth = 10;
            FiveOneTwoEigth.Stories = 124;
            FiveOneTwoEigth.Construct();
            

            NSS.Width = 123;
            NSS.Depth = 100;
            NSS.Stories = 12;
            NSS.Construct();
            FiveOneTwoEigth.Purchase("dek");
            NSS.Purchase("Adam");

            FiveOneTwoEigth.PrintInfo();

        }
    }
}
