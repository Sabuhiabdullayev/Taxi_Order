using Microsoft.AspNetCore.Identity;

namespace Taxi.Dal.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string img { get; set; }
        public string Date { get; set; }
        public string DateOfPosting { get; set; }
        public string Transportationtype { get; set; }
    }
}
