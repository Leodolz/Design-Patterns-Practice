using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class UserDocumentTemplate
    {
        int docNumber = 0;
        protected string documentTitle = "Default";
        protected string documentBody = "Default Body";
        protected string documentNotes = "Default Notes";
        public void MakeDocument(string documentBody, string title="", string notes="")
        {
            InitializeDocument(title);
            WriteDocument(documentBody);
            WriteNotes(notes);
            ChangeNameIfNecessary();
            SaveDocument();
            DescribeDocument();
        }
        protected virtual void InitializeDocument(string title)
        {
            Console.WriteLine("Starting document with default title");
        }
        protected abstract void WriteDocument(string documentBody);
        protected abstract void WriteNotes(string notes);
        private void ChangeNameIfNecessary()
        {
            if (DocumentRepository.userDocuments.Find(savedDocument => savedDocument.documentTitle.Equals(this.documentTitle)) != null)
            {
                docNumber = docNumber + 1;
                documentTitle = documentTitle + docNumber;
                ChangeNameIfNecessary();
            }
            else docNumber = 0;
        }
        private void SaveDocument()
        {
            Console.WriteLine("Saving document with title "+documentTitle);
            DocumentRepository.userDocuments.Add(this);
        }
        public void DescribeDocument()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Title: " + documentTitle);
            Console.WriteLine("Body:\n" + documentBody+"\n");
            Console.WriteLine("Notes: " + documentNotes);
            Console.WriteLine("--------------------------------------");
        }
        
    }
}
