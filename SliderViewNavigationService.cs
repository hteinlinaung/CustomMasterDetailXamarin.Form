using System;
using Xamarin.Forms;

namespace CustomMasterDetailTest.Model
{
	public class SliderViewNavigationService : NavigationPage
	{
		public SliderViewNavigationService(Page root) : base(root)
		{
			Init();
		}

		public SliderViewNavigationService()
		{
			Init();
		}

		void Init()
		{

			BarBackgroundColor = Color.FromHex("#03A9F4");
			BarTextColor = Color.White;
		}
	}
}
