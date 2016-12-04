using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace TC.Droid.Views
{
    [Activity(Label = "CategoryView")]
    public class CategoryView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CategoryView);
        }
    }
}