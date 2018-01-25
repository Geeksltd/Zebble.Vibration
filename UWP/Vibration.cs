namespace Zebble.Device
{
    using System;
    using System.Threading.Tasks;
    using Windows.Phone.Devices.Notification;

    public partial class Vibration
    {
        const int DURATION = 400;

        public static bool IsAvailable()
        {
            try { return VibrationDevice.GetDefault() != null; }
            catch { return false; /* No logging is needed */}
        }

        static Task DoRun()
        {
            VibrationDevice.GetDefault()?.Vibrate(DURATION.Milliseconds());
            return Task.CompletedTask;
        }
    }
}