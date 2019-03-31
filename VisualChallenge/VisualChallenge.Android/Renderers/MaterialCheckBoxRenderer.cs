using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.ComponentModel;
using VisualChallenge;
using VisualChallenge.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.Android;
using AView = Android.Views.View;

[assembly: ExportRenderer(typeof(MaterialCheckBox), typeof(MaterialCheckBoxRenderer))]
namespace VisualChallenge.Droid.Renderers
{
    public class MaterialCheckBoxRenderer :
        AppCompatCheckBox,
        IViewRenderer,
        IVisualElementRenderer,
        IEffectControlProvider,
        CompoundButton.IOnCheckedChangeListener
    {
        private bool _disposed;
        private int? _defaultLabelFor;
        private ColorStateList _defaultButtonList;

        private VisualElementTracker _visualElementTracker;
        private VisualElementPackager _visualElementPackager;

        #region IVisualElementRenderer Properties

        private MaterialCheckBox _element;
        
        protected MaterialCheckBox Element
        {
            get => _element;
            set
            {
                if (_element == value) return;
                var oldElement = _element;
                _element = value;

                OnElementChanged(new ElementChangedEventArgs<MaterialCheckBox>(oldElement, _element));
            }
        }

        AView IVisualElementRenderer.View => this;
        ViewGroup IVisualElementRenderer.ViewGroup => null;
        VisualElement IVisualElementRenderer.Element => Element;
        VisualElementTracker IVisualElementRenderer.Tracker => _visualElementTracker;

        public event EventHandler<VisualElementChangedEventArgs> ElementChanged;
        public event EventHandler<PropertyChangedEventArgs> ElementPropertyChanged;

        #endregion

        public MaterialCheckBoxRenderer(Context context) : base(context) { }

        protected MaterialCheckBoxRenderer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        #region IViewRenderer Implementation

        void IViewRenderer.MeasureExactly()
        {
            if (Element == null) return;

            if (Element.Width <= 0 || Element.Height <= 0) return;

            var widthPixels = (int)Context.ToPixels(Element.Width);
            var heightPixels = (int)Context.ToPixels(Element.Height);

            var widthMeasureSpec = MeasureSpec.MakeMeasureSpec(widthPixels, MeasureSpecMode.Exactly);
            var heightMeasureSpec = MeasureSpec.MakeMeasureSpec(heightPixels, MeasureSpecMode.Exactly);

            Measure(widthMeasureSpec, heightMeasureSpec);
        }

        #endregion

        #region IVisualRenderer Implementation

        void IVisualElementRenderer.SetLabelFor(int? id)
        {
            if (_defaultLabelFor == null)
                _defaultLabelFor = ViewCompat.GetLabelFor(this);

            ViewCompat.SetLabelFor(this, (int)(id ?? _defaultLabelFor));
        }

        void IVisualElementRenderer.UpdateLayout()
        {
            _visualElementTracker?.UpdateLayout();
        }

        void IVisualElementRenderer.SetElement(VisualElement element)
        {
            Element = element as MaterialCheckBox;

            if (string.IsNullOrEmpty(Element?.AutomationId)) return;

            ContentDescription = Element.AutomationId;
        }

        SizeRequest IVisualElementRenderer.GetDesiredSize(int widthConstraint, int heightConstraint)
        {
            Measure(widthConstraint, heightConstraint);
            return new SizeRequest(new Size(MeasuredWidth, MeasuredHeight));
        }

        #endregion

        #region IEffectControlProvider Implementation

        void IEffectControlProvider.RegisterEffect(Effect effect)
        {
            if (!(effect is PlatformEffect platformEffect)) return;

            platformEffect.SetControl(this);
        }

        #endregion

        #region Element Changed

        protected virtual void OnElementChanged(ElementChangedEventArgs<MaterialCheckBox> e)
        {
            this.EnsureId();

            EffectUtilities.RegisterEffectControlProvider(this, e.OldElement, e.NewElement);

            ElementChanged?.Invoke(this, new VisualElementChangedEventArgs(e.OldElement, e.NewElement));

            if (e.OldElement != null)
            {
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;
            }

            if (e.NewElement == null) return;

            if (_visualElementTracker == null)
            {
                SetOnCheckedChangeListener(this);

                _defaultButtonList = ButtonTintList;

                _visualElementTracker = new VisualElementTracker(this);
                _visualElementPackager = new VisualElementPackager(this);
                _visualElementPackager.Load();
            }

            UpdateAll();

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        #endregion

        #region Property Changed

        public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
        {
            if (Element == null || Element.IsChecked == isChecked) return;

            Element.IsChecked = isChecked;

            Element?.OnCheckedChanged();
        }

        protected virtual void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_disposed) return;

            ElementPropertyChanged?.Invoke(this, e);

            if (e.PropertyName == MaterialCheckBox.IsCheckedProperty.PropertyName) UpdateIsChecked();
            else if (e.PropertyName == Label.TextColorProperty.PropertyName) UpdateColor();
        }

        private void UpdateAll()
        {
            UpdateColor();
            UpdateIsChecked();
        }

        private void UpdateIsChecked()
        {
            if (Element == null || Element.IsChecked == Checked) return;

            Checked = Element.IsChecked;
        }

        private void UpdateColor()
        {
            if (Element == null) return;

            ButtonTintList = Element.IsSet(Label.TextColorProperty) 
                ? ColorStateList.ValueOf(Element.TextColor.ToAndroid()) 
                : _defaultButtonList;
        }

        #endregion

        #region LifeCycle

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;

            _disposed = true;

            if (disposing)
            {
                EffectUtilities.UnregisterEffectControlProvider(this, Element);

                SetOnCheckedChangeListener(null);

                if (_visualElementTracker != null)
                {
                    _visualElementTracker.Dispose();
                    _visualElementTracker = null;
                }

                if (_visualElementPackager != null)
                {
                    _visualElementPackager.Dispose();
                    _visualElementPackager = null;
                }

                if (Element != null)
                {
                    Element.PropertyChanged -= OnElementPropertyChanged;

                    ((IVisualElementRenderer)this).SetElement(null);
                }
            }

            base.Dispose(disposing);
        }

        #endregion
    }
}