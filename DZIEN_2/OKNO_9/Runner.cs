using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_profil_zawodnika
{
    internal class Runner
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Distance { get; set; }
        public string City { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
