namespace Zebble.Device
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using AudioToolbox;

    partial class Vibration
    {
        const int VIBRATE_SOUND_CODE = 1352;

        public static bool IsAvailable() => Device.OS.HardwareModel.Contains("iPhone", caseSensitive: false);

        static Task DoRun(int milliseconds) => new SystemSound(VIBRATE_SOUND_CODE).PlaySystemSoundAsync();
    }
}