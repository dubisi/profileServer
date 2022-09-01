using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
using System.Text.Json.Serialization;

namespace Profile.Model
{
<<<<<<< HEAD
	public class Personal
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Name { get; set; }

		public string? LastName { get; set; }

		public string? Email { get; set; }

	}
=======
    public class Personal
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

    }
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
}
