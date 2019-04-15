using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    interface IDatabase
    {
        List<Days> AddEvent(int monthId, int dayId, string title, string description, string startTime);
        List<Days> LoadEvent(int monthId);
    }
}
