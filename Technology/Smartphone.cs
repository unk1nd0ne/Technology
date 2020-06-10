using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Smartphone : Computer
    {
        public double FreeSpace { get; set; }

        public Smartphone(string processor, int memory, double storage, string operatingSystem) : base(processor, memory, storage, operatingSystem)
        {
            FreeSpace = storage;
        }

        public override string StorePicture(string pictureName, double pictureSize)
        {
            if (pictureSize > FreeSpace)
            {
                return $"{pictureName}: not enough space for your duck face";
            }
            else
            {
                FreeSpace -= pictureSize;
                return $"{pictureName}: looking good, have you been working out?";
            }
        }
    }
}
