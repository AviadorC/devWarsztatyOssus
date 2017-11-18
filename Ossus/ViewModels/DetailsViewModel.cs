using System;
using MvvmCross.Core.ViewModels;
using Ossus.Model;

namespace Ossus.ViewModels
{
    public class DetailsViewModel : MvxViewModel<Character>
    {
        public DetailsViewModel()
        {
        }

        public override void Prepare(Character parameter)
        {
            throw new NotImplementedException();
        }
    }
}
