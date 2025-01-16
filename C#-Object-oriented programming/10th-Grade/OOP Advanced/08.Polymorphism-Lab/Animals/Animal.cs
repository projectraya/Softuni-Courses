using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string FavoriteFood { get; protected set; }

        protected Animal(string name, string food)
        {
            this.Name = name;
            this.FavoriteFood = food;

        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
}
