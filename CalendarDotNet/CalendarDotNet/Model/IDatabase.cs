using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    interface IDatabase
    {
        void UpdateEvent(int dayId, int monthId, string title, string description, string startTime);
        List<Days> LoadEvent(int monthId);
    }
}
