using E_commerce.Models;
using Refit;

namespace E_commerce.Repositorio
{
    public interface ILoginAPI
    {
        [Post("/Register")]
        Task<ResponseModel> Adicionar(LoginModel login);
    }
}
