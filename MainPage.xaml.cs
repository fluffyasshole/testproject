using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace binding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            List<product> product_list = new List<product> {

            new product { name="Whatsapp",  price="$10", image="Assets/580b57fcd9996e24bc43c543.png"},
            new product { name="Hi Wassup",  price="$10", image="Assets/dgdfgdfgd.jpg"},

         new product { name="Twitter",  price="$10", image="Assets/business-woman.png"},
         new product { name="Snapchat",  price="$10", image="Assets/bn.jpg"},
         new product { name="Linkedin",  price="$10", image="Assets/business-woman.png"},

         new product { name="Twitter",  price="$10", image="Assets/business-woman.png"},
         new product { name="Snapchat",  price="$10", image="Assets/bn.jpg"},
         new product { name="Linkedin",  price="$10", image="Assets/business-woman.png"},
                    };

            listView.ItemsSource = product_list;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            product p = listView.SelectedItem as product;
            this.Frame.Navigate(typeof(productDetail), p);
        }
    }
}
