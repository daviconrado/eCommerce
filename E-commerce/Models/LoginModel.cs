using E_commerce.Helper;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace E_commerce.Models
{
	public class LoginModel : IdentityUser
	{
		[JsonPropertyName("user")]
		public new string UserName
		{
			get => base.UserName;
			set => base.UserName = value;
		}

		[JsonPropertyName("email")]
		public new string Email
		{
			get => base.Email;
			set => base.Email = value;
		}

		[JsonPropertyName("password")]
		public string Password { get; set; }
	}
}
