namespace WebApplication1.Models
{
    public class Members
    {
        public int Memid { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string address { get; set; }
        public string zipcode { get; set; }
        public string telephone { get; set; }
        public int recommendedby { get; set; }
        public DateTime joindate { get; set; }
    }
}
