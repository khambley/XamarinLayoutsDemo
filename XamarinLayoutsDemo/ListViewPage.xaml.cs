using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLayoutsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            MyListView.ItemsSource = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Avengers Age of Ultron", Language = "English", ReleaseDate = Convert.ToDateTime("05/01/2015"), MovieImage = "avengersageofultron.png"
                },
                new Movie()
                {
                    Title = "Iron Man", Language = "English", ReleaseDate = Convert.ToDateTime("05/02/2008"), MovieImage = "ironman.png"
                },
                new Movie()
                {
                    Title = "Thor Love and Thunder", Language = "English", ReleaseDate = Convert.ToDateTime("07/08/2022"), MovieImage = "thorloveandthunder.png"
                },
                new Movie()
                {
                    Title = "Star Wars A New Hope", Language = "English", ReleaseDate = Convert.ToDateTime("05/25/1977"), MovieImage = "starwarsanewhope.png"
                },
            };
        }
    }
}