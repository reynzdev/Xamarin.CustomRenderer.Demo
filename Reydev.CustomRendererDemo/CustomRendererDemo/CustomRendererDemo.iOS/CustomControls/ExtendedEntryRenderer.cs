using CoreAnimation;
using CustomRendererDemo.CustomControls;
using CustomRendererDemo.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace CustomRendererDemo.iOS.CustomControls
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var xfControl = Element as ExtendedEntry;
            xfControl.SizeChanged += (ctrl, ea) =>
            {
                float width = 1.0f;

                CALayer border = new CALayer();
                border.BorderColor = xfControl.BottomlineColor.ToUIColor().CGColor;
                border.Frame = new CoreGraphics.CGRect(x: 0, y: ((float)xfControl.Height - width), width: (float)xfControl.Width, height: xfControl.BottomlineWidth);
                border.BorderWidth = width;

                Control.Layer.AddSublayer(border);
                Control.Layer.MasksToBounds = true;
                Control.BorderStyle = UITextBorderStyle.None;
                Control.BackgroundColor = xfControl.BackgroundColor.ToUIColor();
            };
        }
    }
}