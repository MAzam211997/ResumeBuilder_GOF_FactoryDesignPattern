using ResumeBuilder_GOF_FactoryDesignPattern.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder_GOF_FactoryDesignPattern.Documents
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }
        // Factory Method
        public abstract void CreatePages();
    }
}
