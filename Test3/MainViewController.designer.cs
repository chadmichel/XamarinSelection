// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Test3
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton yellowButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (yellowButton != null) {
				yellowButton.Dispose ();
				yellowButton = null;
			}
		}
	}
}