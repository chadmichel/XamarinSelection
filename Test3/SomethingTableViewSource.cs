using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Test3
{
    public class SomethingTableViewSource : UITableViewSource
    {
        UINavigationController navigationController;
        string[] accountTypesItems;
        string cellIdentifier = "DPGAddAcctTableCell";

        public SomethingTableViewSource (UINavigationController navController, string[] accountTypes)
        {
            navigationController = navController;
            accountTypesItems = accountTypes;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var vc = AppDelegate.Storyboard.InstantiateViewController("AnotherViewController")
            as AnotherViewController;

            navigationController.PushViewController(vc, true);
        }

        public override int NumberOfSections (UITableView tableView)
        {
            // Will treat this as a single section for now
            return 1;
        }

        public override string TitleForHeader (UITableView tableView, int section)
        {
            return "Available Account Types";
        }

        public override int RowsInSection (UITableView tableview, int section)
        {
            return accountTypesItems.Length;
        }

        public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
        {
            // request a recycled cell to save memory
            UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
            // if there are no cells to reuse, create a new one
            if (cell == null)
                cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            cell.TextLabel.Text = accountTypesItems[indexPath.Row];
            return cell;
        }

        public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath)
        {
            Console.Write("Accessory detail clicked");
            Console.WriteLine();
            //var newViewController = new InstrDetailViewController(indexPath.Handle);
            //navigationController.PushViewController(newViewController, true);
        }
    }
}

