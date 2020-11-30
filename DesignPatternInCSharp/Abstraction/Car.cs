using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Abstraction
{
    /// <summary>
    /// Abstraction is basically deciding on the level of accessibility required of an object to the public. It means showing the public only what is necessary and compulsory 
    /// </summary>
    public class Car
    {
        public string _carName = "Kia";
        public string _carColour = "IceWine";

        public string CarName
        {
            get
            {
                return _carName;
            }
            set
            {
                _carName = value;
            }
        }

        public string CarColour
        {
            get
            {
                return _carColour;
            }
            set
            {
                _carColour = value;
            }
        }

        public void Steering()
        {
            Console.WriteLine("Steering of the car");
        }

        public void Brakes()
        {
            Console.WriteLine("Brakes of the car");
        }

        public void Gear()
        {
            Console.WriteLine("Gear of the car");
        }

        private void CarEngine()
        {
            Console.WriteLine("Engine of the car");
        }

        private void DieselEngine()
        {
            Console.WriteLine("DieselEngine of the car");
        }

        private void Silencer()
        {
            Console.WriteLine("Silencer of the car ");
        }
    }
}
