using ShopList.Gui.ViewModels;

namespace ShopList.Gui.View;

public partial class ShopListPage : ContentPage
{
	public ShopListPage()
	{
		InitializeComponent();
		BindingContext = new ShopListViewModel();
	}
}