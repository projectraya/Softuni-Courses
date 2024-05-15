using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Final_Term_Test
{
    public class Competitor<T> : IComparable<Competitor<T>>
    {
        private string name;
        private int age;
        public List<T> Scores;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if(value < 10)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 10.");
                }
                else
                {
                    this.age = value;
                }
                
            }
        }

        public Competitor(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Scores = new List<T>();
        }

        public void Add(T score)
        {
            
            Scores.Add(score);
        }

        public int CountCompetitions()
        {
            int result = Scores.Count;

            return result;
        }

        public T ChangeLastScore(T newScore)
        {
            T lastScore = this.Scores[Scores.Count - 1];
            this.Scores[Scores.Count - 1] = newScore;
            return lastScore;

        }

        public int CompareTo(Competitor<T> other)
        {
            
            int result = this.Name.CompareTo(other.Name);

            if(result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }
    }
}
