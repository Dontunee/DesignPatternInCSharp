using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.CreationalDesignPatterns
{
   public interface IDoor
    {
        int GetHeight();
        int GetWidth();
        void GetDescription();
    }

    public class WoodenDoor : IDoor
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public WoodenDoor(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }

    public class IronDoor : IDoor
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public IronDoor(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public void GetDescription()
        {
            Console.WriteLine("I am an iron door");
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }
    }

    public static class DoorFactory
    {
        public static IDoor MakeDoor(int height, int width)
        {
            return new WoodenDoor(height, width);
        }
    }

    

}
