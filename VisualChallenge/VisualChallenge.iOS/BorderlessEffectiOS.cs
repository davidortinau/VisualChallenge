using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using VisualChallenge.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("companyname")]
[assembly: ExportEffect(typeof(BorderlessEffectiOS), "BorderlessSearchEffect")]
namespace VisualChallenge.iOS
{
    public class BorderlessEffectiOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            UpdateHasBorder();
        }

        protected override void OnDetached()
        {

        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == BorderlessEffect.HasBorderProperty.PropertyName)
                UpdateHasBorder();
        }

        private void UpdateHasBorder()
        {
            var searchbar = (UITextField)Control.ValueForKey(new Foundation.NSString("searchField"));
            if (searchbar == null)
                return;

            var bHasBorder = (bool)Element.GetValue(BorderlessEffect.HasBorderProperty);

            if (!bHasBorder)
            {
                searchbar.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}