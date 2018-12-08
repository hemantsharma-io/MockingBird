using System;
using System.Collections.Generic;

namespace MockingBird.Domain
{
    /// <summary>
    /// Context class of selected fiddler sessions and source template text
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Creates context
        /// </summary>
        /// <param name="fiddlerSessions">Fiddler sessions</param>
        public Context(Fiddler.Session[] fiddlerSessions, string templateText)
        {
            if(fiddlerSessions == null || fiddlerSessions.Length == 0)
            {
                throw new ArgumentNullException("fiddlerSessions is null or empty");
            }
            TempateText = templateText;
            SelectedSessions = new List<Session>();
            foreach (var fiddlerSession in fiddlerSessions)
            {
                var session = new Session(fiddlerSession);
                SelectedSessions.Add(session);
            }
        }
        /// <summary>
        /// Gets or sets selected sessions
        /// </summary>
        public List<Session> SelectedSessions { get; set; }
        /// <summary>
        /// Gets or sets template text
        /// </summary>
        public string TempateText { get; set; }    
    }
}
