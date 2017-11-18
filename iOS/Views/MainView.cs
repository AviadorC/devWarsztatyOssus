using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Ossus.iOS.Source;
using UIKit;

namespace Ossus.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var _source = new CharacterSource(CharactersTableView);
            CharactersTableView.Source = _source;

            CharactersTableView.RowHeight = UITableView.AutomaticDimension;
            CharactersTableView.EstimatedRowHeight = 44f;

            var set = this.CreateBindingSet<MainView, ViewModels.MainViewModel>();
            set.Bind(_source).For(v => v.ItemsSource).To(vm => vm.Characters);
            set.Apply();
        }
    }
}
