using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
   public class TunerCarFactory : IPartFactory
    {
        public Body CreateBody()
        {
            return new Body(BodyKit.Hatchback, Color.Chameleon);
        }

        public Engine CreateEngite()
        {
            return new Engine(EngineType.Turbo, 500, 22.6, 12);
        }

        public FuelTank CreateTank()
        {
            return new FuelTank(80);
        }

        public Transmition CreateTransmition()
        {
            return new Transmition(6, TransmitionType.Manual);
        }

        public Wheel CreateWheel()
        {
            return new Wheel(20, Color.Red);
        }
    }
}
