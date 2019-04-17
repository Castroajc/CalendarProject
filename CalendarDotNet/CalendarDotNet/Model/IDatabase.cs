using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    interface IDatabase
    {
        //code does not accept the modifier public, so i do not use it
        void UpdateEvent(int dayId, int monthId, string title, string description, string startTime);
        List<Days> LoadEvent(int monthId);
    }
}
