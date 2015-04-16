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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MessengerForWindows
{
    /// <summary>
    /// Windows app page that navigates to messenger.com and does some magic. :)
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			messengerWeb.Navigate(new Uri("https://messenger.com"));
	        appBar.IsOpen = true;
	        appBar.IsSticky = false;
        }

	    private void HomeButton_OnClick(object sender, RoutedEventArgs e)
	    {
			messengerWeb.Navigate(new Uri("https://messenger.com"));
			appBar.IsOpen = false;
	    }

	    private void LoginButton_OnClick(object sender, RoutedEventArgs e)
	    {
			messengerWeb.Navigate(new Uri("https://www.messenger.com/login"));
		    appBar.IsOpen = false;
	    }
    }
}
