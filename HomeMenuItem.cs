using System;
namespace CustomMasterDetailTest.Model.SliderView
{
	public enum MenuType
	{
		DashBoard,
		Profile,
		Test,
	}
	public class HomeMenuItem : BaseModel
	{
		public HomeMenuItem()
		{
			MenuType = MenuType.DashBoard;
		}
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }
	}
}
