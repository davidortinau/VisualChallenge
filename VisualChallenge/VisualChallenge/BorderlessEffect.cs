using System.Linq;
using Xamarin.Forms;

namespace VisualChallenge
{
    public static class BorderlessEffect
    {
        public static readonly BindableProperty HasBorderProperty = BindableProperty.CreateAttached("HasBorder", typeof(bool), typeof(BorderlessEffect), true, propertyChanged: OnHasBorderChanged);
        private static void OnHasBorderChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as SearchBar;
            if (control == null)
                return;

            var bHasBorder = (bool)newValue;

            var attachedEffect = control.Effects.FirstOrDefault(e => e is BorderlessSearchEffect);
            if (attachedEffect == null && !bHasBorder)
                control.Effects.Add(new BorderlessSearchEffect());
            else if (attachedEffect != null && bHasBorder)
                control.Effects.Remove(attachedEffect);
        }

        public static bool GetHasBorder(BindableObject view)
        {
            return (bool)view.GetValue(HasBorderProperty);
        }

        public static void SetHasBorder(BindableObject view, bool bHasBorder)
        {
            view.SetValue(HasBorderProperty, bHasBorder);
        }
    }

    class BorderlessSearchEffect : RoutingEffect
    {
        public BorderlessSearchEffect() : base("companyname.BorderlessSearchEffect")
        {

        }
    }
}
