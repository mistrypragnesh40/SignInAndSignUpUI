namespace SignInAndSignUpUI;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignIn");
	}
}