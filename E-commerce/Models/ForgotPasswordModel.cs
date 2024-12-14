using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
	public class ForgotPasswordModel
	{
		[Required(ErrorMessage = "O campo Email é obrigatório.")]
		[EmailAddress(ErrorMessage = "O campo Email não é um endereço válido.")]
		public string E_mail { get; set; }
	}
}
