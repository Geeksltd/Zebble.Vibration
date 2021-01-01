namespace Zebble.Device
{
    using System.Threading.Tasks;
    using AudioToolbox;
    using Olive;

    partial class Vibration
    {
        const int VIBRATE_SOUND_CODE = 1352;

        public static bool IsAvailable() => OS.HardwareModel.Contains("iPhone", caseSensitive: false);

        static Task DoRun(int milliseconds) => new SystemSound(VIBRATE_SOUND_CODE).PlaySystemSoundAsync();
    }
}