using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualChallenge
{
    public partial class VisualChallengePage : ContentPage
    {

        public List<Monkey> Monkeys;
        
        public VisualChallengePage()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>
            {
                new Monkey
                {
                    Name = "Common Marmoset",
                    Image = "https://www.monkeyworlds.com/wp-content/uploads/common_marmoset.jpg"
                },
                new Monkey
                {
                    Name = "Gibbon",
                    Image = "https://kids.nationalgeographic.com/content/dam/kids/photos/animals/Mammals/A-G/gibbon-tan-18778051.ngsversion.1415994938342.jpg"
                },
                new Monkey
                {
                    Name = "Proboscis",
                    Image = "https://www.neprimateconservancy.org/uploads/1/5/3/8/15380094/editor/borneo-205096-1280-proboscis_98.jpg"
                },
                new Monkey
                {
                    Name = "Pygmy",
                    Image = "https://www.certapet.com/wp-content/uploads/2017/08/pygmy-2.jpg"
                }
            };

            MonkeyList.ItemsSource = Monkeys;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/visual"));
        }



        public class Monkey
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }
    }
}