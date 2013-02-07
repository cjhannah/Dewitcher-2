using System;
using System.Collections.Generic;
using Cosmos.Hardware.BlockDevice;

namespace dewitcher.Dev.Filesystem
{
	public class WitchFS
	{
        private AtaPio ATA = null;
        private Partition OSPartition = null;
        private Cosmos.System.Filesystem.FileSystem FS = null;
        private string osname;
        /// <summary>
        /// Initialize the Filesystem
        /// </summary>
        /// <param name="OSname"></param>
        public void Init(string OSname)
        {
            osname = OSname;
            if (FindHardDrive())
            {
                if (FindPartition())
                {
                    FS = new Cosmos.System.Filesystem.FileSystem();
                    if (!MapFS()) Core.Bluescreen.Init("WitchFS MappingException", "Mapping the filesystem to X drive failed!", false);
                }
                else
                {
                    Core.Bluescreen.Init("WitchFS PartitionException", "WitchFS cannot find a partition on your computer.", false);
                }
            }
            else
            {
                Core.Bluescreen.Init("WitchFS ATAException", "WitchFS cannot find a harddrive on your computer.", false);
            }
        }
        private bool FindHardDrive()
        {
            int harddrives = 0;
            for (int i = 0; i < BlockDevice.Devices.Count; i++)
            {
                if (BlockDevice.Devices[i] is AtaPio)
                {
                    ATA = (AtaPio)BlockDevice.Devices[i];
                    ++harddrives;
                    break;
                }
            }
            if (harddrives > 0) return true;
            else return false;
        }
        private bool FindPartition()
        {
            int partitions = 0;
            for (int j = 0; j < BlockDevice.Devices.Count; j++)
            {
                if (BlockDevice.Devices[j] is Partition)
                {
                    OSPartition = (Partition)BlockDevice.Devices[j];
                    ++partitions;
                    break;
                }
            }
            if (partitions > 0) return true;
            else return false;
        }
        private bool MapFS()
        {
            try
            {
                Cosmos.System.Filesystem.FileSystem.AddMapping("\\" + osname + "\\", FS);
                return true;
            }
            catch { return false; }
        }
	}
}
