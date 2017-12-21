using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlabberFish.API_Structure
{
    public class CityItem
    {
        public string href { get; set; }
    }

    public class Links3
    {
        public CityItem city_item { get; set; }
    }

    public class CitySearchResult
    {
        public Links3 _links { get; set; }
        public List<object> matching_alternate_names { get; set; }
        public string matching_full_name { get; set; }
    }

    public class Embedded
    {
        public List<CitySearchResult> city_search_results { get; set; }
    }

    public class Cury2
    {
        public string href { get; set; }
        public string name { get; set; }
        public bool templated { get; set; }
    }

    public class Self2
    {
        public string href { get; set; }
    }

    public class Links2
    {
        public List<Cury2> curies { get; set; }
        public Self2 self { get; set; }
    }

    public class JSON_Cities
    {
        public Embedded _embedded { get; set; }
        public Links2 _links { get; set; }
        public int count { get; set; }
    }
}
