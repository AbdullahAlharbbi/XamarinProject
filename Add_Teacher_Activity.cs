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
    [Activity(Label = "Add_Teacher_Activity")]
    public class Add_Teacher_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.activity_add_teacher);



            var AddTeacher = FindViewById<Button>(Resource.Id.AddTeacher);
            var Back = FindViewById<Button>(Resource.Id.Back);


            

            Back.Click += delegate
            {
                Intent i = new Intent(this, typeof(Contrlo_Panl_Activity));
                StartActivity(i);
            };




        }
    }
}