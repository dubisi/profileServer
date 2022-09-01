<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	public class Skills
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
=======
﻿namespace Profile.Model
{
	public class Skills
	{
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? SkillSet { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }
	}
}
