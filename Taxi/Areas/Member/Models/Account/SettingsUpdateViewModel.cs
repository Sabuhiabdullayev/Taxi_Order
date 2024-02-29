namespace Taxi.Areas.Member.Models.Account
{
	public class SettingsUpdateViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public IFormFile img { get; set; }
		public string Phone { get; set; }
		public string Date { get; set; }
	}
}
