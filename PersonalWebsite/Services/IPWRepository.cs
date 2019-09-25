using PersonalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public interface IPWRepository
    {
        #region Events

        Event ReadEvent(int id);
        ICollection<Event> ReadAllEvents();

        #endregion

        #region Projects
        Project ReadProject(int id);
        ICollection<Project> ReadAllProjects();

        #endregion

        #region Log
        void LogEvent(string action, string ip = "none");

        #endregion
    }
}
