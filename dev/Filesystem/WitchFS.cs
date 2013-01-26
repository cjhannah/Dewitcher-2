using System;
using System.Collections.Generic;
using Cosmos.Hardware.BlockDevice;

namespace dewitcher.Dev.Filesystem
{
	public class WitchFS
	{
        private AtaPio ATA = null;
        private Partition OSPartition = null;
        private Cosmos.System.Filesystem.FAT.FatFileSystem FATFS = null;
        private List<Cosmos.System.Filesystem.Listing.Base> FATFileList;
        /// <summary>
        /// Initialize the Filesystem
        /// </summary>
        /// <param name="OSname"></param>
        public void Init(string OSname)
        {
            if (FindHardDrive())
            {
                if (FindPartition())
                {
                    FATFS = new Cosmos.System.Filesystem.FAT.FatFileSystem(OSPartition);
                    if (!MapFS()) Bluescreen.Init("WitchFS MappingException", "Mapping the filesystem to X drive failed!", false);
                }
                else
                {
                    Bluescreen.Init("WitchFS PartitionException", "WitchFS cannot find a partition on your computer.", false);
                }
            }
            else
            {
                Bluescreen.Init("WitchFS ATAException", "WitchFS cannot find a harddrive on your computer.", false);
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
                Cosmos.System.Filesystem.FileSystem.AddMapping("X", FATFS);
                FATFileList = FATFS.GetRoot();
                return true;
            }
            catch { return false; }
        }
	}
}
