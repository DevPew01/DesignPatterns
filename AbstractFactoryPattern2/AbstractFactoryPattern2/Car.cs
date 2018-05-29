using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public class Car
    {
        public Car()
        {

        }

        public Car(Engine engine, Transmition transmition, Wheel wheel, Body body, FuelTank fuelTank)
        {
            this.engine = engine;
            this.transmition = transmition;
            this.wheel = wheel;
            this.body = body;
            this.fuelTank = fuelTank;
        }
        private Engine engine;
        private Transmition transmition;
        private Wheel wheel;
        private Body body;
        private FuelTank fuelTank;
        //private string name;

        public override string ToString()
        {
            return $"Body: {body}\nEngine: {engine}\nTransmition: {transmition}\n" +
                $"Wheel: {wheel}\nTank {fuelTank}";
        }
    }
}
