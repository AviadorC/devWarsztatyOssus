using System;
using System.Threading.Tasks;
using Ossus.Model;
using Refit;

namespace Ossus.Services
{
    public interface ISWApi
    {
        [Get("/people/?page={page}")]
        Task<GeneralResponse<Character>> GetCharacters(int page);
    }
}
