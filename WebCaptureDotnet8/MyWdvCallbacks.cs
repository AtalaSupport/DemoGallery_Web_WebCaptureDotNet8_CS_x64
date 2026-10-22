using Atalasoft.Imaging.WebControls;
using Atalasoft.Imaging.WebControls.Core;

namespace WebCaptureDotnet8
{
    public class MyWdvCallbacks: WebDocumentViewerCallbacks
    {
        /// IMPORTANT: make sure you fully disable File Upload if you're not using it by adding this handler
        public override void FileUpload(FileUploadEventArgs args)
        {
            args.Cancel = true;
            base.FileUpload(args);
        }
        public override void DocumentInfoRequested(DocumentInfoRequestedEventArgs args)
        {
            Console.WriteLine("**********===DocumentInfoRequested===**********");
            base.DocumentInfoRequested(args);
        }
        public override void ImageRequested(ImageRequestedEventArgs args)
        {
            Console.WriteLine("**********===ImageRequested===**********");
            base.ImageRequested(args);
        }
        /*
         * The above was just an example of hooking to the two main events.. you can handle any exposed event here
         *
         * //.. most common ...
         *  AnnotationDataRequested
         *  DocumentSave
         *  DocumentStreamWritten
         *  AnnotationStreamWritten
         *  //.. less common .
         *  PageTextRequested
         *  PdfFormRequested
         *  //.. rarely if ever used .. 
         *  ReleaseDocumentStream
         *  ReleasePageStream
         *  ResolveDocumentUri
         *  ResolvePageUri
         */
    }
}
