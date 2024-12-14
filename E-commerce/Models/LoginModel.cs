using E_commerce.Helper;
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
	public class LoginModel
	{
		public int Id {  get; set; }
		[Required]
		[StringLength(100)]
		public string User {  get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]

		public string Password { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime UpdateDate { get; set; }

		public void SetPasswordHash()
		{
			Password = Password.GerarHash();
		}
	}
}
