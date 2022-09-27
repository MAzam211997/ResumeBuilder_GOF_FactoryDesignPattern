using ResumeBuilder_GOF_FactoryDesignPattern.Pages.PageSections;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder_GOF_FactoryDesignPattern.Documents.Reports
{
    internal class Report:Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionSection());
            Pages.Add(new ResultsSection());
            Pages.Add(new ConclusionSection());
            Pages.Add(new SummarySection());
            Pages.Add(new BibliographySection());
        }
    }
}
