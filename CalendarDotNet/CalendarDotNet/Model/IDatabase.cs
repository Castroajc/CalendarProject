using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarDotNet.Model
{
    interface IDatabase
    {
        List<Days> AddEvent(Days day);
        List<Days> LoadEvent();
    }
}
