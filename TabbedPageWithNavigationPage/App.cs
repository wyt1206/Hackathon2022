using System;
using System.IO;
using TabbedPageWithNavigationPage.Data;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class App : Application
	{
		static NoteDatabase database;

		// Create the database connection as a singleton.
		public static NoteDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
				}
				return database;
			}
		}

		public App ()
		{
			MainPage = new TabbedPageWithNavigationPage.MainPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

