namespace Reproduction.MAUICollectionViewSpacing;

public partial class MainPage : ContentPage
{
    public List<string> Strings { get; set; }

    public MainPage()
	{
		InitializeComponent();
        Strings = new();
        AddStrings();
		BindingContext = this;
	}

    void AddStrings()
    {
        for (var i = 0; i < 10; i++)
        {
            Strings.Add("CollectionView shouldn't have spacing between items");
        }
    }
}