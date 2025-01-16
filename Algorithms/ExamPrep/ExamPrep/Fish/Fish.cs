using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    abstract public class Fish : IFish
    {

        private string name;
        private string species;
        private int size;
        private decimal price;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (name == null || name == " ")
                {
                    throw new ArgumentException("Fish name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        public string Species
        {
            get { return this.species; }
            set
            {
                if (species == null || species == " ")
                {
                    throw new ArgumentException("Fish name cannot be null or empty.");
                }
                this.species = value;
            }

        }
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (price <= 0)
                {
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                }
                this.price = value;
            }
        }

        public abstract void Eat();
        public Fish(string name, string species, decimal price)
        {
            Name = name;
            Species = species;
            Price = price;
        }


        
    }
}
