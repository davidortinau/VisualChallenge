using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
namespace VisualChallenge
{
    public class VisualChallengePage : ContentPage
    {
        public static Color QantasLightGray = Color.FromRgb(243, 243, 243);
        public static Color QantasRed = Color.FromHex("E80000");

        public static string RegularFont =>
            Device.RuntimePlatform == Device.iOS
                ? "Ciutadella-Rg"
                : "ciutadella_regular.ttf#Regular";

        public static string MediumFont =>
            Device.RuntimePlatform == Device.iOS
                ? "Ciutadella-Md"
                : "ciutadella_medium.ttf#Regular";

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
        } 

        public VisualChallengePage()
        {
            On<iOS>().SetUseSafeArea(false);

            BackgroundColor = QantasLightGray;
            Visual = VisualMarker.Material;
            TranslationY = -1;
            
            Content = GetContent();
        }

        private View GetContent() =>
            new Xamarin.Forms.ScrollView
            {
                Margin = 0,
                Content =
                    new StackLayout
                    {
                        Children =
                        {
                            HeaderView(),
                            new StackLayout
                            {
                                Padding = 20,
                                Spacing = 0,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Trip to Melbourne",
                                        FontFamily = MediumFont,
                                        FontSize = 22
                                    },
                                    new Label
                                    {
                                        Text = "VIEW TRIP  >",
                                        TextColor = QantasRed,
                                        FontFamily = MediumFont,
                                        FontSize = 16
                                    }.Right(),

                                    TripCheckIn(),
                                    TripDetails()
                                }
                            }
                        }
                    }
            };

        private Grid HeaderView() =>
            new Grid
            {
                RowSpacing = 8,
                ColumnSpacing = 0,
                Padding = new Thickness(20, 0, 0, 0),
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(.65, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(.35, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(.5, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(.5, GridUnitType.Star)}
                },
                HeightRequest = 180,
                BackgroundColor = Color.White,
                Children =
                {
                    HeaderTitleValueView("Points", "370,582")
                        .Row(1).Col(0),

                    HeaderTitleValueView("Status", "50")
                        .Row(1).Col(1),

                    new Label
                    {
                        Text = "Hello Ryan K",
                        FontFamily = RegularFont,
                        FontSize = 28
                    }.Row(0).Col(0).Bottom(),

                    new Image
                    {
                        Source = ImageSource.FromFile("shapes_default"),
                        TranslationX = 1
                    }
                    .Row(0).Col(1).Right()
                }
            };

        private static Frame TripCheckIn() =>
            new Frame
            {
                Margin = new Thickness(0, 12),
                Padding = new Thickness(15),
                Content =
                    new Grid
                    {
                        ColumnSpacing = 8,
                        ColumnDefinitions =
                        {
                            new ColumnDefinition
                                {Width = new GridLength(32, GridUnitType.Absolute)},
                            new ColumnDefinition {Width = GridLength.Star}
                        },
                        Children =
                        {
                            new Image
                            {
                                Source = ImageSource.FromFile("ic_check_in")
                            }.Row(0).Col(0).CenterH().Top(),
                            new Label
                            {
                                FormattedText = new FormattedString
                                {
                                    Spans =
                                    {
                                        new Span
                                        {
                                            FontFamily = RegularFont,
                                            FontSize = 18,
                                            TextColor = Color.Black,
                                            Text = "Check-in opens in 2 weeks and 2 days"
                                        },
                                        new Span
                                        {
                                            FontFamily = RegularFont,
                                            FontSize = 14,
                                            TextColor = Color.Gray,
                                            Text = "\r\nCheck-in is available 24h before departure.",
                                            LineHeight = 1.2
                                        }
                                    }
                                }
                            }.Row(0).Col(1).Left().Top()
                        }
                    }
            };

        private Frame TripDetails() =>
            new Frame
            {
                Margin = 0,
                Padding = 0,
                Content =
                    new StackLayout
                    {
                        Spacing = 0,
                        Children =
                        {
                            new Grid
                            {
                                Margin = new Thickness(0, 12),
                                Padding = new Thickness(15),
                                ColumnSpacing = 8,
                                ColumnDefinitions =
                                {
                                    new ColumnDefinition {Width = new GridLength(32, GridUnitType.Absolute)},
                                    new ColumnDefinition {Width = GridLength.Star}
                                },
                                Children =
                                {
                                    new Image
                                    {
                                        Source = ImageSource.FromFile("ic_launcher_round"),
                                        Aspect = Aspect.AspectFill,
                                        Scale = 1.4,
                                        TranslationY = 4
                                    }.Row(0).Col(0).CenterH().Top(),

                                    new StackLayout
                                        {
                                            Spacing = 14,
                                            Children =
                                            {
                                                new Label
                                                {
                                                    FormattedText = new FormattedString
                                                    {
                                                        Spans =
                                                        {
                                                            new Span
                                                            {
                                                                FontFamily = RegularFont,
                                                                FontSize = 18,
                                                                TextColor = Color.Black,
                                                                Text = "Brisbane to Melbourne"
                                                            },
                                                            new Span
                                                            {
                                                                FontFamily = RegularFont,
                                                                FontSize = 14,
                                                                TextColor = Color.Gray,
                                                                Text = "\r\nQF615 • Wed, 17 Apr 2019",
                                                                LineHeight = 1.2
                                                            }
                                                        }
                                                    }
                                                },
                                                new StackLayout
                                                {
                                                    Orientation = StackOrientation.Horizontal,
                                                    Spacing = 25,
                                                    Children =
                                                    {
                                                        FlightTimeLocationView("10:10", "Terminal D"),
                                                        new Image
                                                        {
                                                            Source = ImageSource.FromFile("ic_plane"),
                                                            Opacity = .4, Scale = .75
                                                        }.Top(),
                                                        FlightTimeLocationView("12:35","Terminal 1")
                                                    }
                                                }
                                            }
                                        }
                                        .Row(0).Col(1).Left().Top()
                                }
                            },
                            SeatCell("ic_seat", "3F (window)"),
                            TripInteractionCell("ic_seat", "SELECT SEATS"),
                            TripInteractionCell("ic_baggage", "VIEW/PURCHASE BAGS"),
                            TripInteractionCell("ic_more_info_16dp", "VIEW FLIGHT DETAILS")
                        }
                    }
            };

        public Label HeaderTitleValueView(string title, string value) =>
            new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span {FontFamily = RegularFont, FontSize = 16, TextColor = Color.Gray, Text = title},
                        new Span {Text = "  "},
                        new Span {FontFamily = RegularFont, FontSize = 20, TextColor = Color.Black, Text = value},
                        new Span {Text = " "},
                        new Span {FontFamily = RegularFont, FontSize = 22, TextColor = Color.Gray, Text = ">"}
                    }
                }
            };

        public Label FlightTimeLocationView(string time, string location) =>
            new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span {FontFamily = RegularFont, FontSize = 22, TextColor = Color.Black, Text = time},
                        new Span {Text = "\r\n"},
                        new Span {FontFamily = RegularFont, FontSize = 14, TextColor = Color.Gray, Text = location}
                    }
                }
            };

        public View SeatCell(string icon, string text) =>
            new ContentView
            {
                BackgroundColor = Color.FromRgb(240, 240, 240),
                Padding = new Thickness(-1, 1),
                Content = new StackLayout
                {
                    Padding = new Thickness(16, 12),
                    Orientation = StackOrientation.Horizontal,
                    BackgroundColor = QantasLightGray,
                    HeightRequest = 30,
                    Children =
                    {
                        new Image
                        {
                            Source = ImageSource.FromFile(icon),
                            Scale = .65,
                            Aspect = Aspect.AspectFit,
                            WidthRequest = 30
                        }.CenterH().CenterV(),
                        new Label
                        {
                            FontFamily = RegularFont,
                            FontSize = 16,
                            TextColor = Color.Black,
                            Text = text,
                            TranslationY = 2
                        }.CenterV()
                    }
                }
            };

        public View TripInteractionCell(string icon, string text) =>
            new ContentView
            {
                BackgroundColor = Color.FromRgb(240, 240, 240),
                Padding = new Thickness(-1, 1),
                Content = new StackLayout
                {
                    Padding = new Thickness(16, 12),
                    Orientation = StackOrientation.Horizontal,
                    BackgroundColor = Color.White,
                    HeightRequest = 22,
                    Children =
                    {
                        new Image
                        {
                            Source = ImageSource.FromFile(icon),
                            Scale = .65,
                            Aspect = Aspect.AspectFit, 
                            WidthRequest = 30
                        }.CenterH().CenterV(),
                        new Label
                        {
                            FontFamily = MediumFont,
                            FontSize = 16,
                            TextColor = QantasRed,
                            Text = text,
                            TranslationY = 2
                        }.CenterV()
                    }
                } 
            };
    }
}