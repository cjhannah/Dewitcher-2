using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.Users.UniqOS
{
    class UniqExtras
    {
        
        //Calulcate how much remaining time there is until the process is completed.
        public static Stopwatch xBTimer;

        //Simple to user
        /* 
         * Use in installations or file copying...
         * e.g
         * CalulcateRemaingTime(50, 100)
         * 50 tasks completed out of 100!
         * */
        public TimeSpan CalculateRemainingTime(int completedCount, int totalCount)
        {
            if (xBTimer == null)
            {
                xBTimer = new Stopwatch();
                xBTimer.Start();
            }

            long percentComplete = (completedCount * 100 / totalCount);
            if (percentComplete == 0)
            { //DIVIDING BY 0 WILL MEAN DEATH. Should call the burn() method..... xD
                percentComplete = 1;
            }
            long remaining = (xBTimer.ElapsedMilliseconds() / percentComplete)
                * (100 - percentComplete);

            return new TimeSpan(remaining * 10000);
        }
    }
}
