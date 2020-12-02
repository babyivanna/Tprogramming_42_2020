using System;

namespace CourseApp
{
        public abstract class Electronic
        {
            private string brand;
            private string oc;
            private int ram;

            public Electronic()
            : this("?", "?", 0)
            {
            }

            public Electronic(string new_brand)
            : this(new_brand, "?", 0)
            {
            }

            public Electronic(string new_brand, string new_oc)
            : this(new_brand, new_oc, 0)
            {
            }

            public Electronic(string new_brand, string new_oc, int new_ram)
            {
                this.Brand = new_brand;
                this.OC = new_oc;
                this.RAM = new_ram;
            }

            private enum EnumOC
            {
                Windows,
                Linux,
                MacOS,
                IOS,
                Android
            }

            private enum EnumBrand
            {
                Acer,
                Apple,
                Microsoft,
                Dell,
                IBM,
                Honor
            }

            public virtual string Brand
            {
                get
                {
                    return brand;
                }

                set
                {
                    foreach (EnumBrand b in Enum.GetValues(typeof(EnumBrand)))
                    {
                        if (value == b.ToString())
                        {
                            brand = value;
                            break;
                        }
                    }
                }
            }

            public virtual string OC
            {
                get
                {
                    return oc;
                }

                set
                {
                    foreach (EnumOC b in Enum.GetValues(typeof(EnumOC)))
                    {
                        if (value == b.ToString())
                        {
                            oc = value;
                            break;
                        }
                    }
                }
            }

            public virtual int RAM
            {
                get
                {
                    return ram;
                }

                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("RAM неисправна");
                    }
                    else
                    {
                        ram = value;
                    }
                }
            }

            public virtual string DisplayInf()
            {
                return $"Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
            }

            public virtual void AddInf(string new_brand, string new_oc, int new_ram)
            {
                    Brand = new_brand;
                    OC = new_oc;
                    RAM = new_ram;
            }

            public abstract string Start();
        }
}