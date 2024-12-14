using E_commerce.Models;
using E_commerce.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
	public class LoginController : Controller
	{
		private readonly ILoginRepositorio _loginRepositorio;
		public LoginController(ILoginRepositorio loginRepositorio)
		{
			_loginRepositorio = loginRepositorio;
		}
		public IActionResult SignIn()
		{
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}
		public IActionResult ForgotPassword()
		{
			return View(new ForgotPasswordModel());
		}

		public IActionResult ResetPassword()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(LoginModel login)
		{
			if (ModelState.IsValid)
			{
				_loginRepositorio.Adicionar(login);
				TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso";
				return RedirectToAction("SignIn");
			}

			return View(login);
		}

		[HttpPost]
		public IActionResult SignIn(SignInModel signIn)
		{
			if (ModelState.IsValid)
			{
				bool a = _loginRepositorio.isValidLogin(signIn);

				if (a) 
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					TempData["MensagemErro"] = "Usuário ou senha incorretos";
				}
			}

			return View(signIn);
		}

		[HttpPost]
		public IActionResult ForgotPassword([FromForm]ForgotPasswordModel email)
		{
			if (ModelState.IsValid)
			{
				bool a = _loginRepositorio.isValidEmail(email);

				if (a)
				{
					return RedirectToAction("ResetPassword");
				}
				else
				{
					TempData["MensagemErro"] = "Email inválido/não cadastrado";
				}
			}

			return View(email);
		}


	}
}
