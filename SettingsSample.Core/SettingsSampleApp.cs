using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using SettingsSample.Core.ApplicationObjects;

namespace SettingsSample.Core
{
	public abstract class BaseSettingsSampleApp
		: MvxApplication
		, IMvxServiceProducer<IMvxStartNavigation>
	{
		protected BaseSettingsSampleApp()
		{
			InitializeErrorSystem();
			InitalizeServices();
			InitializeStartNavigation();
		}
		
		private void InitalizeServices()
		{
		}
		
		private void InitializeErrorSystem()
		{
		}
		
		protected abstract void InitializeStartNavigation();
	}
	
	public class SettingsSampleApp : BaseSettingsSampleApp
	{
		protected override void InitializeStartNavigation()
		{
			var startApplicationObject = new StartApplicationObject(true); //set argument to true for SplashScreen
			this.RegisterServiceInstance<IMvxStartNavigation>(startApplicationObject);
		}
	}
	
	public class SettingsSampleAppNoSplashScreen : BaseSettingsSampleApp
	{
		protected override void InitializeStartNavigation()
		{
			var startApplicationObject = new StartApplicationObject(false); //set argument to true for SplashScreen
			this.RegisterServiceInstance<IMvxStartNavigation>(startApplicationObject);
		}
	}
}
