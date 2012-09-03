using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.Commands;

namespace SettingsSample.Core.ViewModels
{
	public class SettingsViewModel : BaseViewModel
	{
		private bool _notifications = false;
		private bool _shakeGestures = true;
		private bool _showMyLocation = false;

		public bool ShowMyLocation
		{
			get { return _showMyLocation; }
			set
			{
				_showMyLocation = value;
				FirePropertyChanged(() => ShowMyLocation);
			}
		}
		
		public bool ShakeGestures
		{
			get { return _shakeGestures; }
			set
			{
				_shakeGestures = value;
				FirePropertyChanged(() => ShakeGestures);
			}
		}
		
		public bool Notifications
		{
			get { return _notifications; }
			set
			{
				_notifications = value;
				FirePropertyChanged(() => Notifications);
			}
		}

		public IMvxCommand SaveSettingsCommand
		{
			get
			{
				return new MvxRelayCommand(() => {});
			}
		}
	}
}

