using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using Ossus.Model;
using UIKit;

namespace Ossus.iOS.Views.Cells
{
    public partial class CharacterCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CharacterCell");
        public static readonly UINib Nib;

        static CharacterCell()
        {
            Nib = UINib.FromName("CharacterCell", NSBundle.MainBundle);
        }

        protected CharacterCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<CharacterCell, Character>();
                set.Bind(NameLabel).To(vm => vm.Name);
                set.Bind(BirthDateLabel).To(vm => vm.BirthYear);
                set.Bind(MassLabel).To(vm => vm.Mass);
                set.Bind(this).For(v => v.IsWinner).To(vm => vm.Name);
                set.Apply();
            });
        }

        public void InvalidateCell()
        {
            NameLabel.Text = "??";
        }

        private string isWinner;
        public string IsWinner
        {
            get { return isWinner; }
            set
            {
                isWinner = value;
                InvalidateCell();
            }
        }
    }
}
