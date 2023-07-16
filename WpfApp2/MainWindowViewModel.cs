
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial  class MainWindowViewModel : ObservableObject
{


    // Implement command methods here
    [RelayCommand]
    private void Open()
    {
        // Code for opening a file
       throw new System.Exception();
    }
    [RelayCommand]
    private void Save()
    {
        // Code for saving a file
    }

    [RelayCommand]
    private void Exit()
    {
        // Code for exiting the application
    }

    [RelayCommand]
    private void Cut()
    {
        // Code for cutting text
    }

    [RelayCommand]
    private void Copy()
    {
        // Code for copying text
    }

    [RelayCommand]
    private void Paste()
    {
        // Code for pasting text
    }

    [RelayCommand]
    private void About()
    {
        // Code for displaying about information
    }

    [RelayCommand]
    private void SendNotification()
    {
        // Code for sending a notification
    }

    [RelayCommand]
    private void MouseAction(object parameter)
    {
        // Code for handling mouse actions
    }

    // Implement INotifyPropertyChanged interface here
}
