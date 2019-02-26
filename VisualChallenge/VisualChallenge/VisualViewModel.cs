using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace VisualChallenge
{
    sealed class VisualViewModel : INotifyPropertyChanged
    {
        #region Property Event

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(ref T backingStore, T value, Action onChanged = null, [CallerMemberName]string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return;

            backingStore = value;

            onChanged?.Invoke();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public ObservableCollection<Items> GitHubs { get; private set; } = new ObservableCollection<Items>();

        public ObservableCollection<Items> Places { get; private set; } = new ObservableCollection<Items>();

        Random random;

        public VisualViewModel()
        {
            random = new Random();
            AddItems();
        }

        void AddItems()
        {
            for (int i = 0; i < 10; i++)
            {
                GitHubs.Add(new Items { ImageUrl = "https://octodex.github.com/images/labtocat.png", Description = $"Item {i}" });
                Places.Add(new Items { ImageUrl = PlaceUrl(random.Next(1, 4)) });
            }


        }


        string PlaceUrl(int count)
        {
            switch (count)
            {
                case 1:
                    return "https://proxy.duckduckgo.com/iu/?u=https%3A%2F%2Fimage.afcdn.com%2Falbum%2FD20160415%2Flos-50-lugares-mas-bonitos-del-mundo-phalbm24787335_w660cxt0cyt0cxb650cyb430.jpg&f=1";
                case 2:
                    return "https://proxy.duckduckgo.com/iu/?u=https%3A%2F%2Fs2.glbimg.com%2FyTEpt7TCFEtLb3BjrOwwZZWb5Jk%3D%2F620x550%2Fe.glbimg.com%2Fog%2Fed%2Ff%2Foriginal%2F2018%2F07%2F13%2Fponte_rakotz.jpg&f=1";
                case 3:
                    return "https://proxy.duckduckgo.com/iu/?u=http%3A%2F%2Fblog.wollner.com.br%2Fwp-content%2Fuploads%2F2018%2F03%2F182073-top-5-lugares-mais-bonitos-do-brasil.jpg&f=1";
                case 4:
                    return "https://proxy.duckduckgo.com/iu/?u=https%3A%2F%2Fgds.portal5g-media.com%2FcontentFiles%2Fsystem%2Fpictures%2F2015%2F1%2F126304%2Fcropped%2Fevery.jpg&f=1";
                default:
                    break;
            }

            return null;
        }
    }



    sealed class Items
    {
        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
