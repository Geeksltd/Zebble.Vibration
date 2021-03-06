﻿namespace Zebble.Device
{
    using System.Threading.Tasks;
    using Windows.Phone.Devices.Notification;
    using Olive;

    public partial class Vibration
    {
        public static bool IsAvailable()
        {
            try { return VibrationDevice.GetDefault() != null; }
            catch { return false; /* No logging is needed */}
        }

        static Task DoRun(int milliseconds)
        {
            VibrationDevice.GetDefault()?.Vibrate(milliseconds.Milliseconds());
            return Task.CompletedTask;
        }
    }
}