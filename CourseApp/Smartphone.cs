using System;

namespace CourseApp
{
    public class Smartphone : Electronic
    {
        public Smartphone()
        : base()
        {
        }

        public Smartphone(string new_brand)
        : base(new_brand)
        {
        }

        public Smartphone(string new_brand, string new_oc)
        : base(new_brand, new_oc)
        {
        }

        public Smartphone(string new_brand, string new_oc, int new_ram)
        : base(new_brand, new_oc, new_ram)
        {
        }

        public override string DisplayInf()
        {
            return $"Smartphone:\n  Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
        }

        public override void AddInf(string new_brand, string new_oc, int new_ram)
        {
            base.AddInf(new_brand, new_oc, new_ram);
        }

        public override string Start()
        {
            return "Включение\n";
        }
    }
}