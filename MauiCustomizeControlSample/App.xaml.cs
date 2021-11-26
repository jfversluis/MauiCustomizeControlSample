#if __ANDROID__
using Android.Content.Res;
#endif
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Graphics;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiCustomizeControlSample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.EntryMapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
#if __ANDROID__
				handler.NativeView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
			});

            MainPage = new MainPage();
		}
	}
}
