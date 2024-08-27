using ExemploHttp.ViewModels;

namespace ExemploHttp.View;

public partial class PhotosView : ContentPage
{
	public PhotosView()
	{
		InitializeComponent();
        BindingContext = new PhotosViewModels();
    }
}