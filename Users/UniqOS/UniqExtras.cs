/*
Copyright (c) 2012-2013, dewitcher Team
All rights reserved.

Redistribution and use in source and binary forms, with or without modification,
are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice
   this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER
IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF
THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

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
