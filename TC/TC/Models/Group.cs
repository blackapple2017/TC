using System.Collections.ObjectModel;

namespace TC.Models
{
    public class Group: ObservableCollection<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
    }
}