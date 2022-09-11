using System;
using SQLite;

namespace TabbedPageWithNavigationPage.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Telephone { get; set; }

        //public DateTime Date { get; set; }
    }
}