using System.Collections.Generic;

namespace SomeClassLibrary.Domain
{
    public interface IWidgetRepository
    {
        IEnumerable<Widget> GetAll();
    }
}