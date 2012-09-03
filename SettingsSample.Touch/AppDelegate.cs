using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using Cirrious.MvvmCross.Touch.Interfaces;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;

namespace SettingsSample.Touch
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate
		: MvxApplicationDelegate
		, IMvxServiceConsumer<IMvxStartNavigation>
	{
		// class-level declarations
		UIWindow _window;
		
		public static bool IsPhone
		{
			get
			{
				return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
			}
		}
		
		public static bool IsPad
		{
			get
			{
				return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad;
			}
		}
		
		public static bool HasRetina
		{
			get
			{
				if (MonoTouch.UIKit.UIScreen.MainScreen.RespondsToSelector(new Selector("scale")))
					return (MonoTouch.UIKit.UIScreen.MainScreen.Scale == 2.0);
				else
					return false;
			}
		}

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			_window = new UIWindow(UIScreen.MainScreen.Bounds);
			
			var presenter = 
				IsPad 
					? (IMvxTouchViewPresenter)new SettingsSampleTabletPresenter(this, _window) 
					: (IMvxTouchViewPresenter)new SettingsSamplePhonePresenter(this, _window);
			
			var setup = new Setup(this, presenter);
			setup.Initialize();
			
			var start = this.GetService<IMvxStartNavigation>();
			start.Start();

			_window.MakeKeyAndVisible();
			
			return true;
		}
	}
}

