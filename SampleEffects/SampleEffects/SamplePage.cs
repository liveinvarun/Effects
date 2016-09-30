using System;

using Xamarin.Forms;

namespace SampleEffects
{
    /// <summary>
    /// Sample page.
    /// </summary>
    public class SamplePage : ContentPage
    {
        StackLayout sampleLayout = null;
        public SamplePage()
        {
            sampleLayout = new StackLayout();

            Label titleLabel = new Label();
            titleLabel.WidthRequest = Device.GetNamedSize(NamedSize.Large,typeof(Label)) * 10;
            titleLabel.Text = "Enter Text...";
            Entry entryText = new Entry();
            entryText.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;
            Button applyEffect = new Button();
            applyEffect.Text = "Apply";
            applyEffect.WidthRequest=Device.GetNamedSize(NamedSize.Medium, typeof(Label)) * 4;

            Label underlineeffectLabel = new Label();
            underlineeffectLabel.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;
            underlineeffectLabel.Text = "Underline Effect";

            Label resultLabel = new Label();
            resultLabel.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;

             Label fonteffectLabel = new Label();
            fonteffectLabel.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;
            fonteffectLabel.Text = "Font Effect";
            Label lblfonteffectresult = new Label();
            lblfonteffectresult.FontSize = 25;
            lblfonteffectresult.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;



            applyEffect.Clicked += (object sender, EventArgs e) =>
            {
                resultLabel.Text = entryText.Text;
                  lblfonteffectresult.Text = entryText.Text;

                var fonteffect = Effect.Resolve(EffectConstants.FONTEFFECTUNIQUESTRING);
                lblfonteffectresult.Effects.Add(fonteffect);

                var effect=Effect.Resolve(EffectConstants.UNDERLINESTRING);
                resultLabel.Effects.Add(effect);
               
            };
            sampleLayout.Children.Add(titleLabel);
            sampleLayout.Children.Add(entryText);

            sampleLayout.Children.Add(applyEffect);
            sampleLayout.Children.Add(underlineeffectLabel);
            sampleLayout.Children.Add(resultLabel);

            sampleLayout.Children.Add(fonteffectLabel);
            sampleLayout.Children.Add(lblfonteffectresult);

            Content = sampleLayout;
        }
    }
}

