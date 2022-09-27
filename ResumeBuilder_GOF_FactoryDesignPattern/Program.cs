using ResumeBuilder_GOF_FactoryDesignPattern.Documents;
using ResumeBuilder_GOF_FactoryDesignPattern.Documents.Reports;
using ResumeBuilder_GOF_FactoryDesignPattern.Documents.Resumes;
using ResumeBuilder_GOF_FactoryDesignPattern.Pages;
using System;

namespace ResumeBuilder_GOF_FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
