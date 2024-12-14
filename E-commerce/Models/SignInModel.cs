using E_commerce.Helper;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
	public class SignInModel
	{
		[Required]
		[StringLength(100)]
		public string User { get; set; }
		[Required]

		public string Password { get; set; }

		public void SetPasswordHash()
		{
			Password = Password.GerarHash();
		}
	}
}
