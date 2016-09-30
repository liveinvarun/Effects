using System;
using SampleEffects;
using SampleEffects.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(FontEffectIOS), EffectConstants.FONTEFFECTSTRING)]
namespace SampleEffects.iOS
{
    public class FontEffectIOS :PlatformEffect
    {
        public FontEffectIOS()
        {
        }

        protected override void OnAttached()
        {
            if (Element is Label)
            {
                ((UILabel)Control).Font= UIFont.FromName("Lato-Hairline",(nfloat) ((Label)Element).FontSize);
            }
        }

        protected override void OnDetached()
        {
            
        }
    }
}
