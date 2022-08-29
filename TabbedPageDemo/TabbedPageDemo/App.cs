using Xamarin.Forms;

namespace TabbedPageDemo
{
	public class App : Application
	{
		public App ()
		{
			var tabs = new TabbedPage();
			tabs.Children.Add(new TabbedPageDemoPage());
			MainPage = tabs;
		}
	}
}
