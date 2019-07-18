using Xamarin.Forms;

namespace CustomRendererDemo.CustomControls
{
    public class ExtendedEntry : Entry
    {
        public int BottomlineWidth { get; set; } = 1;
        public Color BottomlineColor { get; set; } = Color.Transparent;
    }
}
