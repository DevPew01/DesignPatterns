using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public abstract class CarFactory : IPartFactory
    {
        public Body CreateBody()
        {
            return new Body(BodyKit.SportCar, Color.Orange);
        }

        public Engine CreateEngite()
        {
            return new Engine(EngineType.BiTurbo, 350, 12, 8);
        }

        public FuelTank CreateTank()
        {
            return new FuelTank(45);
        }

        public Transmition CreateTransmition()
        {
            return new Transmition(8, TransmitionType.Robot);
        }

        public Wheel CreateWheel()
        {
            return new Wheel(18, Color.Gold);
        }

        public Wheel[] CreateWheels(int count)
        {
            Wheel[] wheels = new Wheel[count];
            for (int i = 0; i < wheels.Length; i++)
                wheels[i] = new Wheel(20, Color.Metalic);
            return wheels;
        }
    }
}
