using System;
using CoreGraphics;
using UIKit;

namespace VisualChallenge.iOS.Renderers
{
    public class CheckBoxView : UIButton
    {
        public event EventHandler<EventArgs> StateChanged;

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value) return;

                _isChecked = value;
                Selected = value;
                StateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public CheckBoxView() => Initialize();

        public CheckBoxView(CGRect bounds) : base(bounds) => Initialize();

        private void Initialize()
        {
            UpdateImages();

            TouchUpInside += (o, e) => IsChecked = !IsChecked;
        }

        private void UpdateImages()
        {
            SetImage(UIImage.FromBundle("ic_checkbox_checked.png"), UIControlState.Selected);
            SetImage(UIImage.FromBundle("ic_checkbox_unchecked.png"), UIControlState.Normal);
        }
    }
}