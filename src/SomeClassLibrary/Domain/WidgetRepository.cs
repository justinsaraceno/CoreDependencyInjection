using System.Collections.Generic;

namespace SomeClassLibrary.Domain
{
    public class WidgetRepository : IWidgetRepository
    {
        public IEnumerable<Widget> GetAll()
        {
            // send back some hard-coded data
            return new List<Widget>
            {
                new Widget { Id = 1, Name = "First Widget" },
                new Widget { Id = 2, Name = "Second Widget" }
            };
        }
    }
}
