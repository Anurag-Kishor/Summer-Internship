using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace TestApp1
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PlacesModel> Places;

        public ObservableCollection<PlacesModel> places
        {
            get { return Places; }
            set { 
                Places = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }

        public MainViewModel()
        {
            places = new ObservableCollection<PlacesModel>();
            addData();
        }

        private void addData()
        {
            places.Add(new PlacesModel
            {
                id = 1,
                title="Location 1",
                country="Country1",
                imgSource= "https://images.pexels.com/photos/1078981/pexels-photo-1078981.jpeg"
            });

            places.Add(new PlacesModel
            {
                id = 2,
                title = "Location 2",
                country = "Country2",
                imgSource = "https://images.pexels.com/photos/2743287/pexels-photo-2743287.jpeg"
            });
            places.Add(new PlacesModel
            {
                id = 3,
                title = "Location 3",
                country = "Country3",
                imgSource = "https://images.pexels.com/photos/4992620/pexels-photo-4992620.jpeg"
            });
            places.Add(new PlacesModel
            {
                id = 4,
                title = "Location 4",
                country = "Country4",
                imgSource = "https://images.pexels.com/photos/497845/pexels-photo-497845.jpeg"
            });
            places.Add(new PlacesModel
            {
                id = 5,
                title = "Location 5",
                country = "Country5",
                imgSource = "https://images.pexels.com/photos/392586/pexels-photo-392586.jpeg"
            });
        }
    }
}
