using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public class DayGenerator : IDayGenerator
    {
        private readonly DateTime _today;

        public DayGenerator()
        {
            _today = new DateTime();
        }

        public DateTime Generate()
        {
            return DateTime.Now.Date;
        }
    }
}
