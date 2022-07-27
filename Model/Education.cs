namespace Profile.Model
{
	public class Education
	{
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
