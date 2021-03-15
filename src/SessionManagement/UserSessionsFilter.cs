using System;

namespace Duende.Bff
{
    /// <summary>
    /// Filter to query user sessions
    /// </summary>
    public class UserSessionsFilter
    {
        /// <summary>
        /// The subject ID
        /// </summary>
        public string SubjectId { get; set; }

        /// <summary>
        /// The sesion ID
        /// </summary>
        public string SessionId { get; set; }

        internal void Validate()
        {
            if (String.IsNullOrWhiteSpace(SubjectId) && String.IsNullOrWhiteSpace(SessionId))
            {
                throw new ArgumentNullException("SubjectId or SessionId is required.");
            }
        }
    }
}