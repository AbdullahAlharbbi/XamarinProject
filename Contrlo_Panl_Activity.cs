using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XA_TwoTable
{
    [Activity(Label = "Contrlo_Panl_Activity")]
    public class Contrlo_Panl_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_control_panl);



            var AddTeachers = FindViewById<Button>(Resource.Id.AddTeachers);
            var Back = FindViewById<Button>(Resource.Id.Back);












        }
    }
}