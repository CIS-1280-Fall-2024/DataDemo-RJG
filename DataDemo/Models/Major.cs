namespace DataDemo.Models
{
    public class Major
    {
        public int Id { get; set; }
        public string? Title{ get; set; }

        public override string ToString()
        {
            return Title??"";
        }
    }
}
