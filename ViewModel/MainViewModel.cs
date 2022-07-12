using iOSNav.View;

namespace iOSNav.ViewModel;
public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(DisplayCount))]
    public int count;

    public string DisplayCount
    {
        get => Count == 1 ? $"Clicked {Count} time" : $"Clicked {Count} times";
    }

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