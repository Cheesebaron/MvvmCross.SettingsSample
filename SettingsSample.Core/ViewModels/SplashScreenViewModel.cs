using Cirrious.MvvmCross.Interfaces.ServiceProvider;

namespace SettingsSample.Core.ViewModels
{
	public class SplashScreenViewModel : BaseViewModel
	{
		public SplashScreenViewModel ()
		{
			RequestNavigate<SettingsViewModel>(true);
		}
	}
}

