using System.Configuration;
using System.Data;
using System.Windows;

namespace CustomUIApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	protected override void OnExit(ExitEventArgs e)
	{
		MessageBox.Show("Program closed!");
	}
}