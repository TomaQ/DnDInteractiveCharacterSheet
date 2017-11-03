using Android.Content;
using Android;
using Android.Content.PM;
using Android.Support.V4.App;
using Android.App;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DnDCharSheet.Classes
{
    public class Utility
    {
        public static string STORAGE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public static void Log(Exception ex)
        {
            string errorMessage = "Error: " + ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : "");
            System.Diagnostics.Debug.WriteLine(errorMessage);
        }

        public static void CheckPermissions(Activity activity)
        {
            List<string> RequiredPermissions = new List<string>
            {
              Manifest.Permission.ReadExternalStorage,
              Manifest.Permission.WriteExternalStorage
            };
            
            //request permissions that are not granted
            if(RequiredPermissions.Any(x => activity.BaseContext.CheckSelfPermission(x) != Permission.Granted))
            {
                ActivityCompat.RequestPermissions(activity, RequiredPermissions.ToArray(), 0);
            }            
        }
    }
}