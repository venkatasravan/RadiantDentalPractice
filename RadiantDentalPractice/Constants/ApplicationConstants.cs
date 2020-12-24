using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Constants
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public sealed class ApplicationConstants
    {
        public const int DAILY_CHECKUP_SLOTS = 20;
        public const int DAILY_EMERGENCY_SLOTS = 2;
        public const int DAILY_SURGERY_SLOTS = 6;
        // Duration is in Minutes
        public const int CHECKUP_DURATION = 15;
        public const int EMERGENCY_DURATION = 120;
        public const int SURGERY_DURATION = 60;
        public const double FREE = 0;
        public const double EMERGENCY = 22.70;
        public const double BAND1 = 22.70;
        public const double BAND2 = 62.10;
        public const double BAND3 = 269.30;
        public const double OTHER = 1500;
        public const int BREAK_HOUR = 12;

    }
}
