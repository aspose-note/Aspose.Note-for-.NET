Imports System.Text
Imports System.IO
Imports Aspose.Note
Namespace Loading_Saving
    Public Class ExtractContent
        Public Shared Sub Run()
            ' ExStart:ExtractContent
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Open the document we want to convert.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Create an object that inherits from the DocumentVisitor class.
            Dim myConverter As New MyOneNoteToTxtWriter()

            ' This is the well known Visitor pattern. Get the model to accept a visitor.
            ' The model will iterate through itself by calling the corresponding methods
            ' on the visitor object (this is called visiting).
            '
            ' Note that every node in the object model has the Accept method so the visiting
            ' can be executed not only for the whole document, but for any node in the document.
            doc.Accept(myConverter)

            ' Once the visiting is complete, we can retrieve the result of the operation,
            ' that in this example, has accumulated in the visitor.
            Console.WriteLine(myConverter.GetText())
            Console.WriteLine(myConverter.NodeCount)
            ' ExEnd:ExtractContent

        End Sub
        ''' <summary>
        ''' Simple implementation of saving a document in the plain text format. Implemented as a Visitor.
        ''' </summary>
        Public Class MyOneNoteToTxtWriter
            Inherits DocumentVisitor
            Public Sub New()
                m_nodecount = 0
                mIsSkipText = False
                mBuilder = New StringBuilder()
            End Sub

            ''' <summary>
            ''' Gets the plain text of the document that was accumulated by the visitor.
            ''' </summary>
            Public Function GetText() As String
                Return mBuilder.ToString()
            End Function

            ''' <summary>
            ''' Adds text to the current output. Honors the enabled/disabled output flag.
            ''' </summary>
            Private Sub AppendText(text As String)
                If Not mIsSkipText Then
                    mBuilder.Append(text)
                End If
            End Sub

            ''' <summary>
            ''' Called when a RichText node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitRichTextStart(run As RichText)
                m_nodecount += 1
                AppendText(run.Text)
            End Sub

            ''' <summary>
            ''' Called when a Document node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitDocumentStart(document As Document)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a Page node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitPageStart(page As Page)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a Title node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitTitleStart(title As Title)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a Image node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitImageStart(image As Image)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a OutlineGroup node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitOutlineGroupStart(outlineGroup As OutlineGroup)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a Outline node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitOutlineStart(outline As Outline)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Called when a OutlineElement node is encountered in the document.
            ''' </summary>
            Public Overrides Sub VisitOutlineElementStart(outlineElement As OutlineElement)
                m_nodecount += 1
            End Sub

            ''' <summary>
            ''' Gets the total count of nodes by the Visitor
            ''' </summary>
            Public ReadOnly Property NodeCount() As Int32
                Get
                    Return Me.m_nodecount
                End Get
            End Property

            Private ReadOnly mBuilder As StringBuilder
            Private mIsSkipText As Boolean
            Private m_nodecount As Int32
        End Class
    End Class
End Namespace