using Microsoft.AspNetCore.Identity;

namespace SkyWatch_API.Models
{

    public class User : IdentityUser
    {
        //public List<Alarm> Alarms { get; set; } = new List<Alarm>();
        public ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();
    }
}
