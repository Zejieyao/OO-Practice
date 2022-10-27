using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Engine
    {
        private string type;
        public Engine(string type)
        {
            if (type == "gasoline")
            {
                this.Speed = 30;
            }
            else
            {
                this.Speed = 25;
            }
        }

        public int Speed
        {
            get;
        }
    }
}
