# Reproduction.MAUICollectionViewSpacing

This repo is to show how a CollectionView in .NET MAUI contains default spacing between items even though it says in the documentation that it shouldn't.

Reporduction Steps:

1) Create a new .NET MAUI project
2) Remove the default MainPage.xaml content and replace with the following:

```csharp
    <Grid RowDefinitions="*"
          ColumnDefinitions="*">

        <CollectionView Grid.Row="0" Grid.Column="0" 
                        ItemsSource="{Binding Strings}"
                        BackgroundColor="Red">
            <CollectionView.ItemTemplate>
                <DataTemplate x:DataType="local:MainPage">
                    <Label Text="{Binding .}"
                           TextColor="Black"
                           FontSize="14"
                           BackgroundColor="Yellow"/>
                </DataTemplate>
            </CollectionView.ItemTemplate>
        </CollectionView>

    </Grid>
```

3) Remove the default MainPage.xaml.cs code behind and replace with the following:

```csharp
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
```

4) Run the application

In my example I have set the CollectionView background to Red and the Label's to Yellow to clearly show where the spacing occurs.

You can see in this example that the Labels have space between then, even though in the documentation it says:

![image](https://user-images.githubusercontent.com/19474685/211172691-5d3beaa3-e579-458c-88c9-e52854634ecc.png)
Source: https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/layout?view=net-maui-7.0

Example of application running
![image](https://user-images.githubusercontent.com/19474685/211172703-99eb1446-6ebd-4068-9eb9-2677cd32b78a.png)
