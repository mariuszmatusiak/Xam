using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NetStatus
{
	public partial class Page1 : ContentPage
	{
        Label noNetworkLabel;

		public Page1 ()
		{
            noNetworkLabel = new Label();
            noNetworkLabel.Text = "There is no network!";
            noNetworkLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            noNetworkLabel.TextColor = Color.FromRgb(0x40, 0x40, 0x40);
            Content = noNetworkLabel;
			InitializeComponent ();
            this.BackgroundColor = Color.FromRgb(0xF0, 0xF0,0xF0);
		}
	}
}
