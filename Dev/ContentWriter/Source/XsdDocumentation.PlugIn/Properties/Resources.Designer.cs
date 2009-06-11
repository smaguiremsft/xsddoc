﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XsdDocumentation.PlugIn.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XsdDocumentation.PlugIn.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appearance.
        /// </summary>
        internal static string ConfigCategoryAppearance {
            get {
                return ResourceManager.GetString("ConfigCategoryAppearance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files.
        /// </summary>
        internal static string ConfigCategoryFiles {
            get {
                return ResourceManager.GetString("ConfigCategoryFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index.
        /// </summary>
        internal static string ConfigCategoryIndex {
            get {
                return ResourceManager.GetString("ConfigCategoryIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies an XSLT transformation file that is used to translate inline schema documentation into the schemaDoc element..
        /// </summary>
        internal static string ConfigDescriptionAnnotationTransformFilePath {
            get {
                return ResourceManager.GetString("ConfigDescriptionAnnotationTransformFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies additional documentation files to be used..
        /// </summary>
        internal static string ConfigDescriptionDocFilePaths {
            get {
                return ResourceManager.GetString("ConfigDescriptionDocFilePaths", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, the root elements get their own entry in the table of contents..
        /// </summary>
        internal static string ConfigDescriptionDocumentRootElements {
            get {
                return ResourceManager.GetString("ConfigDescriptionDocumentRootElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, the root schemas get their own entry in the table of contents. Please note that DocumentSchemas must be set to true for this setting to be effective..
        /// </summary>
        internal static string ConfigDescriptionDocumentRootSchemas {
            get {
                return ResourceManager.GetString("ConfigDescriptionDocumentRootSchemas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, the schemas get their own entry in the table of contents..
        /// </summary>
        internal static string ConfigDescriptionDocumentSchemas {
            get {
                return ResourceManager.GetString("ConfigDescriptionDocumentSchemas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, every element, attribute, group, attribute group, complex type, and simple type topic contains a section showing their XSD declaration..
        /// </summary>
        internal static string ConfigDescriptionDocumentSyntax {
            get {
                return ResourceManager.GetString("ConfigDescriptionDocumentSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether XML entity links such as &quot;http://schemas.example.org#E/myElement/@myAttribute&quot; are included in the K keyword index. This allows programmatically navigating the help file to a topic describing a given XML entity..
        /// </summary>
        internal static string ConfigDescriptionIncludeLinkUriInKeywordK {
            get {
                return ResourceManager.GetString("ConfigDescriptionIncludeLinkUriInKeywordK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, a namespace table of content entry will be created as the container of the namespace contents in the documented schema set. If false, the namespace contents are listed directly. Please note that this setting is ignored if the schema set contains more than one namespace. In that case, every namespace will always have a table of content entry..
        /// </summary>
        internal static string ConfigDescriptionNamespaceContainer {
            get {
                return ResourceManager.GetString("ConfigDescriptionNamespaceContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the schema files the schema set will depend on. They will be added to the internal schema set in order to be able to process it but these schemas will not being documented..
        /// </summary>
        internal static string ConfigDescriptionSchemaDependencyFilePaths {
            get {
                return ResourceManager.GetString("ConfigDescriptionSchemaDependencyFilePaths", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the schema files that are part of the schema set..
        /// </summary>
        internal static string ConfigDescriptionSchemaFilePaths {
            get {
                return ResourceManager.GetString("ConfigDescriptionSchemaFilePaths", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If true, a root &quot;Schema Set&quot; table of content entry will be created as the container of the namespaces in the documented schema set. If false, the default, the namespaces are listed in the table of content as root entries..
        /// </summary>
        internal static string ConfigDescriptionSchemaSetContainer {
            get {
                return ResourceManager.GetString("ConfigDescriptionSchemaSetContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An alternate title for the &quot;Schema Set&quot; page and the root table of content container..
        /// </summary>
        internal static string ConfigDescriptionSchemaSetTitle {
            get {
                return ResourceManager.GetString("ConfigDescriptionSchemaSetTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This defines the sort order for merging the XML schema topics with the main help file..
        /// </summary>
        internal static string ConfigDescriptionSortOrder {
            get {
                return ResourceManager.GetString("ConfigDescriptionSortOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Documentation Files (*.xml)|*.xml|All Files (*.*)|*.*.
        /// </summary>
        internal static string DocFilePathsEditorFilter {
            get {
                return ResourceManager.GetString("DocFilePathsEditorFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Documentation Files.
        /// </summary>
        internal static string DocFilePathsEditorTitle {
            get {
                return ResourceManager.GetString("DocFilePathsEditorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} file(s).
        /// </summary>
        internal static string FilePathCollectionConverterFileCountFormatted {
            get {
                return ResourceManager.GetString("FilePathCollectionConverterFileCountFormatted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (None).
        /// </summary>
        internal static string FilePathCollectionConverterNoFiles {
            get {
                return ResourceManager.GetString("FilePathCollectionConverterNoFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating XML documentation....
        /// </summary>
        internal static string PlugInBuildProgress {
            get {
                return ResourceManager.GetString("PlugInBuildProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This plug-in creates reference documentation for an XML schema set..
        /// </summary>
        internal static string PlugInDescription {
            get {
                return ResourceManager.GetString("PlugInDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML Schema Documenter.
        /// </summary>
        internal static string PlugInName {
            get {
                return ResourceManager.GetString("PlugInName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Version {1}\r\n{2}\r\n.
        /// </summary>
        internal static string PlugInVersionFormatted {
            get {
                return ResourceManager.GetString("PlugInVersionFormatted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML Schema Files (*.xsd)|*.xsd|All Files (*.*)|*.*.
        /// </summary>
        internal static string SchemaDependencyFilePathsEditorFilter {
            get {
                return ResourceManager.GetString("SchemaDependencyFilePathsEditorFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Schema Dependency Files.
        /// </summary>
        internal static string SchemaDependencyFilePathsEditorTitle {
            get {
                return ResourceManager.GetString("SchemaDependencyFilePathsEditorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML Schema Files (*.xsd)|*.xsd|All Files (*.*)|*.*.
        /// </summary>
        internal static string SchemaFilePathsEditorFilter {
            get {
                return ResourceManager.GetString("SchemaFilePathsEditorFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Schema Files.
        /// </summary>
        internal static string SchemaFilePathsEditorTitle {
            get {
                return ResourceManager.GetString("SchemaFilePathsEditorTitle", resourceCulture);
            }
        }
    }
}
