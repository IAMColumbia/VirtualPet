using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Hydrant
    {
        public string Color;
        public bool IsClean;
        public string Location;

        public Hydrant()
        {
            this.Color = "red";
            this.IsClean = true;
        }

        public string About()
        {
            return $"The {this.Color} hydrant locaated at {this.Location} and is {this.GetCleanString()}";
        }

        private string GetCleanString()
        {
            if (this.IsClean)
                return "clean";
            return "dirty";
        }
    }
}