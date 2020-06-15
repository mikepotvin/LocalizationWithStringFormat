using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(LocalizationWithStringFormat.Droid.Effects.DropShadowEffect), "DropShadowEffect")]
namespace LocalizationWithStringFormat.Droid.Effects
{
    public class DropShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control ?? Container as Android.Views.View;

                var effect = (LocalizationWithStringFormat.Effects.DropShadowEffect)Element.Effects.FirstOrDefault(e => e is LocalizationWithStringFormat.Effects.DropShadowEffect);

                if (effect != null)
                {
                    float radius = effect.Radius;

                    control.Elevation = radius;
                    control.TranslationZ = radius;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: {0}", ex.Message);
            }
        }

        protected override void OnDetached()
        {

        }
    }
}