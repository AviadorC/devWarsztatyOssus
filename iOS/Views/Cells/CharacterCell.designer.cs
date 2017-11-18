// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Ossus.iOS.Views.Cells
{
	[Register ("CharacterCell")]
	partial class CharacterCell
	{
		[Outlet]
		UIKit.UILabel BirthDateLabel { get; set; }

		[Outlet]
		UIKit.UILabel MassLabel { get; set; }

		[Outlet]
		UIKit.UILabel NameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BirthDateLabel != null) {
				BirthDateLabel.Dispose ();
				BirthDateLabel = null;
			}

			if (MassLabel != null) {
				MassLabel.Dispose ();
				MassLabel = null;
			}

			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
		}
	}
}
