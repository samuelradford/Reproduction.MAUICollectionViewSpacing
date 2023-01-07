using Reproduction.MAUICollectionViewSpacing.ViewModels;

namespace Reproduction.MAUICollectionViewSpacing;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

