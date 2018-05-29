using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    class Garage
    {
        public Garage()
        {

        }

        public Car BuildCar(CarFactory factory)
        {
            return new Car(factory.CreateEngite(), factory.CreateTransmition(),
                factory.CreateWheel(), factory.CreateBody(), factory.CreateTank());
        }

        public Car BuildCar(TunerCarFactory tunerFactory)
        {
            return new Car(tunerFactory.CreateEngite(), tunerFactory.CreateTransmition(),
               tunerFactory.CreateWheel(), tunerFactory.CreateBody(), tunerFactory.CreateTank());
        }

        public Car BuildCar(ExsoticCarFactory tunerFactory)
        {
            return new Car(tunerFactory.CreateEngite(), tunerFactory.CreateTransmition(),
               tunerFactory.CreateWheel(), tunerFactory.CreateBody(), tunerFactory.CreateTank());
        }
    }
}
