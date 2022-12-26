using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

        public int PersonsCount => persons.Count();
        [RelayCommand]
        public void Clear()
        {
            FirstName = "";
            LastName = "";
        }

        BindingList<PersonModel> persons = new BindingList<PersonModel>()
        {
            new PersonModel { FullPersonName = "Daniel Barczyński"}
        };

        [RelayCommand]
        public void Add()
        {
            persons.Add(new PersonModel { FullPersonName = FullName });
            OnPropertyChanged(nameof(PersonsCount));
        }
    }
}
