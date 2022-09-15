using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int StorageUsed { get; set; }
        public int StorageRemaining { get; set; }
        public string Contents { get; set; }
        public string DiscType { get; set; }

        public BaseDisc(string name, int storageCapacity, string discType)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            //Contents = contents;
            DiscType = discType;
        }
    }
}
