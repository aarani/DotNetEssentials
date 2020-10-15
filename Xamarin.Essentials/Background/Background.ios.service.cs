using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Xamarin.Essentials.Background
{
    public class BackgroundService
    {
        static readonly object isRunning = new object();
        static nint taskId;

        /// <summary>
        /// Start the execution of background service
        /// </summary>
        public static void Start()
        {
            lock (isRunning)
            {
                taskId = UIApplication.SharedApplication.BeginBackgroundTask("BackgroundTask", Stop);
                Background.StartJobs();
                UIApplication.SharedApplication.EndBackgroundTask(taskId);
            }
        }

        public static void Stop()
        {
            UIApplication.SharedApplication.EndBackgroundTask(taskId);
        }
    }
}
