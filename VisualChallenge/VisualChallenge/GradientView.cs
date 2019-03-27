using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace VisualChallenge
{
    public class GradientView : ContentView
    {
        public string StartColor { get; set; } = "#ffffff";
        public string EndColor { get; set; } = "#000000";
        public bool Horizontal { get; set; } = false;


        public GradientView()
        {
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKColor.TryParse(StartColor, out var stColor);
            SKColor.TryParse(EndColor, out var edColor);

            var colors = new SKColor[] { stColor, edColor };
            SKPoint startPoint = new SKPoint(0, 0);
            SKPoint endPoint = Horizontal ? new SKPoint(info.Width, 0) : new SKPoint(0, info.Height);

            var shader = SKShader.CreateLinearGradient(startPoint, endPoint, colors, null, SKShaderTileMode.Clamp);

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Shader = shader
            };

            canvas.DrawRect(new SKRect(0, 0, info.Width, info.Height), paint);
        }
    }
}