﻿namespace jculcayBT2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new Vistas.CalculoNotas();
		MainPage = new NavigationPage(new Vistas.Vlogin("a", "b"));
    }
}
