using System;
using Xamarin.Forms;

namespace VisualChallenge
{
    public class MaterialCheckBox : Label
    {
        #region Bindable Properties

        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(
            nameof(IsChecked), typeof(bool), typeof(MaterialCheckBox), false);

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public static readonly BindableProperty IsCheckedChangedCommandProperty = BindableProperty.Create(
            nameof(IsCheckedChangedCommand), typeof(Command), typeof(MaterialCheckBox));

        public Command IsCheckedChangedCommand
        {
            get => (Command)GetValue(IsCheckedChangedCommandProperty);
            set => SetValue(IsCheckedChangedCommandProperty, value);
        }

        public event EventHandler<EventArgs> IsCheckedChanged;

        #endregion

        public void OnCheckedChanged()
        {
            IsCheckedChanged?.Invoke(this, EventArgs.Empty);
            IsCheckedChangedCommand?.Execute(IsChecked);
        }
    }
}
