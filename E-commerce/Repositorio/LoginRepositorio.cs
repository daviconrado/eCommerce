using Ecommerce.Data;
using E_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Repositorio
{
	public class LoginRepositorio : ILoginRepositorio
	{
		private readonly BancoContext _bancoContext;

		public LoginRepositorio(BancoContext bancoContext)
		{
			_bancoContext = bancoContext;
		}
		public LoginModel Adicionar(LoginModel login)
		{
			login.SetPasswordHash();
			login.CreatedDate = DateTime.Now;
			login.UpdateDate = DateTime.Now;
			_bancoContext.Login.Add(login);
			_bancoContext.SaveChanges();

			return login;
		}
		public LoginModel ListarPorUser(SignInModel signIn)
		{
			return _bancoContext.Login.FirstOrDefault(x => x.User == signIn.User);
		}

		public bool isValidLogin(SignInModel signIn)
		{
			bool isValid = false;
			LoginModel loginModel = new LoginModel();
			loginModel = ListarPorUser(signIn);

			signIn.SetPasswordHash();

			if (loginModel.User == signIn.User && loginModel.Password==signIn.Password)
			{
				isValid = true;
			}

			return isValid;
			
		}

		LoginModel ILoginRepositorio.Atualizar(LoginModel login)
		{
			throw new NotImplementedException();
		}

		public bool isValidEmail(ForgotPasswordModel email)
		{
			bool isValid = true;
			var strEmail = email.E_mail;
			LoginModel loginModel = new LoginModel();
			loginModel = _bancoContext.Login.FirstOrDefault(x => x.Email == strEmail);

			if (loginModel == null)
			{
				isValid = false;
			}

			return isValid;
		}
	}
}
