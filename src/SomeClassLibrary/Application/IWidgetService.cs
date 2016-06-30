using System.Collections.Generic;
using SomeClassLibrary.Domain;

namespace SomeClassLibrary.Application
{
    public interface IWidgetService
    {
        List<Widget> GetAllWidgets();
    }
}