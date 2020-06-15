using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalizationWithStringFormat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditDogPage : ContentPage
    {
        public EditDogPage(Dog dog)
        {
            InitializeComponent();
            (this.BindingContext as EditDogViewModel).Dog = dog;
        }
    }
}