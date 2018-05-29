using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public enum EngineType {Turbo, BiTurbo, Atmosphere, TurboDiesel, Ingector, Carburetor}
    public enum Color {Black, Metalic, Mate, Gold, White, Red, Blue, Chameleon, Orange, Green, Yellow, Silver};
    public class Engine
    {
        protected EngineType type;
        public Engine()
        {

        }
        public Engine(EngineType type, int hp, double consunp, int cylinderCount)
        {
            this.type = type;
            this.HPower = hp;
            this.FuelConsumption = consunp;
            this.сylinderCount = cylinderCount;
        }
        public int HPower {private set; get; }
        public double FuelConsumption
        {
            private set;
            get;
        }
        public int сylinderCount
        {
            private set;
            get;
        }

        public override string ToString()
        {
            return $"Type: {type} HP: {HPower} fuel consumption {FuelConsumption}";
        }
    }
    public enum TransmitionType { Auto, Manual, Robot, Combo }
    public class Transmition
    {
        public Transmition()
        {

        }
        public Transmition(int GearCount, TransmitionType type)
        {
            this.GearCount = GearCount;
            this.transmitionType = type;
        }
        protected TransmitionType transmitionType {private set; get; }
        protected int GearCount { private set; get; }

        public override string ToString()
        {
            return $"Type: {transmitionType}, {GearCount} gears";
        }
    }
    public enum BodyKit { Hatchback, Sedan, LongBussinesSedan, SportCar,  Liftback, Bus, Truck}
    public class Body
    {
        public Body()
        {

        }
        public Body(BodyKit kit, Color color)
        {
            this.kit = kit;
            this.color = color;
        }
        protected BodyKit kit {private set; get; }
        protected Color color {private set; get; }

        public override string ToString()
        {
            return $"{kit} | color: {color}.";
        }
    }
    public class Wheel
    {
        public Wheel()
        {

        }
        public Wheel(int Diameter, Color color)
        {
            this.Diameter = Diameter;
            this.color = color;
        }
        protected int Diameter {private set; get; }
        protected Color color {private set; get; }

        public override string ToString()
        {
            return $"Diameter {Diameter}\" inch | Color: {color}.";
        }
    }
    public class FuelTank
    {
        public FuelTank(double capacity)
        {
            this.Capacity = capacity;
        }
        protected double Capacity {private set; get; }

        public override string ToString()
        {
            return $"fuel capacity {Capacity} liters.";
        }
    }
}