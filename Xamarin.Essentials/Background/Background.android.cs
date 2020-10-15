using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;

namespace Xamarin.Essentials.Background
{
    public static partial class Background
    {
        static ContextWrapper context;

        public static void Initialize(ContextWrapper context)
        {
            Background.context = context;
        }

        public static void StartBackgroundService()
        {
            var intent = new Intent(context, typeof(BackgroundService));
            context.StartService(intent);
        }
    }
}
