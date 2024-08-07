﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebGrease.Css {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CssStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CssStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebGrease.Css.CssStrings", typeof(CssStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The characters in the Css text &apos;{0}&apos; are not all lower case..
        /// </summary>
        public static string CssLowercaseValidationError {
            get {
                return ResourceManager.GetString("CssLowercaseValidationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred while validating the Css for the lower case validation: {0}.
        /// </summary>
        public static string CssLowercaseValidationParentNodeError {
            get {
                return ResourceManager.GetString("CssLowercaseValidationParentNodeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not allowed for selectors as it is not cross-browser supported..
        /// </summary>
        public static string CssSelectorHackError {
            get {
                return ResourceManager.GetString("CssSelectorHackError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The declarations &quot;background&quot; and &quot;background-image/background-position/background-repeat&quot; cannot be used simultaneously used with in a scope of same selector..
        /// </summary>
        public static string DuplicateBackgroundFormatError {
            get {
                return ResourceManager.GetString("DuplicateBackgroundFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to assemble the image &apos;{0}&apos; it should meet the criteria of having the absolute units in px and no-repeat in all the selectors..
        /// </summary>
        public static string DuplicateImageReferenceWithDifferentRulesError {
            get {
                return ResourceManager.GetString("DuplicateImageReferenceWithDifferentRulesError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedAstNode {
            get {
                return ResourceManager.GetString("ExpectedAstNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedEnum {
            get {
                return ResourceManager.GetString("ExpectedEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedIdentifierOrString {
            get {
                return ResourceManager.GetString("ExpectedIdentifierOrString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedOperator {
            get {
                return ResourceManager.GetString("ExpectedOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedSimpleSelector {
            get {
                return ResourceManager.GetString("ExpectedSimpleSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A term cannot have more than one value at a time..
        /// </summary>
        public static string ExpectedSingleValue {
            get {
                return ResourceManager.GetString("ExpectedSingleValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string ExpectedValue {
            get {
                return ResourceManager.GetString("ExpectedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found at location &apos;{0}&apos;..
        /// </summary>
        public static string FileNotFoundError {
            get {
                return ResourceManager.GetString("FileNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while processing file &apos;{0}&apos;.
        /// </summary>
        public static string InnerExceptionFile {
            get {
                return ResourceManager.GetString("InnerExceptionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while processing selector &apos;{0}&apos;.
        /// </summary>
        public static string InnerExceptionSelector {
            get {
                return ResourceManager.GetString("InnerExceptionSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image dimensions for &apos;{0}&apos; are specified in invalid units. Dimensions should be specified in pixels..
        /// </summary>
        public static string InvalidDimensionsError {
            get {
                return ResourceManager.GetString("InvalidDimensionsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element ‘originalfile’ cannot be empty in image assembly log file &apos;{0}&apos;..
        /// </summary>
        public static string OriginalFileElementEmptyError {
            get {
                return ResourceManager.GetString("OriginalFileElementEmptyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CSS property &apos;{0}&apos; declared more than once within the same selector. Any property must be specified only once within the scope of a selector..
        /// </summary>
        public static string RepeatedPropertyNameError {
            get {
                return ResourceManager.GetString("RepeatedPropertyNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are too many lengths specified for background position in term &apos;{0}&apos;..
        /// </summary>
        public static string TooManyLengthsError {
            get {
                return ResourceManager.GetString("TooManyLengthsError", resourceCulture);
            }
        }
    }
}
