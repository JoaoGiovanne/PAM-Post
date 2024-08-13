using ExemploHttp.ViewModels;
namespace ExemploHttp.View;

public partial class PostsView : ContentPage
{
	public PostsView()
	{
		InitializeComponent();
		BindingContext = new PostsViewModels();

	}
}