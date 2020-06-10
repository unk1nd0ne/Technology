using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractIdentity
    {
        public string Processor { get; }
        public int Memory { get; }
        public double Storage { get; }
        public string OperatingSystem { get; }

        public Computer (string processor, int memory, double storage, string operatingSystem) : base()
        {
            Processor = processor;
            Memory = memory;
            Storage = storage;
            OperatingSystem = operatingSystem;
        }

        public string Boot()
        {
            return $"Welcome to {OperatingSystem}!";
        }

        public virtual string StorePicture (string pictureName, double pictureSize)
        {
            if (pictureSize > Storage)
            {
                return $"Picture, {pictureName} too large to store";
            }
            else
            {
                return $"Picture, {pictureName} saved";
            }
        }


    }
}
