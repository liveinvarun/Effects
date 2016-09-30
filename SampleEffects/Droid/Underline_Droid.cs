using System;
using Android.Graphics;
using Android.Text;
using Android.Text.Style;
using Android.Widget;
using SampleEffects.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly:ResolutionGroupName("SampleEffects")]
[assembly:ExportEffect(typeof(UnderlineEffect),"UnderlineEffect")]
namespace SampleEffects.Droid
{
    /// <summary>
    /// Underline effect.
    /// </summary>
    public class UnderlineEffect : PlatformEffect
    {
        public UnderlineEffect()
        {
        }

        /// <summary>
        /// Ons the attached.
        /// </summary>
        protected override void OnAttached()
        {
            if (this.Element is Label)
            {
                  TextView textview = Control as TextView;
                textview.PaintFlags = PaintFlags.UnderlineText;
                

            }

        }

        /// <summary>
        /// Ons the detached.
        /// </summary>
        protected override void OnDetached()
        {

        }
    }
}
