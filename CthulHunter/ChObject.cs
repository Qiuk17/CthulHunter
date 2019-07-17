using System;
using System.Timers;
namespace CthulHunter
{
    internal static class IdGenerator
    {
        static private int id = 0;
        public static int GetNextId() => id++;
    }
    abstract public class ChObject
    {
        public int Id { get; }
        public ChObject()
        {
            Id = IdGenerator.GetNextId();
        }
    }
}
