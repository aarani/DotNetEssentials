﻿namespace Xamarin.Essentials
{
    public static partial class Gyroscope
    {
        internal static bool IsSupported =>
            throw new System.PlatformNotSupportedException();

        internal static void PlatformStart(SensorSpeed sensorSpeed) =>
            throw new System.PlatformNotSupportedException();

        internal static void PlatformStop() =>
            throw new System.PlatformNotSupportedException();
    }
}
