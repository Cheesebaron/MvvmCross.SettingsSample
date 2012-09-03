using System;
using Cirrious.MvvmCross.Dialog.Touch;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.Touch.Interfaces;
using Cirrious.MvvmCross.Binding.Binders;
using SettingsSample.Core;
using SettingsSample.Core.Converters;

namespace SettingsSample.Touch
{
	public class Setup
		: MvxTouchDialogBindingSetup
	{
		public Setup (MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}
		
		protected override MvxApplication CreateApp()
		{
			var app = new SettingsSampleAppNoSplashScreen();
			return app;
		}
		
		protected override void FillValueConverters(Cirrious.MvvmCross.Binding.Interfaces.Binders.IMvxValueConverterRegistry registry)
		{
			base.FillValueConverters(registry);
			
			var filler = new MvxInstanceBasedValueConverterRegistryFiller(registry);
			filler.AddFieldConverters(typeof(Converters));
		}
		
		protected override void FillTargetFactories (Cirrious.MvvmCross.Binding.Interfaces.Bindings.Target.Construction.IMvxTargetBindingFactoryRegistry registry)
		{
			base.FillTargetFactories (registry);
			//registry.RegisterFactory(new MvxSimplePropertyInfoTargetBindingFactory(typeof(MvxValueElementValueBinding<bool>), typeof(BooleanElement), "Value"));
		}
	}
}

