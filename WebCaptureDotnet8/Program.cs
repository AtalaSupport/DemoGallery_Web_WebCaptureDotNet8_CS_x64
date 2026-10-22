using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;
using Atalasoft.Imaging.WebControls.Core;

RegisteredDecoders.Decoders.Add(new PdfDecoder() { Resolution = 200, RenderSettings = new RenderSettings() { AnnotationSettings = AnnotationRenderSettings.RenderNone } });

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseDefaultFiles();
app.UseStaticFiles();

//app.Map("/wdv", wdvApp => { wdvApp.RunWebDocumentViewerMiddleware(new WebCaptureDotnet8.MyWdvCallbacks()); });

app.Map("/wcs", wcsApp => wcsApp.RunWebCaptureMiddleware())
    .Map("/wdv", wdvApp => { wdvApp.RunWebDocumentViewerMiddleware(new WebCaptureDotnet8.MyWdvCallbacks()); });

app.Run();
