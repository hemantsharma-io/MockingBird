using System;

namespace MockingBird.Domain
{
    /// <summary>
    /// This wrapper class enables extension to what Fiddler's session provides
    /// you can add more functions to the it and can use as property names in Mustache template
    /// </summary>
    public class Session: Fiddler.Session
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="session"></param>
        public Session(Fiddler.Session session): base(session) { }

        /// <summary>
        /// Generates base64 from current session's request body
        /// </summary>
        /// <returns></returns>
        public string RequestBodyAsBase64()
        {
            if (requestBodyBytes != null)
            {
                return Convert.ToBase64String(requestBodyBytes);
            }
            return null;
        }
    }
}
