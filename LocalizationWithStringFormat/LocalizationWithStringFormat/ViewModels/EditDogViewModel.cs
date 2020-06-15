using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationWithStringFormat
{
    public class EditDogViewModel : BaseViewModel
    {

        private Dog _Dog;
        public Dog Dog
        {
            get => _Dog;
            set => SetProperty(ref _Dog, value);
        }
    }
}
