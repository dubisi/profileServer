using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	public class Skills
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? SkillSet { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }
	}
}
