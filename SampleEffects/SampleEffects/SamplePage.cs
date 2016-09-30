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


            Label resultLabel = new Label();
            resultLabel.WidthRequest = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 10;
          

            applyEffect.Clicked += (object sender, EventArgs e) =>
            {
                resultLabel.Text = entryText.Text;
                var effect=Effect.Resolve("SampleEffects.UnderlineEffect");
                resultLabel.Effects.Add(effect);

            };
            sampleLayout.Children.Add(titleLabel);
            sampleLayout.Children.Add(entryText);
            sampleLayout.Children.Add(applyEffect);
             sampleLayout.Children.Add(resultLabel);

            Content = sampleLayout;
        }
    }
}

