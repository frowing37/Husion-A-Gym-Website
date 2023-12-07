using System;
namespace Gym.Models.Dtos
{
	public class ConfirmMailDto
	{
		public string Mail { get; set; }

		public string Code { get; set; }

		public string NewPassword { get; set; }
	}
}

