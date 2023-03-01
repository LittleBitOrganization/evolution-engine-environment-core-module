using System;

namespace LittleBitGames.Environment.Events
{
    [Flags]
    public enum EventsServiceType
    {
        Firebase = 1 << 0,
        GA = 1 << 1,
        Adjust = 1 << 2,
        Amplitude = 1 << 3,
        Wazzitude = 1 << 4,
        Everything = Int32.MaxValue,
        
    }
}