using System;
using System.ComponentModel.DataAnnotations;

namespace Gym_Entity.Concrete
{
	public class Message
	{
		[Key]
		public int ID { get; set; }

		public int SenderID { get; set; }

		public int ReceiverID { get; set; }

		public string Content { get; set; }

		public DateTime SendingDate { get; set; }
	}
}

