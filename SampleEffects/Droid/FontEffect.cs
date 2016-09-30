using System;
using Android.Graphics;
using Android.Widget;
using SampleEffects;
using SampleEffects.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(FontEffectDroid), EffectConstants.FONTEFFECTSTRING)]
namespace SampleEffects.Droid
{
    public class FontEffectDroid : PlatformEffect
    {
        public FontEffectDroid()
        {
        }

        protected override void OnAttached()
        {
            if (Element is Label)
            {
                Typeface sanregular = Typeface.CreateFromAsset(this.Control.Context.Assets, "DroidSerif-Regular.ttf");

                ((TextView)this.Control).SetTypeface(sanregular,TypefaceStyle.Normal);
            }
        }

        protected override void OnDetached()
        {
             
        }
    }
}
