using Ecommerce.Data;
using E_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Refit;

namespace E_commerce.Repositorio
{
	public class LoginRepositorio : ILoginRepositorio
	{
		private readonly BancoContext _bancoContext;
        private readonly ILoginAPI _loginApiClient;

        public LoginRepositorio(BancoContext bancoContext, ILoginAPI IloginAPI)
		{
			_bancoContext = bancoContext;
            _loginApiClient = IloginAPI;
        }
		public LoginModel ListarPorUser(SignInModel signIn)
		{
			return _bancoContext.Login.FirstOrDefault(x => x.UserName == signIn.User);
		}

		public bool isValidLogin(SignInModel signIn)
		{
			bool isValid = false;
			LoginModel loginModel = new LoginModel();
			loginModel = ListarPorUser(signIn);

			signIn.SetPasswordHash();

			if (loginModel.UserName == signIn.User && loginModel.Password==signIn.Password)
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

        public async Task<ResponseModel> Adicionar(LoginModel login)
        {
            try
            {
                return await _loginApiClient.Adicionar(login);
            }
            catch (Exception ex)
            {
                // Log do erro
                Console.WriteLine($"Erro ao adicionar login: {ex.Message}");
                throw;
            }
        }

    }
}
