'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports System.Linq
Imports System.Management
Imports System.Text

Imports Microsoft.LightSwitch.Designers.ScreenTemplates.Model
Imports Microsoft.LightSwitch.Model
Imports Microsoft.LightSwitch.Model.Storage

Namespace ScreenTemplates

    Friend Class AddEditScreenTemplate
        Implements IScreenTemplate

#Region "IScreenTemplate Members"

        'Listing 13-22. Creating a Screen Template Extension
        Public Sub Generate(host As IScreenTemplateHost) Implements IScreenTemplate.Generate
            Dim screenBase = DirectCast(host.PrimaryDataSourceProperty, ScreenPropertyBase)

            Dim groupLayout1 As ContentItem =
                host.AddContentItem(host.ScreenLayoutContentItem,
                  "GroupLayout1", ContentItemKind.Group)

            Dim entityTypeFullName As String =
               CType(host.PrimaryDataSourceProperty, ScreenProperty).PropertyType
            Dim entityTypeName As String =
               CType(host.PrimaryDataSourceProperty, 
                  ScreenProperty).PropertyType.Split(":").LastOrDefault()
            Dim screenProperty1 As ScreenProperty =
               host.AddScreenProperty(entityTypeFullName, entityTypeName + "Property")

            'make the default id parameter not required    
            Dim idParameter =
               host.PrimaryDataSourceParameterProperties().FirstOrDefault()
            CType(idParameter, ScreenProperty).PropertyType =
               "Microsoft.LightSwitch:Int32?"

            'This creates an AutoCompleteBox for the item
            Dim screenPropertyContentItem =
               host.AddContentItem(groupLayout1, "LocalProperty", screenProperty1)
            Try
                host.SetContentItemView(screenPropertyContentItem,
                   "Microsoft.LightSwitch:RowsLayout")
            Catch ex As Exception
                Try
                    host.SetContentItemView(screenPropertyContentItem,
                      "Microsoft.LightSwitch.RichClient:RowsLayout")
                Catch ex2 As Exception
                    Throw ex2
                End Try
            End Try
            host.ExpandContentItem(screenPropertyContentItem)

            'Code Generation
            Dim codeTemplate As String = ""
            If _codeTemplates.TryGetValue(
               host.ScreenCodeBehindLanguage, codeTemplate) Then

                host.AddScreenCodeBehind(String.Format(codeTemplate,
                   Environment.NewLine,
                   host.ScreenNamespace,
                   host.ScreenName,
                   screenBase.Name,
                   idParameter.Name,
                   screenProperty1.Name,
                   entityTypeName))
            End If

        End Sub

        'Listing 13-23. Creating Screen Template Code 
        Private Shared _codeTemplates As Dictionary(Of CodeLanguage, String) =
   New Dictionary(Of CodeLanguage, String)() From
{
    {CodeLanguage.CSharp, _
        "" _
        + "{0}namespace {1}" _
        + "{0}{{" _
        + "{0}    public partial class {2}" _
        + "{0}    {{" _
        + "{0}" _
        + "{0}        partial void {5}_Loaded(bool succeeded)" _
        + "{0}        {{" _
        + "{0}            if (!this.{4}.HasValue){" _
        + "{0}               this.{5} = new {6}();" _
        + "{0}            }else{" _
        + "{0}               this.{5}  = this.{3};" _
        + "{0}            }" _
        + "{0}            this.SetDisplayNameFromEntity(this.{5});" _
        + "{0}        }}" _
        + "{0}" _
        + "{0}    }}" _
        + "{0}}}"
    }, _
    {CodeLanguage.VB, _
        "" _
        + "{0}Namespace {1}" _
        + "{0}" _
        + "{0}    Public Class {2}" _
        + "{0}" _
        + "{0}        Private Sub {5}_Loaded(succeeded As Boolean)" _
        + "{0}            If Not Me.{4}.HasValue Then" _
        + "{0}               Me.{5} = New {6}()" _
        + "{0}            Else" _
        + "{0}               Me.{5} = Me.{3}" _
        + "{0}            End If" _
        + "{0}            Me.SetDisplayNameFromEntity(Me.{5})" _
        + "{0}        End Sub" _
        + "{0}" _
        + "{0}    End Class" _
        + "{0}" _
        + "{0}End Namespace" _
    }
}

        Public ReadOnly Property Description As String Implements IScreenTemplateMetadata.Description
            Get
                Return "This template creates a combined Add/Edit screen."
            End Get
        End Property

        Public ReadOnly Property DisplayName As String Implements IScreenTemplateMetadata.DisplayName
            Get
                Return "Add/Edit Screen Template"
            End Get
        End Property

        Public ReadOnly Property PreviewImage As Uri Implements IScreenTemplateMetadata.PreviewImage
            Get
                Return New Uri("/ApressExtensionVB.Design;component/Resources/ScreenTemplateImages/AddEditScreenTemplateLarge.png", UriKind.Relative)
            End Get
        End Property

        Public ReadOnly Property RootDataSource As RootDataSourceType Implements IScreenTemplateMetadata.RootDataSource
            Get
                Return RootDataSourceType.ScalarEntity
            End Get
        End Property

        Public ReadOnly Property ScreenNameFormat As String Implements IScreenTemplateMetadata.ScreenNameFormat
            Get
                Return "{0}AddEditScreen"
            End Get
        End Property

        Public ReadOnly Property SmallIcon As Uri Implements IScreenTemplateMetadata.SmallIcon
            Get
                Return New Uri("/ApressExtensionVB.Design;component/Resources/ScreenTemplateImages/AddEditScreenTemplateSmall.png", UriKind.Relative)
            End Get
        End Property

        Public ReadOnly Property SupportsChildCollections As Boolean Implements IScreenTemplateMetadata.SupportsChildCollections
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property TemplateName As String Implements IScreenTemplateMetadata.TemplateName
            Get
                Return AddEditScreenTemplate.TemplateId
            End Get
        End Property

#End Region

#Region "Constants"

        Friend Const TemplateId As String = "ApressExtensionVB:AddEditScreenTemplate"

#End Region

    End Class

    <Export(GetType(IScreenTemplateFactory))>
    <Template(AddEditScreenTemplate.TemplateId)>
    Friend Class AddEditScreenTemplateFactory
        Implements IScreenTemplateFactory

#Region "IScreenTemplateFactory Members"

        Public Function CreateScreenTemplate() As IScreenTemplate Implements IScreenTemplateFactory.CreateScreenTemplate
            Return New AddEditScreenTemplate()
        End Function

#End Region

    End Class

End Namespace
