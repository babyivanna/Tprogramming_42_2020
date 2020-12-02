using System;

namespace CourseApp
{
    public class Computer : Electronic
    {
        public Computer()
        : base()
        {
        }

        public Computer(string new_brand)
        : base(new_brand)
        {
        }

        public Computer(string new_brand, string new_oc)
        : base(new_brand, new_oc)
        {
        }

        public Computer(string new_brand, string new_oc, int new_ram)
        : base(new_brand, new_oc, new_ram)
        {
        }

        public override string DisplayInf()
        {
            return $"Computer:\n  Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
        }

        public void AddRAM(int new_ram)
        {
            RAM = new_ram;
        }

        public string GetRAM()
        {
            return $"RAM {RAM}";
        }

        public override void AddInf(string new_brand, string new_oc, int new_ram)
        {
            base.AddInf(new_brand, new_oc, new_ram);
        }

        public override string Start()
        {
            return $"Запуск\n";
        }
    }
}