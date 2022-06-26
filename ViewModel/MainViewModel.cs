using iOSNav.View;

namespace iOSNav.ViewModel;
public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    public int count;

    public MainViewModel()
    {
        Title = "The Main Page";
        Count = 0;
    }

    [RelayCommand]
    void Increment()
    {
        Count++;
    }

    [RelayCommand]
    async Task NavToDemo()
    {
        await Shell.Current.GoToAsync(nameof(DemoPage), true);
    }
}