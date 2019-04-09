﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VisualChallenge
{
    /// <summary>
    /// https://github.com/VincentH-Net/CSharpForMarkup
    /// </summary>
    public static class XamarinFormsMarkupExtensions
    {
        const string bindingContextPropertyName = ".";

        static Dictionary<string, BindableProperty> viewTypeDefaultProperty = new Dictionary<string, BindableProperty>
        { // Key: full type name of view, Value: the default BindableProperty
            { "Xamarin.Forms.ActivityIndicator", ActivityIndicator.IsRunningProperty },
            { "Xamarin.Forms.BoxView", BoxView.ColorProperty },
            { "Xamarin.Forms.Button", Button.CommandProperty },
            { "Xamarin.Forms.DatePicker", DatePicker.DateProperty },
            { "Xamarin.Forms.Editor", Editor.TextProperty },
            { "Xamarin.Forms.Entry", Entry.TextProperty },
            { "Xamarin.Forms.Image", Image.SourceProperty },
            { "Xamarin.Forms.Label", Label.TextProperty },
            { "Xamarin.Forms.ListView", ListView.ItemsSourceProperty },
            { "Xamarin.Forms.MasterDetailPage", Page.TitleProperty },
            { "Xamarin.Forms.MultiPage", Page.TitleProperty },
            { "Xamarin.Forms.NavigationPage", Page.TitleProperty },
            { "Xamarin.Forms.CarouselPage", Page.TitleProperty },
            { "Xamarin.Forms.ContentPage", Page.TitleProperty },
            { "Xamarin.Forms.Page", Page.TitleProperty },
            { "Xamarin.Forms.TabbedPage", Page.TitleProperty },
            { "Xamarin.Forms.TemplatedPage", Page.TitleProperty },
            { "Xamarin.Forms.Picker", Picker.SelectedIndexProperty },
            { "Xamarin.Forms.ProgressBar", ProgressBar.ProgressProperty },
            { "Xamarin.Forms.SearchBar", SearchBar.SearchCommandProperty },
            { "Xamarin.Forms.Slider", Slider.ValueProperty },
            { "Xamarin.Forms.Stepper", Stepper.ValueProperty },
            { "Xamarin.Forms.Switch", Switch.IsToggledProperty },
            { "Xamarin.Forms.TableView", TableView.BindingContextProperty },
            { "Xamarin.Forms.TimePicker", TimePicker.TimeProperty },
            { "Xamarin.Forms.WebView", WebView.SourceProperty },
            { "Xamarin.Forms.TextCell", TextCell.TextProperty },
            { "Xamarin.Forms.ToolbarItem", ToolbarItem.CommandProperty }
        };

        static BindableProperty GetDefaultProperty(Element view) // Note that we use Element type for the view variable in bind functions because we want to bind to Cell types as well as View types
        {
            BindableProperty defaultProperty;
            var viewType = view.GetType();
            string viewTypeName;

            do
            {
                viewTypeName = viewType.FullName;
                if (viewTypeDefaultProperty.TryGetValue(viewTypeName, out defaultProperty)) break;
                if (viewTypeName.StartsWith("Xamarin.Forms.", StringComparison.Ordinal))
                    throw new NotImplementedException("No default bindable property is defined for view type." + viewTypeName + "\r\nEither specify a property when calling Bind() or add a default property for this type to the viewTypeDefaultProperty dictionary.");
#if WINDOWS_UWP
                viewType = viewType.GetTypeInfo().BaseType;
#else
                viewType = viewType.BaseType;
#endif
                if (viewType == null) return null;
            } while (true);

            return defaultProperty;
        }

        public static TView Bind<TView>(this TView view, BindableProperty targetProperty, string sourcePropertyName = bindingContextPropertyName, BindingMode mode = BindingMode.Default, IValueConverter converter = null, object converterParameter = null, string stringFormat = null, object source = null) where TView : Element
        {
            if (source != null || converterParameter != null)
                view.SetBinding(targetProperty, new Binding(
                    path: sourcePropertyName,
                    mode: mode,
                    converter: converter,
                    converterParameter: converterParameter,
                    stringFormat: stringFormat,
                    source: source
                ));
            else
                view.SetBinding(targetProperty, sourcePropertyName, mode, converter, stringFormat);
            return view;
        }

        public static TView Bind<TView>(this TView view, string sourcePropertyName = bindingContextPropertyName, BindingMode mode = BindingMode.Default, IValueConverter converter = null, object converterParameter = null, string stringFormat = null, object source = null) where TView : Element
        {
            view.Bind(
                targetProperty: GetDefaultProperty(view),
                sourcePropertyName: sourcePropertyName,
                mode: mode,
                converter: converter,
                converterParameter: converterParameter,
                stringFormat: stringFormat,
                source: source
            );
            return view;
        }

        public static TView Assign<TView, TAssignView>(this TView view, out TAssignView variable) where TView : class, TAssignView
        {
            variable = view;
            return view;
        }

        public static TView Invoke<TView>(this TView view, Action<TView> action) where TView : Element
        {
            action?.Invoke(view);
            return view;
        }

        public static TView Row<TView>(this TView view, int row, int span = 1) where TView : View
        {
            view.SetValue(Grid.RowProperty, row);
            if (span != 1) view.SetValue(Grid.RowSpanProperty, span);
            return view;
        }

        public static TView RowSpan<TView>(this TView view, int span) where TView : View
        {
            view.SetValue(Grid.RowSpanProperty, span);
            return view;
        }

        public static TView Col<TView>(this TView view, int col, int span = 1) where TView : View
        {
            view.SetValue(Grid.ColumnProperty, col);
            if (span != 1) view.SetValue(Grid.ColumnSpanProperty, span);
            return view;
        }

        public static TView ColSpan<TView>(this TView view, int span) where TView : View
        {
            if (span != 1) view.SetValue(Grid.ColumnSpanProperty, span);
            return view;
        }

        public static TView RowCol<TView>(this TView view, int row, int col, int rowSpan = 1, int colSpan = 1) where TView : View
        {
            view.SetValue(Grid.RowProperty, row);
            view.SetValue(Grid.ColumnProperty, col);
            if (rowSpan != 1) view.SetValue(Grid.RowSpanProperty, rowSpan);
            if (colSpan != 1) view.SetValue(Grid.ColumnSpanProperty, colSpan);
            return view;
        }

        public static TView Left<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.Start; return view; }
        public static TView CenterH<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.Center; return view; }
        public static TView FillH<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.Fill; return view; }
        public static TView Right<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.End; return view; }

        public static TView LeftExpand<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.StartAndExpand; return view; }
        public static TView CenterExpandH<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.CenterAndExpand; return view; }
        public static TView FillExpandH<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.FillAndExpand; return view; }
        public static TView RightExpand<TView>(this TView view) where TView : View { view.HorizontalOptions = LayoutOptions.EndAndExpand; return view; }

        public static TView Top<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.Start; return view; }
        public static TView Bottom<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.End; return view; }
        public static TView CenterV<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.Center; return view; }
        public static TView FillV<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.Fill; return view; }

        public static TView TopExpand<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.StartAndExpand; return view; }
        public static TView BottomExpand<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.EndAndExpand; return view; }
        public static TView CenterExpandV<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.CenterAndExpand; return view; }
        public static TView FillExpandV<TView>(this TView view) where TView : View { view.VerticalOptions = LayoutOptions.FillAndExpand; return view; }

        public static TView Center<TView>(this TView view) where TView : View => view.CenterH().CenterV();
        public static TView Fill<TView>(this TView view) where TView : View => view.FillH().FillV();
        public static TView CenterExpand<TView>(this TView view) where TView : View => view.CenterExpandH().CenterExpandV();
        public static TView FillExpand<TView>(this TView view) where TView : View => view.FillExpandH().FillExpandV();

        public static TView Margin<TView>(this TView view, Thickness margin) where TView : View { view.Margin = margin; return view; }
        public static TView Margin<TView>(this TView view, double horizontalSize, double verticalSize) where TView : View { view.Margin = new Thickness(horizontalSize, verticalSize); return view; }
        public static TView Margin<TView>(this TView view, double left, double top, double right, double bottom) where TView : View { view.Margin = new Thickness(left, top, right, bottom); return view; }

        public static TLayout Padding<TLayout>(this TLayout layout, Thickness padding) where TLayout : Layout { layout.Padding = padding; return layout; }
        public static TLayout Padding<TLayout>(this TLayout layout, double horizontalSize, double verticalSize) where TLayout : Layout { layout.Padding = new Thickness(horizontalSize, verticalSize); return layout; }
        public static TLayout Padding<TLayout>(this TLayout layout, double left, double top, double right, double bottom) where TLayout : Layout { layout.Padding = new Thickness(left, top, right, bottom); return layout; }

        public static TLabel TextLeft<TLabel>(this TLabel label) where TLabel : Label { label.HorizontalTextAlignment = TextAlignment.Start; return label; }
        public static TLabel TextCenterH<TLabel>(this TLabel label) where TLabel : Label { label.HorizontalTextAlignment = TextAlignment.Center; return label; }
        public static TLabel TextRight<TLabel>(this TLabel label) where TLabel : Label { label.HorizontalTextAlignment = TextAlignment.End; return label; }

        public static TLabel TextTop<TLabel>(this TLabel label) where TLabel : Label { label.VerticalTextAlignment = TextAlignment.Start; return label; }
        public static TLabel TextCenterV<TLabel>(this TLabel label) where TLabel : Label { label.VerticalTextAlignment = TextAlignment.Center; return label; }
        public static TLabel TextBottom<TLabel>(this TLabel label) where TLabel : Label { label.VerticalTextAlignment = TextAlignment.End; return label; }

        public static TLabel TextCenter<TLabel>(this TLabel label) where TLabel : Label => label.CenterH().CenterV();

        public static TElement Height<TElement>(this TElement element, double request) where TElement : VisualElement { element.HeightRequest = request; return element; }
        public static TElement Width<TElement>(this TElement element, double request) where TElement : VisualElement { element.WidthRequest = request; return element; }
        public static TElement MinHeight<TElement>(this TElement element, double request) where TElement : VisualElement { element.MinimumHeightRequest = request; return element; }
        public static TElement MinWidth<TElement>(this TElement element, double request) where TElement : VisualElement { element.MinimumWidthRequest = request; return element; }

        public static TElement Size<TElement>(this TElement element, double widthRequest, double heightRequest) where TElement : VisualElement => element.Width(widthRequest).Height(heightRequest);
        public static TElement Size<TElement>(this TElement element, double sizeRequest) where TElement : VisualElement => element.Width(sizeRequest).Height(sizeRequest);
        public static TElement MinSize<TElement>(this TElement element, double widthRequest, double heightRequest) where TElement : VisualElement => element.MinWidth(widthRequest).MinHeight(heightRequest);
        public static TElement MinSize<TElement>(this TElement element, double sizeRequest) where TElement : VisualElement => element.MinWidth(sizeRequest).MinHeight(sizeRequest);
    }
}

