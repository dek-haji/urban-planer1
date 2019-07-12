using System;

namespace Planner
{
    // Define class here
    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        //public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
            public Building(string address){
                _address = address;
            }
           public void Construct(){

            _dateConstructed = DateTime.Now;
        }
        
       public void Purchase(string name)
        {
            _owner = name;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------");
            Console.WriteLine($"constructed on {_dateConstructed}");
            Console.WriteLine($"designed by {_designer}");
            Console.WriteLine($"owned by {_owner}");
            Console.WriteLine($"{Volume} Cubic meters of space");


        }

    }
}