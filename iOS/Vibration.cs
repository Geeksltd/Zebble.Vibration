namespace Zebble.Device
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using AudioToolbox;

    partial class Vibration
    {
        const int VIBRATE_SOUND_CODE = 1352, DEFAULT_DURATION = 400;

        public static bool IsAvailable() => Device.OS.HardwareModel.Contains("iPhone", caseSensitive: false);

        static Task DoRun() => new SystemSound(VIBRATE_SOUND_CODE).PlaySystemSoundAsync();
    }
}