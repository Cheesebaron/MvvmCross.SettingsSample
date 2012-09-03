using Cirrious.MvvmCross.Converters;
using Cirrious.MvvmCross.Converters.Visibility;

namespace SettingsSample.Core.Converters
{
	public class Converters
	{
		public readonly MvxVisibilityConverter Visibility = new MvxVisibilityConverter();
		public readonly MvxLanguageBinderConverter Language = new MvxLanguageBinderConverter();
	}
}

