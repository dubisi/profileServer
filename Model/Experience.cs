<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	public class Experience
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
=======
﻿namespace Profile.Model
{
	public class Experience
	{
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? Title { get; set; }

		public string? Description { get; set; }
		public string? StartYear { get; set; }

		public string? EndYear { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }
	}
}
