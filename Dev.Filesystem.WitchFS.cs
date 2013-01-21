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
        private bool error = false;
        public void Init(string OSname)
        {
            try
            {
                //Look through all of the devices and see if you can find a hard drive
                for (int i = 0; i < BlockDevice.Devices.Count; i++)
                {
                    if (BlockDevice.Devices[i] is AtaPio)
                    {
                        //Set our device to the hard drive
                        ATA = (AtaPio)BlockDevice.Devices[i];
                    }
                }
                //Look through all of the devices and look for a partition
                for (int j = 0; j < BlockDevice.Devices.Count; j++)
                {
                    if (BlockDevice.Devices[j] is Partition)
                    {
                        OSPartition = (Partition)BlockDevice.Devices[j];
                    }
                }
                //Make a filesystem attached to the partition
                FATFS = new Cosmos.System.Filesystem.FAT.FatFileSystem(OSPartition);
                //Map the filesystem to the X drive
                Cosmos.System.Filesystem.FileSystem.AddMapping("X", FATFS);
                FATFileList = FATFS.GetRoot();
            }
            catch
            {
                error = true;
                Bluescreen.Show(false, "No partition found", "WitchFS cannot find an existing partition on your computer.");
            }
        }
	}
}
