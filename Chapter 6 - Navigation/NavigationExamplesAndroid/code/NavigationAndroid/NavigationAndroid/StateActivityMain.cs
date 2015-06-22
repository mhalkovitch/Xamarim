using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NavigationAndroid
{
    //[Activity(Label = "StateActivityMain", MainLauncher = true)]
    public class StateActivityMain : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            DataModel data = new DataModel();
            data.Id = 1;
            data.Info = "First";

            //Use JSON.NET Xamarin component to pass instance of DataModel 
            String json = Newtonsoft.Json.JsonConvert.SerializeObject (data);
            var intent = new Intent(this, typeof(PassToActivity));
            intent.PutExtra("MyData", json);

            StartActivity(intent); 

        }
    }
}