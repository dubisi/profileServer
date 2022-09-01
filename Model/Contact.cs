<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.Model
{
	/// <summary>
	/// Model class to create entity for storing contacts
	/// </summary>
	public class Contact
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? Link { get; set; }

		public int PersonalID { get; set; }
		public Personal? Personal { get; set; }
	}
=======
﻿namespace Profile.Model
{
    /// <summary>
    /// Model class to create entity for storing contacts
    /// </summary>
    public class Contact
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Link { get; set; }

        public int PersonalID { get; set; }
        public Personal? Personal { get; set; }
    }
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
}
