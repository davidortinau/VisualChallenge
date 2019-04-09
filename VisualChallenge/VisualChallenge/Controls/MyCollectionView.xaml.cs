using Xamarin.Forms;

namespace VisualChallenge.Controls
{
    public partial class MyCollectionView : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(MyCollectionView), default(string), BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }

            set
            {
                SetValue(TextProperty, value);
            }
        }

        public MyCollectionView()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextProperty.PropertyName)
            {
                Title.Text = Text;
            }
        }

    }
}
