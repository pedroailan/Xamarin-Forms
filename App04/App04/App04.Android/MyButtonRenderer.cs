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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(App04.Customs.Mybutton), typeof(App04.Droid.MyButtonRenderer))]
namespace App04.Droid
{
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.round_button);
                //Control.SetBackgroundColor(Android.Graphics.Color.Red);
            }
        }
    }
}