using iOSNav.View;

namespace iOSNav;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DemoPage), typeof(DemoPage));
	}
}
