// This file has been autogenerated from a class added in the UI designer.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Test3
{
	public partial class SomethingViewController : UITableViewController
	{
        string[] types = new string[] {"Passbook", "PayPal",
            "Google Wallet", "Amazon", "Zappos", "Best Buy", "eBay"};

		public SomethingViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad ();

            this.TableView.Source = new SomethingTableViewSource (this.NavigationController, types);
        }
	}
}