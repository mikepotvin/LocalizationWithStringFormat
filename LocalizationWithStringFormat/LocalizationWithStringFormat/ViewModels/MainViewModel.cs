using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LocalizationWithStringFormat
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Dogs = new ObservableCollection<Dog>(DogHelper.GetDogs());
        }

        private ObservableCollection<Dog> _Dogs;
        public ObservableCollection<Dog> Dogs
        {
            get => _Dogs;
            set => SetProperty(ref _Dogs, value);
        }
    }
}
