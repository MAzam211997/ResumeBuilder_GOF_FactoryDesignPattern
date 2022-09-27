using ResumeBuilder_GOF_FactoryDesignPattern.Pages.PageSections;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder_GOF_FactoryDesignPattern.Documents.Resumes
{
    internal class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsSection());
            Pages.Add(new EducationSection());
            Pages.Add(new ExperienceSection());
        }
    }
}
