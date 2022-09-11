using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS ()
		{
			IconImageSource = "settings.png";
			Title = "Me";
			var table = new TableView();
			var root = new TableRoot();
			var section1 = new TableSection() { Title = "Me" };
			var entryName = new EntryCell { Text = "Name", Placeholder = "Amy", Keyboard = Keyboard.Text };
            var entryGender = new EntryCell { Text = "Gender", Placeholder = "Male", Keyboard = Keyboard.Text };
            //var entryAge = new EntryCell { Text = "Age", Placeholder = "25", Keyboard = Keyboard.Numeric };
            var entryHeight = new EntryCell { Text = "Height", Placeholder = "160", Keyboard = Keyboard.Numeric };
            var entryWeight = new EntryCell { Text = "Weight", Placeholder = "50", Keyboard = Keyboard.Numeric };
            var entryTelephone = new EntryCell { Text = "Telephone", Placeholder = "+1 012 345 6789", Keyboard = Keyboard.Telephone };


            section1.Add(entryName);
            section1.Add(entryGender);
            //section1.Add(entryAge);
            section1.Add(entryHeight);
            section1.Add(entryWeight);
            section1.Add(entryTelephone);

            Content = table;
		}
	}
}
