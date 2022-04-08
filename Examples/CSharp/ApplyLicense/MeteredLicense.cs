// -----------------------------------------------------------------------
//  <copyright file="MeteredLicense.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.ApplyLicense
{
    using System;
    using System.IO;

    class MeteredLicense
    {
        public static void Run()
        {
            // ExStart:MeteredLicense
            // ExFor:Metered
            // ExFor:Metered.SetMeteredKey
            // ExSummary:Shows how to set metered license.

            Metered metered = new Metered();
            metered.SetMeteredKey("MyPublicKey", "MyPrivateKey");

            Console.WriteLine($"Credit before operation: {Metered.GetConsumptionCredit():F2}");
            Console.WriteLine($"Consumption quantity before operation: {Metered.GetConsumptionQuantity():F2}");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document and get first child           
            Document document = new Document(Path.Combine(dataDir, "Aspose.one"));
            
            document.Save(Path.Combine(dataDir, "MeteredLicense.pdf"));

            Console.WriteLine($"Credit before operation: {Metered.GetConsumptionCredit():F2}");
            Console.WriteLine($"Consumption quantity before operation: {Metered.GetConsumptionQuantity():F2}");

            // ExEnd:MeteredLicense
        }
    }
}
