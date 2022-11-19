using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            Random randNum = new Random();
            Id = randNum.Next(10,1000);
        }
    }
}
