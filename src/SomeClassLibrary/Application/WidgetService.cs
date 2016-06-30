using System.Collections.Generic;
using System.Linq;
using SomeClassLibrary.Domain;

namespace SomeClassLibrary.Application
{
    public class WidgetService : IWidgetService
    {
        private readonly IWidgetRepository widgetRepository;

        public WidgetService(IWidgetRepository widgetRepository)
        {
            this.widgetRepository = widgetRepository;
        }

        public List<Widget> GetAllWidgets()
        {
            return this.widgetRepository.GetAll().ToList();
        }
    }
}
