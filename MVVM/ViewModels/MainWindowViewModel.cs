using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVM.ViewModels
{

    partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string lastName;
        public string FullName => $"{firstName} {lastName}";

        [RelayCommand]
        public void Clear()
        {
            FirstName = "";
            LastName = "";
        }
    }
}
