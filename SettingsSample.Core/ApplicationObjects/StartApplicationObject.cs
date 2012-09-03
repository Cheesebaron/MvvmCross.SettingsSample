using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ViewModels;
using SettingsSample.Core.ViewModels;

namespace SettingsSample.Core.ApplicationObjects
{
	public class StartApplicationObject : MvxApplicationObject, IMvxStartNavigation
	{
		private readonly bool _showSplashScreen;
		public StartApplicationObject(bool showSplashScreen)
		{
			_showSplashScreen = showSplashScreen;
		}
		
		public void Start()
		{
			if (_showSplashScreen)
			{
				RequestNavigate<SplashScreenViewModel>();
			}
			else
			{
				RequestNavigate<SettingsViewModel>();
			}
		}
		
		public bool ApplicationCanOpenBookmarks
		{
			get { return true; }
		}
	}
}
