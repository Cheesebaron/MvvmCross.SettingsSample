using Cirrious.MvvmCross.ViewModels;

namespace SettingsSample.Core.ViewModels
{
	public class BaseViewModel 
		: MvxViewModel
		//, IMvxServiceConsumer<IErrorReporter>
	{
		public BaseViewModel()
		{
			ViewUnRegistered += (s, e) =>
			{
				if (!HasViews)
				{
					OnViewsDetached();
				}
			};
		}
		
		public virtual void OnViewsDetached()
		{
			// nothing to do in this base class
		}
	}
}

