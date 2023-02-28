using System;

namespace LittleBitGames.Environment.Events
{
    [Flags]
    public enum EventsServiceType
    {
        Firebase = 1 << 0,
        GA = 1 << 1,
        Adjust = 1 << 2,
        Amplitude,
        Wazzitude,
        Everything = Int32.MaxValue,
        
    }
}