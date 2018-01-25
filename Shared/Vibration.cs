namespace Zebble.Device
{
    using System;
    using System.Threading.Tasks;

    public static partial class Vibration
    {
        public static async Task Run(OnError errorAction = OnError.Toast)
        {
            try
            {
                if (!await Device.Permission.Vibration.IsRequestGranted())
                    throw new Exception("Permission to vibrate was denied.");

                if (!IsAvailable()) throw new Exception("Vibration is not available on this device.");

                await DoRun();
            }
            catch (Exception ex)
            {
                await errorAction.Apply(ex, "Vibration request failed.");
            }
        }
    }
}