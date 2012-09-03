using Cirrious.MvvmCross.Touch.Views.Presenters;
using MonoTouch.UIKit;

namespace SettingsSample.Touch
{
	public class SettingsSamplePhonePresenter
		: MvxModalSupportTouchViewPresenter
	{
		public SettingsSamplePhonePresenter (UIApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}
		
		protected override UINavigationController CreateNavigationController (UIViewController viewController)
		{
			var toReturn = base.CreateNavigationController (viewController);
			toReturn.NavigationBarHidden = false;
			return toReturn;
		}
	}
}

