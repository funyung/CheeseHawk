using CheeseHawk.Models;
using CheeseHawk.Services;

namespace CheeseHawk.Views;

public partial class AddContactPage : ContentPage
{
	private string _inputName;
	private int _inputPhoneNumber;
	public AddContactPage()
	{
		InitializeComponent();
	}

	void OnNameCompleted(object sender, EventArgs e)
	{
		_inputName = ((Entry)sender).Text;
	}

	void OnPhoneNumberCompleted(object sender, EventArgs e)
	{
		string input = ((Entry)sender).Text;
		int phonenumber;

		//TODO: Verify phone number with Regex
		if (int.TryParse(input, out phonenumber))
			_inputPhoneNumber = phonenumber;
		else
			_inputPhoneNumber = 4206969;
	}


	private void AddContact(object sender, EventArgs e)
	{
		var newContact = new UserContact( _inputName, _inputPhoneNumber );

		//Push to current user
	}
}