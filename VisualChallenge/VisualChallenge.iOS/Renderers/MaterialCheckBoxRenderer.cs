using System.ComponentModel;
using VisualChallenge;
using VisualChallenge.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MaterialCheckBox), typeof(MaterialCheckBoxRenderer))]
namespace VisualChallenge.iOS.Renderers
{
    public class MaterialCheckBoxRenderer : ViewRenderer<MaterialCheckBox, CheckBoxView>
    {
        private bool _disposed;

        protected override void OnElementChanged(ElementChangedEventArgs<MaterialCheckBox> e)
        {
            base.OnElementChanged(e);

            if (Element == null) return;

            if (Control == null)
            {
                SetNativeControl(new CheckBoxView());
                Control.StateChanged += OnStateChanged;
            }

            UpdateAll();
        }

        private void OnStateChanged(object sender, System.EventArgs e) => Element?.OnCheckedChanged();

        public void UpdateAll()
        {
            UpdateIsChecked();
            UpdateBackgroundColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == MaterialCheckBox.IsCheckedProperty.PropertyName) UpdateIsChecked();
            else if (e.PropertyName == VisualElement.BackgroundColorProperty.PropertyName) UpdateBackgroundColor();
        }
        
        private void UpdateIsChecked()
        {
            if (Control == null || Element == null || Element.IsChecked == Control.IsChecked) return;

            Control.IsChecked = Element.IsChecked;
        }

        private void UpdateBackgroundColor()
        {
            if (Control == null || Element == null) return;

            BackgroundColor = Element.BackgroundColor.ToUIColor();
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;

            _disposed = true;

            if (disposing && Control != null)
            {
                Control.StateChanged += OnStateChanged;
            }

            base.Dispose(disposing);
        }
    }
}