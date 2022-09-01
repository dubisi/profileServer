using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	public class Personal
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? LastName { get; set; }

		public string? Email { get; set; }

	}
}
