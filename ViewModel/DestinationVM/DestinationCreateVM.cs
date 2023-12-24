using System.ComponentModel.DataAnnotations;

namespace TravellingSite.ViewModel.DestinationVM;

public class DestinationCreateVM
{
    public int Id { get; set; }
    public IFormFile Image { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
    public int StarCount { get; set; }
}
