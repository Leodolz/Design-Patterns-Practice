using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class DocumentMaker
    {
        private Dictionary<string, UserDocumentTemplate> availableDocuments = new Dictionary<string, UserDocumentTemplate>();
        public DocumentMaker()
        {
            DocumentRepository.userDocuments = new List<UserDocumentTemplate>();
        }
        public void MakeDocument(string type, string body, string title="", string notes="", Dictionary<string,string> images = null)
        {
            switch (type)
            {
                case "SIMPLE":
                    new SimpleDocument().MakeDocument(body, title, notes);
                    break;
                case "IMAGES":
                    new DocumentWithImages(images).MakeDocument(body, title, notes);
                    break;
                default:
                    Console.WriteLine("Undefined type");
                    break;
            }
        }
    }
}
