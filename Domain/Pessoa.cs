using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pessoa : Entity
    {
        public string Register { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public int Number { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
    }
}
