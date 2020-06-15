using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LocalizationWithStringFormat.Effects
{
    public class DropShadowEffect : RoutingEffect
    {
        public DropShadowEffect() : base("LocalizationWithStringFormat.DropShadowEffect")
        {

        }
        public float Radius { get; set; }
    }
}
