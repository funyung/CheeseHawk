using CheeseHawk.Models;
using CheeseHawk.Services;

namespace CheeseHawk.Views;

public partial class NewUserPage : ContentPage
{
	private string _inputUserName;
	private int _inputPhoneNumber;
	public NewUserPage()
	{
		InitializeComponent();
	}

	void OnUserNameCompleted(object sender, EventArgs e)
	{
		_inputUserName = ((Entry)sender).Text;
	}

	void OnPhoneNumberCompleted(object sender, EventArgs e)
	{
		string input = ((Entry)sender).Text;
		int phonenumber;
		if (int.TryParse(input, out phonenumber))
			_inputPhoneNumber = phonenumber;
		else
			_inputPhoneNumber = 4206969;
	}


	private void SaveUser(object sender, EventArgs e)
	{
		using var db = new CheeseHawkContext();

		db.Add(new User { UserName = _inputUserName, PhoneNumber = _inputPhoneNumber });
	}
}