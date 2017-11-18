using System;

using Foundation;
using UIKit;

namespace Ossus.iOS.Views.Cells
{
    public partial class CharacterCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CharacterCell");
        public static readonly UINib Nib;

        static CharacterCell()
        {
            Nib = UINib.FromName("CharacterCell", NSBundle.MainBundle);
        }

        protected CharacterCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
