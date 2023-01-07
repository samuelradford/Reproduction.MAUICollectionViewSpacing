namespace Reproduction.MAUICollectionViewSpacing.ViewModels;

public class MainPageViewModel
{
    public List<string> Strings { get; set; }
    
    public MainPageViewModel()
    {
        Strings = new List<string>();
        AddStrings();
    }

    void AddStrings()
    {
        for (var i = 0; i < 10; i++)
        {
            Strings.Add("CollectionView shouldn't have spacing between items");
        }
    }
}
