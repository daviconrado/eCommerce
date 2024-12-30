using E_commerce.Models;
using Refit;

namespace E_commerce.Repositorio
{
	public interface ILoginRepositorio
	{
		LoginModel ListarPorUser(SignInModel signIn);

		Task<ResponseModel> Adicionar(LoginModel login);
        LoginModel Atualizar(LoginModel login);

		bool isValidLogin(SignInModel signIn);
		bool isValidEmail(ForgotPasswordModel email);
    }
}
