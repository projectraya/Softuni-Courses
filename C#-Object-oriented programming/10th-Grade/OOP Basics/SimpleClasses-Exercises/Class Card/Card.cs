using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Card
{
    public class Card
    {
        private string face;
        private string suite;

        public Card(string face, string suite)
        {
            this.Face = face;
            this.Suite = suite;
        }
        public void Print()
        {
            Console.WriteLine(Face + " " + Suite);
        }
        public string Face
        {
            get { return this.face; }
            set { this.face = value; }
        }

        public string Suite
        {
            get { return this.suite; }
            set { this.suite = value; }
        }
    }
}
