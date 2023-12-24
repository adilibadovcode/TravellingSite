using System.ComponentModel.DataAnnotations;

namespace TravellingSite.Models
{
    public class Destionation
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }  
        public int Price { get; set; }
        public int StarCount { get; set; }
    }
}
