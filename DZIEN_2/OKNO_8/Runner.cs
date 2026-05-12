using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext_Window
{
    internal class Runner
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int StartNumber { get; set; }
        public int TimeAtCheckpoint { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Summary => $"Start number: {StartNumber}, Time at checkpoint: {TimeAtCheckpoint} min";
    }
}
