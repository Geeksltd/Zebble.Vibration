namespace Zebble.Device
{
    using System;
    using System.Threading.Tasks;

    public static partial class Vibration
    {
        const int DEFAULT_DURATION = 400;
        public static Task Run(OnError errorAction = OnError.Toast) => Run(DEFAULT_DURATION.Milliseconds(), errorAction);

        public static async Task Run(TimeSpan duration, OnError errorAction = OnError.Toast)
        {
            try
            {
                if (!await Device.Permission.Vibration.IsRequestGranted())
                    throw new Exception("Permission to vibrate was denied.");

                if (!IsAvailable()) throw new Exception("Vibration is not available on this device.");

                await DoRun((int)duration.TotalMilliseconds);
            }
            catch (Exception ex)
            {
                await errorAction.Apply(ex, "Vibration request failed.");
            }
        }
    }
}