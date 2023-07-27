﻿namespace CheeseHawk.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnCounterClicked2(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn2.Text = $"Clicked {count} time";
		else
			CounterBtn2.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn2.Text);
	}
}
