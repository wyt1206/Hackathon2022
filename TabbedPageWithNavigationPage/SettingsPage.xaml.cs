using System;
using System.Collections.Generic;
using TabbedPageWithNavigationPage.Models;
using Xamarin.Forms;
using System.Linq;

namespace TabbedPageWithNavigationPage
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class SettingsPage : ContentPage
	{
        public string ItemId
        {
            set
            {
                LoadNote(value);
            }
        }

        public SettingsPage()
		{
            
            InitializeComponent();
            BindingContext = new Note();


        }

        async void LoadNote(string itemId)
        {
            try
            {
                int id = Convert.ToInt32(itemId);
                // Retrieve the note and set it as the BindingContext of the page.
                Note note = await App.Database.GetNoteAsync(id);
                BindingContext = note;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load note.");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            //note.Date = DateTime.UtcNow;
            if (!string.IsNullOrWhiteSpace(note.Name))
            {
                await App.Database.SaveNoteAsync(new Note{
                    Name = nameEntry.Text,
                    Gender = genderEntry.Text,
                    //Age = int.Parse(ageEntry.Text),
                    Height = int.Parse(heightEntry.Text),
                    Weight = int.Parse(weightEntry.Text),
                    Telephone = telephoneEntry.Text
                });

            }

            // Navigate backwards
            //await Shell.Current.GoToAsync("..");
        }
    }	
}

