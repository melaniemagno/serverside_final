using System.Xml.Linq;

namespace BlazorApp2.Data
{
    public class Posts
    {
        public int Id { get; set; }
        public string Post { get; set; }

        public override string ToString()
        {
            return $"#{Id} {Post}";
        }
    }
}
