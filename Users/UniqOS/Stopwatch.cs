using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.Users.UniqOS
{
    
    class Stopwatch
    {
        int startTime = 0;
        int timeTaken = 0;
        int stopTime = 0;
        bool isRun = false;
      
        public Stopwatch()
        {
            this.reset();
        }
        public void reset()
        {
            isRun = false;
          startTime = 0;
          timeTaken = 0;
          stopTime = 0;
        }
        public void Start()
        {
            if (this.isRunning())
            {
                //I have no idea why I didn't just do if(!this.isRunning())....

                //Kenneth.Burn();
            }
            else
            {
                startTime = RTC.Now.Second;
                isRun = true;
            }

        }
        public void Stop()
        {
            if (this.isRunning())
            {
                stopTime = RTC.Now.Second;
                timeTaken = stopTime - startTime;
                isRun = false;
            }
        }
        public bool isRunning()
        {
            return isRun;
        }
        public long ElapsedSeconds()
        {
            return timeTaken;
        }
        public long ElapsedMilliseconds()
        {
            return timeTaken / 1000;
        }
    }
}
