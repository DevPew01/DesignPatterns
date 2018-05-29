using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public class ExsoticCarFactory : IPartFactory
    {
        public Body CreateBody()
        {
           return new Body(BodyKit.LongBussinesSedan, Color.Mate);
        }

        public Engine CreateEngite()
        {
            return new Engine(EngineType.Carburetor, 320, 18.51, 6);
        }

        public FuelTank CreateTank()
        {
            return new FuelTank(55);
        }

        public Transmition CreateTransmition()
        {
            return new Transmition(8, TransmitionType.Auto);
        }

        public Wheel CreateWheel()
        {
            return new Wheel(19, Color.Yellow);
        }
    }
}
