namespace JuniorCodeTest.Models
{
	public class RequestedUsersModel
	{
		public string? Title { get; set; }
		public string? First { get; set; }
		public string? Last { get; set; }
		public int Age { get; set; }
		public string? Country { get; set; }

		public required string? Latitude { get; set; }

		public required string? Longitude { get; set; }
	}
}
