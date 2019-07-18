using Android.Content;
using Android.Graphics.Drawables;
using CustomRendererDemo.CustomControls;
using CustomRendererDemo.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace CustomRendererDemo.Droid.CustomRenderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public ExtendedEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var xfControl = Element as ExtendedEntry;
            if (xfControl == null) return;

            if(Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.entrynobottomline);

                var itemList = (LayerDrawable)Control.Background;
                var bgShape = (GradientDrawable)itemList.FindDrawableByLayerId(Resource.Id.shape_id);
                bgShape.SetStroke(xfControl.BottomlineWidth, xfControl.BottomlineColor.ToAndroid());
            }
        }
    }
}