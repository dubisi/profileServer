<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	public class About
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
=======
﻿namespace Profile.Model
{
	public class About
	{
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
		public int Id { get; set; }
		public string? AboutMe { get; set; }

		public string? ImagePath { get; set; }
		public string? Resume { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }
	}
}
