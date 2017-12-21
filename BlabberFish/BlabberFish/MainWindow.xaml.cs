using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlabberFish.API_Structure;

namespace BlabberFish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private JSON_Countries counteries;
        private JSON_Cities cities;

        public MainWindow()
        {
            //C# destytojas awesome
            InitializeComponent();



            //data = JsonConvert.DeserializeObject<T>(json.Replace("country:items", "country_items")); //Json converts inccorect data with ":" so replaced with "_"
            //cities = JsonConvert.DeserializeObject<T>(json.Replace("city:items", "city_items").Replace("city:search-results", "city_search_results"));

            Dictionary<string, string> replaces = new Dictionary<string, string>();
            replaces.Add("country:items", "country_items");
            counteries = Teleport_API<JSON_Countries>.DownloadJSON("https://api.teleport.org/api/countries/", replaces);

            replaces = new Dictionary<string, string>();
            replaces.Add("city:items", "city_items");
            replaces.Add("city:search-results", "city_search_results");
            cities = Teleport_API<JSON_Cities>.DownloadJSON("https://api.teleport.org/api/cities/", replaces);

            //var Country_Name = from countries in counteries._links.country_items
            //    select countries.name;

            List<string> Country_Name = counteries._links.country_items.Select(x => x.name).ToList();

            DG_Countries.ItemsSource = Country_Name;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // linq
            // select


        }
    }
}
