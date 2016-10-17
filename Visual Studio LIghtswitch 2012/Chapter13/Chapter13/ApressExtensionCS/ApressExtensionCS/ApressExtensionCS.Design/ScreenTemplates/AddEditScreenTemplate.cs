//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Management;
using System.Text;

using Microsoft.LightSwitch.Designers.ScreenTemplates.Model;
using Microsoft.LightSwitch.Model;
using Microsoft.LightSwitch.Model.Storage;

namespace ApressExtensionCS.ScreenTemplates
{
    internal class AddEditScreenTemplate : IScreenTemplate
    {
        #region IScreenTemplate Members

        public void Generate(IScreenTemplateHost host)
        {
            var screenBase = (ScreenPropertyBase)host.PrimaryDataSourceProperty;

            ContentItem groupLayout1 =
               host.AddContentItem(host.ScreenLayoutContentItem,
                  "GroupLayout1", ContentItemKind.Group);

            string entityTypeFullName =
              ((ScreenProperty)host.PrimaryDataSourceProperty).PropertyType;

            var entityTypeName =
              ((ScreenProperty)host.PrimaryDataSourceProperty).PropertyType.Split(
                 ":".ToArray()).LastOrDefault();

            ScreenProperty screenProperty1 =
              (ScreenProperty)host.AddScreenProperty(entityTypeFullName,
                 entityTypeName + "Property");

            //make the default id parameter not required    
            var idParameter = host.PrimaryDataSourceParameterProperties.FirstOrDefault();
            ((ScreenProperty)idParameter).PropertyType =
                "Microsoft.LightSwitch:Int32?";

            //This creates an AutoCompleteBox for the item
            var screenPropertyContentItem = host.AddContentItem(
               groupLayout1, " LocalProperty", screenProperty1);
            try
            {
                host.SetContentItemView(
                    screenPropertyContentItem, "Microsoft.LightSwitch:RowsLayout");
            }
            catch (Exception ex)
            {
                try
                {
                    host.SetContentItemView(screenPropertyContentItem,
                        @"Microsoft.LightSwitch.RichClient:RowsLayout");
                }
                catch (Exception ex2)
                {
                    throw ex2;
                }
            }

            host.ExpandContentItem(screenPropertyContentItem);

            string codeTemplate = "";
            if (codeTemplates.TryGetValue(
                host.ScreenCodeBehindLanguage, out codeTemplate))
            {
                host.AddScreenCodeBehind(String.Format(codeTemplate,
                   Environment.NewLine,
                   host.ScreenNamespace,
                   host.ScreenName,
                   screenBase.Name,
                   idParameter.Name,
                   screenProperty1.Name,
                   entityTypeName));
            }

        }

        //Listing 13-23. Creating Screen Template Code 
        private static Dictionary<CodeLanguage, String> codeTemplates =
            new Dictionary<CodeLanguage, String>()
            {
                {CodeLanguage.CSharp,
                    "" 
                    + "{0}namespace {1}" 
                    + "{0}{{" 
                    + "{0}    public partial class {2}" 
                    + "{0}    {{" 
                    + "{0}" 
                    + "{0}        partial void {5}Loaded(bool succeeded)" 
                    + "{0}        {{" 
                    + "{0}            if (!this.{4}.HasValue){{" 
                    + "{0}               this.{5} = new {6}();" 
                    + "{0}            }}else{{" 
                    + "{0}               this.{5} = this.{3};" 
                    + "{0}            }}" 
                    + "{0}            this.SetDisplayNameFromEntity(this.{5});" 
                    + "{0}        }}" 
                    + "{0}" 
                    + "{0}    }}" 
                    + "{0}}}"
                },
                {CodeLanguage.VB,
                    @"" 
                    + "{0}Namespace {1}" 
                    + "{0}" 
                    + "{0}    Public Class {2}" 
                    + "{0}" 
                    + "{0}        Private Sub {5}Loaded(succeeded As Boolean)" 
                    + "{0}            If Not Me.{4}.HasValue Then" 
                    + "{0}               Me.{5} = New {6}()" 
                    + "{0}            Else" 
                    + "{0}               Me.{5} = Me.{3}" 
                    + "{0}            End If" 
                    + "{0}            Me.SetDisplayNameFromEntity(Me.{5})" 
                    + "{0}        End Sub" 
                    + "{0}" 
                    + "{0}    End Class" 
                    + "{0}" 
                    + "{0}End Namespace" 
                }
            };

        #endregion

        #region IScreenTemplateMetadata Members

        public string Description
        {
            get { return "AddEditScreenTemplate description"; }
        }

        public string DisplayName
        {
            get { return "AddEditScreenTemplate"; }
        }

        public Uri PreviewImage
        {
            get { return new Uri("/ApressExtensionCS.Design;component/Resources/ScreenTemplateImages/AddEditScreenTemplateLarge.png", UriKind.Relative); }
        }

        public RootDataSourceType RootDataSource
        {
            get { return RootDataSourceType.ScalarEntity; }
        }

        public string ScreenNameFormat
        {
            get { return "{0}AddEditScreen"; }
        }

        public Uri SmallIcon
        {
            get { return new Uri("/ApressExtensionCS.Design;component/Resources/ScreenTemplateImages/AddEditScreenTemplateSmall.png", UriKind.Relative); }
        }

        public bool SupportsChildCollections
        {
            get { return true; }
        }

        public string TemplateName
        {
            get { return AddEditScreenTemplate.TemplateId; }
        }

        #endregion

        #region Constants

        internal const string TemplateId = "ApressExtensionCS:AddEditScreenTemplate";

        #endregion
    }

    [Export(typeof(IScreenTemplateFactory))]
    [Template(AddEditScreenTemplate.TemplateId)]
    internal class AddEditScreenTemplateFactory : IScreenTemplateFactory
    {
        #region IScreenTemplateFactory Members

        IScreenTemplate IScreenTemplateFactory.CreateScreenTemplate()
        {
            return new AddEditScreenTemplate();
        }

        #endregion
    }
}