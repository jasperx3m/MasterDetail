using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinExercise.MenuItems;


namespace XamarinExercise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "QuoteSlider", Icon = "About.png", TargeType = typeof(Exercise1) };
            var page2 = new MasterPageItem() { Title = "ColorPicker", Icon = "About.png", TargeType = typeof(Exercise2) };
            var page3 = new MasterPageItem() { Title = "Instagram", Icon = "About.png", TargeType = typeof(InstagramPage) };
            var page4 = new MasterPageItem() { Title = "Dialer", Icon = "About.png", TargeType = typeof(DialerPage) };
            var page5 = new MasterPageItem() { Title = "Calculator", Icon = "About.png", TargeType = typeof(CalculatorPage) };
            var page6 = new MasterPageItem() { Title = "AbsoluteLayout", Icon = "About.png", TargeType = typeof(AbsoluteLayoutPage)};
            var page7 = new MasterPageItem() { Title = "RelativeLayout", Icon = "About.png", TargeType = typeof(RelativeLayoutPage) };
            var page8 = new MasterPageItem() { Title = "Images", Icon = "About.png", TargeType = typeof(ImagePage) };
            var page9 = new MasterPageItem() { Title = "Login", Icon = "About.png", TargeType = typeof(LoginPage) };


            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);
            menuList.Add(page9);
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Exercise1)));
        }
        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargeType;

            Detail=new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }


    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace XamarinExercise
//{
//    // Learn more about making custom code visible in the Xamarin.Forms previewer
//    // by visiting https://aka.ms/xamarinforms-previewer
//    [DesignTimeVisible(false)]
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();
//        }

//        private async void Ex1_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new Exercise1());
//        }

//        private async void Ex2_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new Exercise2());
//        }

//        private async void Ex3_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new LoginPage());
//        }

//        private async void Ex4_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new InstagramPage());
//        }

//        private async void Ex5_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new DialerPage());
//        }

//        private async void Ex6_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new CalculatorPage());
//        }

//        private async void Ex7_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new AbsoluteLayoutPage());
//        }

//        private async void Ex8_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new RelativeLayoutPage());

//        }

//        private async void Ex9_Clicked(object sender, EventArgs e)
//        {
//            await Navigation.PushAsync(new ImagePage());
//        }
//    }
//}
