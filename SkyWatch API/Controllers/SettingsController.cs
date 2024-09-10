using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyWatch_API.DTOs;
using SkyWatch_API.Models;
using SkyWatch_API.Models.AlarmModels;

namespace SkyWatch_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingsController : ControllerBase
    {
        // Ovo bi obično bilo povezano sa bazom podataka.
        private static UserSettings _userSettings = new UserSettings();
        private readonly UserManager<User> userManager;
        private readonly SkyContext context;

        public SettingsController(UserManager<User> userManager, SkyContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        [HttpPost("{userId}/alarms")]
        public async Task<IActionResult> AddAlarm(string userId, [FromBody] Alarm alarm)
        {
            var user = await userManager.FindByIdAsync(userId); 
            if (user == null)
            {
                return NotFound("User not found");
            }

            // Provera da li već postoji alarm za ovaj tip, ako je potrebno
            /*var existingAlarm = user.Alarms.FirstOrDefault(a => a.Type == alarm.Type);
            if (existingAlarm != null)
            {
                // Ažuriraj postojeći alarm ili vrati grešku
                return BadRequest("Alarm for this type already exists.");
            }

            user.Alarms.Add(alarm);
            return Ok(alarm);*/

            alarm.UserId = userId; // Postavite UserId za alarm
            context.Alarms.Add(alarm);
            await context.SaveChangesAsync();

            return Ok(alarm);
        }


        [HttpGet("{userId}/alarms")]
        public async Task<IActionResult> GetAlarms(string userId)
        {
            var alarms = await context.Alarms
                .Include(u => u.Conditions)
                .Where(a => a.UserId == userId)
                .ToListAsync();

            if (!alarms.Any())
            {
                return NotFound("No alarms found for this user.");
            }

            return Ok(alarms);
        }

        // Brisanje alarma
        [HttpDelete("{userId}/alarms/{alarmId}")]
        public async Task<IActionResult> DeleteAlarm(string userId, int alarmId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var alarm = context.Alarms.Where(a => a.UserId == userId).FirstOrDefault(a => a.Id == alarmId);
            if (alarm == null)
            {
                return NotFound("Alarm not found");
            }

            user.Alarms.Remove(alarm);
            await context.SaveChangesAsync();
            return Ok(new { message = "Alarm deleted successfully" });
        }
    }
 }
