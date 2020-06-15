using CoreGraphics;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using LocalizationWithStringFormat.iOS.Effects;
using UIKit;

[assembly: ResolutionGroupName("LocalizationWithStringFormat")]
[assembly: ExportEffect(typeof(DropShadowEffect), "DropShadowEffect")]
namespace LocalizationWithStringFormat.iOS.Effects
{
    public class DropShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (LocalizationWithStringFormat.Effects.DropShadowEffect)Element.Effects.FirstOrDefault(e => e is LocalizationWithStringFormat.Effects.DropShadowEffect);

                if (effect != null)
                {
                    Container.Layer.ShadowRadius = effect.Radius;
                    Container.Layer.ShadowColor = UIColor.DarkGray.CGColor;
                    Container.Layer.ShadowOffset = new CGSize(2, 2);
                    Container.Layer.ShadowOpacity = 0.5f;
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