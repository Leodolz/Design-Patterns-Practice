using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class SimpleDocument : UserDocumentTemplate
    {
        protected override void InitializeDocument(string title)
        {
            if(title!=string.Empty)
                documentTitle = title;
            Console.WriteLine("Creating simple document with title: " + title);
        }

        protected override void WriteDocument(string documentBody)
        {
            this.documentBody = documentBody;
        }

        protected override void WriteNotes(string notes)
        {
            documentNotes = notes;
        }
    }
}
