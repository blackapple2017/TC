namespace TC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Icon { get; set; }

        private static int sid = 0;
        public Category(string name, string desc, string icon)
        {
            Id = sid;
            sid++;
            Name = name;
            Desc = desc;
            Icon = icon;
        }

        public override string ToString()
        {
            return Id + ". " + Name;
        }
    }
}