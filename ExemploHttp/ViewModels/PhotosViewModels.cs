using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHttp.ViewModels
{
    public partial class PhotosViewModels: ObservableObject
    {
        [ObservableProperty]

        ObservableCollection<Photos> photos;


        public ICommand getPostsCommand { get; }

        public PostsViewModels()
        {
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts()
        {
            RestService postService = new RestService();
            Posts = await postService.getPostAsync();
        }
    }
}
