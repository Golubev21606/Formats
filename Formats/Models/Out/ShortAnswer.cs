using System.Collections.Generic;

namespace Formats.Models
{
    public class ShortAnswer
    {
        public string Status { get; }
        public List<string> Errors { get; } = new List<string>();

        public ShortAnswer(Status status, IEnumerable<string> errors = null)
        {
            Status = status.ToString();

            if (errors != null)
            {
                Errors.AddRange(errors);
            }
        }
    }
}
