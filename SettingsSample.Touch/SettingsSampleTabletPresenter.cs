using System;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.Touch.Interfaces;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using MonoTouch.UIKit;
using SettingsSample.Touch.Views;

namespace SettingsSample.Touch
{
	public class SettingsSampleTabletPresenter
		: MvxBaseTouchViewPresenter
			, IMvxServiceConsumer<IMvxTouchViewCreator>
	{
		private readonly UIApplicationDelegate _applicationDelegate;
		private readonly UIWindow _window;
		private readonly SplitViewController _splitView;
		
		public SettingsSampleTabletPresenter (UIApplicationDelegate applicationDelegate, UIWindow window)
		{
			_applicationDelegate = applicationDelegate;
			_window = window;
			_splitView = new SplitViewController();
			_window.RootViewController = _splitView;
		}
		
		public override void Show(Cirrious.MvvmCross.Views.MvxShowViewModelRequest request)
		{
			var view = this.GetService<IMvxTouchViewCreator>().CreateView(request);
			Show(view);
		}
		
		private void Show(IMvxTouchView view)
		{
			throw new NotImplementedException();
			/*if (view is HomeView)
			{
				_splitView.SetPrimaryView(view);
			}
			else
			{
				_splitView.SetSecondaryView(view);
			}*/
		}
		
		public override void NativeModalViewControllerDisappearedOnItsOwn()
		{
			throw new NotImplementedException();
		}
		
		public override void ClearBackStack()
		{
			throw new NotImplementedException();
		}
		
		public override void Close(IMvxViewModel viewModel)
		{
			throw new NotImplementedException();
		}
		
		public override bool PresentModalViewController(UIViewController viewController, bool animated)
		{
			throw new NotImplementedException();
		}
	}
}

