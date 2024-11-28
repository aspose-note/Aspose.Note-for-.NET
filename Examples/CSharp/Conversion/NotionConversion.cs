using Notion.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Aspose.Note.Examples.CSharp.Conversion
{
    public class NotionConversion
    {
        public static async Task RunAsync()
        {
            await ConvertOneToNotionHtml();
        }

        public static async Task ConvertOneToNotionHtml()
        {
            // ExStart:ConvertOneToNotionHtml
            // ExFor:Document.Load
            // ExSummary:Shows how to convert a OneNote document to Notion-compatible HTML.
            var dataDir = RunExamples.GetDataDir_Import();
            var documentPath = Path.Combine(dataDir, "Sample.one");

            // Initialize OneNote document
            var document = new Document(documentPath);

            // Notion client setup
            var authToken = "your-notion-auth-token";
            var parentPageId = "your-notion-parent-page-id";

            var client = NotionClientFactory.Create(new ClientOptions
            {
                AuthToken = authToken
            });

            // Retrieve the Notion page
            var page = await client.Pages.RetrieveAsync(parentPageId);

            // Iterate over OneNote pages and add them to Notion
            foreach (var oneNotePage in document)
            {
                var oneNoteAllRichText = oneNotePage.GetChildNodes<RichText>();

                var pagesCreateParametersBuilder = PagesCreateParametersBuilder
                    .Create(new ParentPageInput { PageId = page.Id })
                    .AddProperty("title",
                    new TitlePropertyValue
                    {
                        Title = new List<RichTextBase>
                        {
                        new RichTextTextInput { Text = new Notion.Client.Text { Content = oneNotePage.Title.TitleText.Text } }
                        }
                    });

                foreach (var richText in oneNoteAllRichText)
                {
                    // Skip title, date, or time texts
                    if (richText.IsTitleDate || richText.IsTitleText || richText.IsTitleTime)
                    {
                        continue;
                    }

                    pagesCreateParametersBuilder.AddPageContent(new ParagraphBlock
                    {
                        Paragraph = new ParagraphBlock.Info
                        {
                            RichText = new List<RichTextBase> {
                            new RichTextText
                            {
                                Text = new Notion.Client.Text { Content = richText.Text }
                            }
                        }
                        }
                    });
                }

                // Create page in Notion
                var pagesCreateParameters = pagesCreateParametersBuilder.Build();
                await client.Pages.CreateAsync(pagesCreateParameters);
            }

            Console.WriteLine("\nOneNote document converted to Notion-compatible format successfully.");
            // ExEnd:ConvertOneToNotionHtml
        }
    }
}
