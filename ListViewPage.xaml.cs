using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace CustomMasterDetailTest
{
    public partial class ListViewPage : ContentPage
    {
		public ListViewPage(int id)
		{
			InitializeComponent();

            if(id==1)
            {

                this.BindingContext = new[] { "a", "b", "c" };
            }
			else if (id == 2)
			{

				this.BindingContext = new[] { "shwe", "e", "f" };
			}
			else if (id == 3)
			{

				this.BindingContext = new[] { "j", "r", "Neymar" };
			}
			
		}

		void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}
    }
}
