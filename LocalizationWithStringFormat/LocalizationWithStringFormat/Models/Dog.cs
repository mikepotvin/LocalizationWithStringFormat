using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationWithStringFormat
{
    public class Dog : ObservableObject
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private string _SpecialAbility;
        public string SpecialAbility
        {
            get => _SpecialAbility;
            set => SetProperty(ref _SpecialAbility, value);
        }
    }
}
