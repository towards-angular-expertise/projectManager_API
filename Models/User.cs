namespace Backend.Models
{
    public class User
    {
        public int id { get; set; }
        public bool isdeleted { get; set; }
        public bool isnotusing { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string profileurl { get; set; }
        public int[] rightids { get; set; }
    }
}