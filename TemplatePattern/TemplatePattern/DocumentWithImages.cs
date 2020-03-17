using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class DocumentWithImages : UserDocumentTemplate
    {
        private Dictionary<string,string> documentImages = new Dictionary<string,string>();
        private List<string> imagesUsed = new List<string>();
        public DocumentWithImages(Dictionary<string,string> documentImages)
        {
            this.documentImages = documentImages;
        }
        public DocumentWithImages()
        {

        }
        protected override void InitializeDocument(string title)
        {
            documentTitle = title;
            Console.WriteLine("Initializing document " + title);
        }

        protected override void WriteDocument(string documentBody)
        {
            foreach(KeyValuePair<string,string> documentImage in documentImages)
            {
                if (documentBody.Contains(documentImage.Key))
                {
                    documentBody = documentBody.Replace(documentImage.Key, "<" +documentImage.Value + ">");
                    imagesUsed.Add(documentImage.Key);
                }
            }
            this.documentBody = documentBody;
        }
        protected override void WriteNotes(string notes)
        {
            documentNotes = imagesUsed.Aggregate((i, j) => i + ", " + j);
            documentNotes = "Document notes: "+notes+"\nImages used: " + documentNotes;
        }
    }
}
