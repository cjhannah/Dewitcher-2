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
        /* 
         * Use in installations or file copying...
         * e.g
         * CalulcateRemaingTime(50, 100)
         * 50 tasks completed out of 100!
         * */
        /// <summary>
        /// CalculateRemainingtime
        /// </summary>
        /// <param name="completedCount">Amount of tasks completed</param>
        /// <param name="totalCount">How many tasks that need to be completed</param>
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
        /// <summary>
        /// ByteParse
        /// </summary>
        /// <param name="toparse">String you wish to parse to a byte.</param>
        public byte ByteParse(string toparse)
        {
            return (byte)Int32.Parse(toparse);
        }
        /// <summary>
        /// Quick file saving
        /// </summary>
        /// <param name="location">Location of file. Must include file name.</param>
        /// <param name="contents">Contents of file</param>
        /// <param name="filesystem">Predefined filesystem</param>
        /// <param name="owner">Owner of file?</param>
        public void saveFile(string location, string contents, IO.FileSystem.VirtualFileSystem filesystem, string owner = "root")
        {
            byte[] dat = new byte[contents.Length];
            for (int i = 0; i < contents.Length; i++)
            {
                dat[i] = (byte)contents[i];
            }
            filesystem.saveFile(dat, location, owner);
        }
        /// <summary>
        /// Quick file opening
        /// </summary>
        /// <param name="location">Location of file. Must include file name.</param>
        /// <param name="filesystem">Predefined filesystem</param>
        public string openFile(string location, IO.FileSystem.VirtualFileSystem filesystem)
        {
            byte[] file = null;
            file = filesystem.readFile(location);
            string accum = "";
            for (int i = 0; i < file.Length; i++)
            {
                accum += ((char)file[i]).ToString();
            }
            return accum;
        }

        // Coming later!
        public void saveImage(string image)
        {
            
        }
        public void loadImage(string image)
        {

        }
    }
}
