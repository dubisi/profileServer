namespace Profile.Model
{
	public class About
	{
		public int Id { get; set; }
		public string? AboutMe { get; set; }

		public string? ImagePath { get; set; }
		public string? Resume { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }
	}
}
