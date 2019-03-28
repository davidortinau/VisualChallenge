using System;
using UIKit;
using VisualChallenge.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(TransparentViewCellRenderer))]
namespace VisualChallenge.iOS
{
    public class TransparentViewCellRenderer : ViewCellRenderer
    {
        public TransparentViewCellRenderer()
        {
        }

        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            if (cell != null) cell.BackgroundColor = UIColor.FromRGB(221, 120, 203); //Pink for visual challenge
            return cell;
        }
    }
}