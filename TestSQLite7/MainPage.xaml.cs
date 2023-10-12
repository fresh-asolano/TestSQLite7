using TestSQLite7.ViewModel;

namespace TestSQLite7;

public partial class MainPage : ContentPage
{
	public MainPage(BookViewModel bookViewModel)
	{
		InitializeComponent();
		BindingContext = bookViewModel;
	}
}