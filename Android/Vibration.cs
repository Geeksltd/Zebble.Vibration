namespace Zebble.Device
{
    using Android.Content;
    using Android.OS;
    using System.Threading.Tasks;

    partial class Vibration
    {
        static Vibrator CreateVibrator() => UIRuntime.GetService<Vibrator>(Context.VibratorService);

        public static bool IsAvailable()
        {
            using var vibrator = CreateVibrator();
            return vibrator?.HasVibrator == true;
        }

        static Task DoRun(int milliseconds)
        {
            using var vibrator = CreateVibrator();
            vibrator.Vibrate(VibrationEffect.CreateOneShot(milliseconds, VibrationEffect.DefaultAmplitude));

            return Task.CompletedTask;
        }
    }
}