using System;
using System.Collections.Generic;
using CustomMasterDetailTest.Model.SliderView;
using Xamarin.Forms;

namespace CustomMasterDetailTest
{
	public partial class MenuPage : ContentPage
	{
		RootPage root;
		List<HomeMenuItem> menuItems;
		public MenuPage(RootPage root)
		{

			this.root = root;
			InitializeComponent();

			BackgroundColor = Color.FromHex("#03A9F4");
			ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");

			BindingContext = new BaseViewModel
			{
				Title = "MatchHelper",
				Subtitle = "MatchHelper",
				Icon = "slideout.png"
			};

			ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
				{
					new HomeMenuItem { Title = "Dashboard", MenuType = MenuType.DashBoard, Icon ="about.png" },
					new HomeMenuItem { Title = "Profile", MenuType = MenuType.Profile, Icon = "blog.png" },
					new HomeMenuItem { Title = "Test", MenuType = MenuType.Test, Icon = "twitternav.png" },


				};

			ListViewMenu.SelectedItem = menuItems[0];

			ListViewMenu.ItemSelected += async (sender, e) =>
			{
				if (ListViewMenu.SelectedItem == null)
					return;

				await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
			};
		}
	}
}
