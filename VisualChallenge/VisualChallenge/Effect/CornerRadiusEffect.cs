using System.Linq;
using Xamarin.Forms;
namespace VisualChallenge.Effect
{
    public class CornerRadiusEffect : RoutingEffect
    {
        public CornerRadiusEffect() : base("PJ.CornerRadiusEffect")
        {
        }

        public static readonly BindableProperty CornerRadiusProperty =
           BindableProperty.CreateAttached(
               "CornerRadius",
               typeof(int),
               typeof(CornerRadiusEffect),
               0,
               propertyChanged: OnCornerRadiusChanged);

        public static int GetCornerRadius(BindableObject view) =>
            (int)view.GetValue(CornerRadiusProperty);

        public static void SetCornerRadius(BindableObject view, int value) =>
            view.SetValue(CornerRadiusProperty, value);

        private static void OnCornerRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
                return;

            var cornerRadius = (int)newValue;
            var effect = view.Effects.OfType<CornerRadiusEffect>().FirstOrDefault();

            if (cornerRadius > 0 && effect == null)
                view.Effects.Add(new CornerRadiusEffect());

            if (cornerRadius == 0 && effect != null)
                view.Effects.Remove(effect);
        }
    }
}
