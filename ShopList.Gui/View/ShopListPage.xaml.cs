namespace ShopList.Gui.View;

public partial class ShopListPage : ContentPage
{
	public ShopListPage()
	{
		InitializeComponent();
		BindingContext = new ShopListViewModels();
	}
}