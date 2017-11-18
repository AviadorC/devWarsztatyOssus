using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Ossus.Model;
using Ossus.Services;
using Refit;

namespace Ossus.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            Characters = new MvxObservableCollection<Character>();

            CharacterSelected = new MvxAsyncCommand<Character>(CharacterSelectedAction);
        }

        public IMvxCommand<Character> CharacterSelected { get; private set; } 

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private MvxObservableCollection<Character> _characters;
        public MvxObservableCollection<Character> Characters
        {
            get { return _characters; }
            set
            {
                _characters = value;
                RaisePropertyChanged(() => Characters);
            }
        }

        public override Task Initialize()
        {
            GetData();

            return base.Initialize();
        }

        private async void GetData() 
        {
            var swapi = RestService.For<ISWApi>("https://swapi.co/api");

            var characters = await swapi.GetCharacters(1);

            Characters.AddRange(characters.Results);
        }

        private async Task CharacterSelectedAction(Character selectedCharacter)
        {
            await _navigationService.Navigate<DetailsViewModel, Character>(selectedCharacter);
        }
    }
}


