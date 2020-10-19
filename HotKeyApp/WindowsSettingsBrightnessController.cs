using System;
using System.Management;


namespace HotKeyApp
{
    public static class WindowsSettingsBrightnessController
    {

        public static byte GetBrightness()
        {
            byte brightness = 0;
            using (var mclass = new ManagementClass("WmiMonitorBrightness"))
            {
                mclass.Scope = new ManagementScope(@"\\.\root\wmi");
                using (var instances = mclass.GetInstances())
                {
                    foreach (ManagementObject instance in instances)
                    {
                        brightness = (byte)instance.GetPropertyValue("CurrentBrightness");
                    }
                }
            }
            return brightness;
        }

        public static byte SetBrightness(int value = -1, bool increase = false)
        {
            byte brightness = 0;
            using (var mclass = new ManagementClass("WmiMonitorBrightness"))
            {
                mclass.Scope = new ManagementScope(@"\\.\root\wmi");
                using (var instances = mclass.GetInstances())
                {
                    foreach (ManagementObject instance in instances)
                    {
                        brightness = (byte)instance.GetPropertyValue("CurrentBrightness");
                    }
                }
            }
            if (value >= 0 && value <= 100)
            {
                brightness = Convert.ToByte(value);
            }
            else
            {
                if (increase)
                {
                    if (brightness < 100) brightness += 1;
                }
                else
                {
                    if (brightness > 0) brightness -= 1;
                }

            }
            using (var mclass1 = new ManagementClass("WmiMonitorBrightnessMethods"))
            {
                mclass1.Scope = new ManagementScope(@"\\.\root\wmi");
                using (var instances = mclass1.GetInstances())
                {
                    var args = new object[] { 1, brightness };
                    foreach (ManagementObject instance in instances)
                    {
                        instance.InvokeMethod("WmiSetBrightness", args);
                    }
                }
            }
            return brightness;
        }

    }
}
