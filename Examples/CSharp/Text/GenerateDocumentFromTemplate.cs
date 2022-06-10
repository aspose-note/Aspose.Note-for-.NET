// -----------------------------------------------------------------------
//  <copyright file="GenerateDocumentFromTemplate.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class GenerateDocumentFromTemplate
    {
        public static void Run()
        {
            // ExStart:GenerateDocumentFromTemplate
            // ExFor:RichText.Replace(System.String,System.String)
            // ExSummary:Shows how to generate a new document by replacing special text pieces in a template.
            string dataDir = RunExamples.GetDataDir_Text();

            var D = new Dictionary<string, string>
                        {
                            { "Company", "Atlas Shrugged Ltd" },
                            { "CandidateName", "John Galt" },
                            { "JobTitle", "Chief Entrepreneur Officer" },
                            { "Department", "Sales" },
                            { "Salary", "123456 USD" },
                            { "Vacation", "30" },
                            { "StartDate", "29 Feb 2024" },
                            { "YourName", "Ayn Rand" }
                        };

            // Load the template document into Aspose.Note.
            var d = new Document(Path.Combine(dataDir, "JobOffer.one"));

            // Let's replace all template words
            foreach (var e in d.GetChildNodes<RichText>())
            {
                foreach (var replace in D)
                {
                    e.Replace($"${{{replace.Key}}}", replace.Value);
                }
            }

            d.Save(Path.Combine(dataDir, "JobOffer_out.one"));

            // ExEnd:GenerateDocumentFromTemplate

            Console.WriteLine("\nThe document is generated successfully.");
        }
    }
}
