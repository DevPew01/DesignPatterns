using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    public abstract class Plant
    {
        public Plant() { }
        public Plant(string Name)
        {
            this.Name = Name;
        }
        protected internal string Name { set; get; }

        public virtual string Grow()
        {
            return "Я расту";
        }
    }

    public class Groot : Plant
    {
        public Groot() { }
        public Groot(string Name) :base(Name)
        {
            this.Name = Name;
        }
        public override string Grow()
        {
            return base.Grow() + " я есть " + this.Name;
        }
    }

    public class Seawead : Plant
    {
        public Seawead()
        {

        }
        public Seawead(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public override string Grow()
        {
            return base.Grow();
        }
    }
}
