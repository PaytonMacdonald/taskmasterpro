namespace taskmasterpro.Models
{
    public class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public string CreatorId { get; set; }
        public Profile Creator { get; set; }
    }
}