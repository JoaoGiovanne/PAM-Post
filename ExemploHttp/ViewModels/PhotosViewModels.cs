using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ViewModels
{
    public partial class PhotosViewModels : ObservableObject
    {
        [ObservableProperty]

        ObservableCollection<Photo> photos;


        public ICommand getPhotosCommand { get; }

        public PhotosViewModels()
        {
            getPhotosCommand = new Command(getPhoto);
        }

        public async void getPhoto()
        {
            RestServicePhotos photosService = new RestServicePhotos();
            photos = await photosService.getPhotosAsync();
        }
    }
}
