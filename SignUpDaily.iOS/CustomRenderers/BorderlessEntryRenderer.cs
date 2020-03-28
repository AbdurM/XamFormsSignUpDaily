using System;
using CoreAnimation;
using CoreGraphics;
using CustomRenderer.iOS;
using SignUpDaily.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace CustomRenderer.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
