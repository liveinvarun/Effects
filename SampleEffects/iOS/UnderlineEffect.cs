using System;
using Foundation;
using SampleEffects.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ResolutionGroupName("SampleEffects")]
[assembly:ExportEffect(typeof(UnderlineEffect),"UnderlineEffect")]
namespace SampleEffects.iOS
{
    /// <summary>
    /// Underline effect.
    /// </summary>
    public class UnderlineEffect :PlatformEffect
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
                UILabel view= (UILabel)this.Control;

                var attrString = new NSMutableAttributedString(view.Text);
                  attrString.AddAttribute(UIStringAttributeKey.UnderlineStyle,
                                  NSNumber.FromInt32((int)NSUnderlineStyle.Single),
                                  new NSRange(0, attrString.Length));

                view.AttributedText = attrString;
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
