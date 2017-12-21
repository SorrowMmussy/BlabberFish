using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlabberFish.API_Structure
{
    public class CountryItem
    {
        public string href { get; set; }
        public string name { get; set; }
    }

    public class Cury
    {
        public string href { get; set; }
        public string name { get; set; }
        public bool templated { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public List<CountryItem> country_items { get; set; }
        public List<Cury> curies { get; set; }
        public Self self { get; set; }
    }

    public class JSON_Countries
    {
        public Links _links { get; set; }
        public int count { get; set; }
    }
    
}
