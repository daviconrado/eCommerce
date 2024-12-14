using E_commerce.Models;

namespace E_commerce.Repositorio
{
	public interface ILoginRepositorio
	{
		LoginModel ListarPorUser(SignInModel signIn);
		LoginModel Adicionar(LoginModel login);
		LoginModel Atualizar(LoginModel login);

		bool isValidLogin(SignInModel signIn);
		bool isValidEmail(ForgotPasswordModel email);

	}
}
