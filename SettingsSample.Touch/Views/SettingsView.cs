using System;

using SettingsSample.Core.ViewModels;
using Cirrious.MvvmCross.Dialog.Touch;
using Cirrious.MvvmCross.Views;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Dialog.Touch.Dialog.Elements;

namespace SettingsSample.Touch.Views
{
	public class SettingsView
		: MvxTouchDialogViewController<SettingsViewModel>
	{
		public SettingsView(MvxShowViewModelRequest request) 
			: base(request, UITableViewStyle.Grouped, null, true)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem("Save", UIBarButtonItemStyle.Bordered, null), false);
			NavigationItem.LeftBarButtonItem.Clicked += delegate
			{
				ViewModel.SaveSettingsCommand.Execute();
			};

			this.Root = new RootElement("Settings")
			{
				new Section("Test", string.Format("Choose to see your own location on the map.{0}Choose to allow shake gestures.{0}Choose whether you want to receive notifications.", Environment.NewLine))
				{
					new BooleanElement("Show my location", ViewModel.ShowMyLocation).Bind(this, "{'Value':{'Path':'ShowMyLocation','Mode':'TwoWay'}}"),
					new BooleanElement("Shake gestures", ViewModel.ShakeGestures).Bind(this, "{'Value':{'Path':'ShakeGestures','Mode':'TwoWay'}}"),
					new BooleanElement("Notifications", ViewModel.Notifications).Bind(this, "{'Value':{'Path':'Notifications','Mode':'TwoWay'}}"),
				},
			};
		}
	}
}

