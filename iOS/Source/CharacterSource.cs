using MvvmCross.Binding.iOS.Views;
using Ossus.iOS.Views.Cells;
using UIKit;

namespace Ossus.iOS.Source
{
    public class CharacterSource : MvxSimpleTableViewSource
    {
        public CharacterSource(UITableView tableView) : base(tableView, typeof(CharacterCell))
        {
            DeselectAutomatically = true;
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, Foundation.NSIndexPath indexPath, object item)
        {
            var cell = base.GetOrCreateCellFor(tableView, indexPath, item) as CharacterCell;

            return cell;
        }
    }
}
