using CarouselViewDemo.Pages;

namespace CarouselViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselDemo();
        }
    }
}
