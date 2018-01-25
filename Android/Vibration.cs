namespace Zebble.Device
{
    using System.Threading.Tasks;
    using Android.Content;
    using Android.OS;

    partial class Vibration
    {
        const int DURATION = 400;

        static Vibrator CreateVibrator() => UIRuntime.GetService<Vibrator>(Context.VibratorService);

        public static bool IsAvailable()
        {
            using (var vibrator = CreateVibrator()) return vibrator?.HasVibrator == true;
        }

        static Task DoRun()
        {
            using (var vibrator = CreateVibrator())
                vibrator.Vibrate(DURATION);

            return Task.CompletedTask;
        }
    }
}