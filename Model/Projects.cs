namespace Profile.Model
{
	public class Projects
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Dev { get; set; }
		public string? Languages { get; set; }
		public string? Description { get; set; }

		public string? Link { get; set; }

		public string? ExternalLink { get; set; }

		public int PersonalId { get; set; }
		public Personal? Personal { get; set; }

	}
}
