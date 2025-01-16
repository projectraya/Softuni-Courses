using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop
{
    public abstract class Aquarium
    {
        private string name;
        public int Capacity { get; set; }
        public ICollection<IDecoration> Decorations;
        public ICollection<IFish> Fish;
        public int Comfort { get; set; }

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

        public void AddFish(IFish fish)
        {
            int currentCapacity = this.Capacity;
            if (currentCapacity < Capacity)
            {
                Fish.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public bool RemoveFish(IFish fish)
        {
            Fish.Remove(fish);
            if (Fish.Contains(fish))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddDecoration(IDecoration decoration)
        {
            Decorations.Add(decoration);
        }

        public void Feed()
        {
            foreach(IFish fish in Fish)
            {
                fish.Eat();
            }
        }
        public string GetInfo()
        {
            if(Fish.Count == 0)
            {
                return "none";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach(IFish fish in this.Fish)
                {
                    sb.Append(fish.Name + " ");
                }
                string names = sb.ToString();
                if(this.Fish.Count == 0)
                {
                    names = "none";
                }

                string type = "";
                if(this.Capacity == 50)
                {
                    type = "FreshwaterAquarium";
                }
                else
                {
                    type = "SaltwaterAquarium";
                }

                return $"{this.Name} ({type}) :" +
                    $"\nFish: {names}" +
                    $"\nDecorations: {this.Decorations.Count}" +
                    $"\nComfort: {this.Comfort}";
            }
        }

        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}
