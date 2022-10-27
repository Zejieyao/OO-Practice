using System;

namespace OOPractice
{
    public class Car : Vehicle
    {
        private string name;
        private string engineType;
        public Car(string name, int speed) : base(name, speed)
        {
        }

        public Car(string name, string engineType) : base(name, engineType)
        {
            this.name = name;
            this.engineType = engineType;
        }

        public string SpeedUpCar()
        {
            int engineSpeed = this.engineType == "gasoline" ? 30 : 25;
            return $"{this.name}: speed up {engineSpeed} km/h";
        }
    }
}