using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalWebsite.Models;

namespace PersonalWebsite.Services
{
    public class DbPersonalWebsite : IPWRepository
    {
        private ApplicationDbContext _db;

        public DbPersonalWebsite(ApplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<Event> ReadAllEvents()
        {
            return _db.Events.ToList();
        }

        public ICollection<Project> ReadAllProjects()
        {
            return _db.Projects.ToList();
        }

        public Event ReadEvent(int id)
        {
            return _db.Events.FirstOrDefault(e => e.Id == id);
        }

        public Project ReadProject(int id)
        {
            return _db.Projects.FirstOrDefault(p => p.Id == id);
        }

        public void LogEvent(string action, string ip = "none")
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

            var log = new Log()
            {
                Action = action,
                IPAddress = ip,
                TimeStamp = easternTime
            };

            _db.Logs.Add(log);
            _db.SaveChanges();
        }
    }
}
