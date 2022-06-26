namespace iOSNav.ViewModel;
public partial class DemoViewModel : BaseViewModel
{
    public DemoViewModel()
    {
        Title = "Short";
    }

    [RelayCommand]
    void ChangeTitle(string newone)
    {
        Title = newone;
    }
}