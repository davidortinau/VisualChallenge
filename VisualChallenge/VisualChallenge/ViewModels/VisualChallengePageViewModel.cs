using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace VisualChallenge.ViewModels
{
    public class VisualChallengePageViewModel : INotifyPropertyChanged
    {

        public VisualChallengePageViewModel()
        {
            BuildCrops();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<CropItemViewModel> crops;

        public ObservableCollection<CropItemViewModel> Crops
        {
            get { return crops; }
            set { crops = value; OnPropertyChanged(nameof(Crops)); }
        }

        private void BuildCrops()
        {
            Crops = new ObservableCollection<CropItemViewModel>();
            for(var i = 0; i < 21; i++)
            {
                Crops.Add(new CropItemViewModel
                {
                    Name = $"Item {i}",
                    IsSelected = false,
                    ImageSource = ImageSource.FromResource("VisualChallenge.Images.ico_sprouts_color.png")
                });
            }
        }

    }
}
