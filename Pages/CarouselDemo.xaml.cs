using CarouselViewDemo.Models;

namespace CarouselViewDemo.Pages;

public partial class CarouselDemo : ContentPage
{
	public CarouselDemo()
	{


		InitializeComponent();

        
        var items = new List<CollectionItem>
        {
            new CollectionItem { Title = "First", Description = "This is the first item" },
            new CollectionItem { Title = "Second", Description = "This is the second item" },
            new CollectionItem { Title = "Third", Description = "This is the third item" },
            new CollectionItem { Title = "Fourth", Description = "This is the fourth item" },
            new CollectionItem { Title = "Fifth", Description = "This is the fifth item" }
        };

        carouselView.ItemsSource = items;
    }
}