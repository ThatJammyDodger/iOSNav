namespace iOSNav.View;

public partial class DemoPage : ContentPage
{
	public DemoPage(DemoViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}