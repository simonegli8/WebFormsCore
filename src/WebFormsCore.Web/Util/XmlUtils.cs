﻿//------------------------------------------------------------------------------
// <copyright file="XmlUtils.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Web.Util {

    using System.IO;
    using System.Xml;
    using System.Xml.XPath;
    using System.Xml.Xsl;
    using System.Diagnostics.CodeAnalysis;

    internal static class XmlUtils
    {
        public static readonly long MaxEntityExpansion = 1024 * 1024;

        [SuppressMessage("Microsoft.Security", "MSEC1208:DoNotUseLoadXml", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3057:DoNotUseLoadXml", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        public static XmlDocument CreateXmlDocumentFromContent(string content)
        {
            XmlDocument doc = new XmlDocument();

           if (AppSettings.RestrictXmlControls) {
                // We can't use the simple XmlDocument.LoadXml(string) here because there is no way to control the
                // resolver used in that process.  The only way we can do that is if we pass in our own XmlReader.
                using (StringReader sreader = new StringReader(content)) {
                    doc.Load(CreateXmlReader(sreader));
                }
            }
            else {
                doc.LoadXml(content);
            }
            return doc;
        }

        [SuppressMessage("Microsoft.Security", "MSEC1210:UseXmlReaderForXPathDocument", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3059:UseXmlReaderForXPathDocument", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        public static XPathDocument CreateXPathDocumentFromContent(string content)
        {
            StringReader reader = new StringReader(content);
            if (AppSettings.RestrictXmlControls) {
                return new XPathDocument(CreateXmlReader(reader));
            }
            else {
                return new XPathDocument(reader);
            }
        }

        [SuppressMessage("Microsoft.Security", "MSEC1220:ReviewDtdProcessingAssignment", Justification = "Dtd processing is needed for back-compat, but is being done as safely as possible.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3069:ReviewDtdProcessingAssignment", Justification = "Dtd processing is needed for back-compat, but is being done as safely as possible.")]
        public static XmlReaderSettings CreateXmlReaderSettings()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            if (AppSettings.RestrictXmlControls)
            {
                settings.MaxCharactersFromEntities = XmlUtils.MaxEntityExpansion;
                settings.XmlResolver = null;
                // Prohibit is the default here.  We don't need to prohibit DTD's, or even ignore them if we're using
                // RestrictXmlControls, because we use a null resolver and limit/disable entity expansion.
                settings.DtdProcessing = DtdProcessing.Parse;
            }
            return settings;
        }

        // Ideally, these XmlReader factories would use XmlReader.Create() in the non-RestrictXmlControls case,
        // but the default settings on that method are different from the default settings generated by XmlTextReader
        // constructors, which is the code we're replacing with these factories.  Since we want to keep doing
        // whatever it was that we did before in this case, we'll just new up an XmlTextReader rather than
        // try to guess at how to set matching defaults with XmlReader.Create().
        // (E.g. DtdProcessing is Parse by default using XmlTextReader directly.  It's Prohibit in default XmlReaderSettings.)
        [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3054:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security", "MSEC1225:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3074:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        public static XmlReader CreateXmlReader(string filepath)
        {
            if (AppSettings.RestrictXmlControls)
            {
                NoEntitiesXmlTextReader nextr = new NoEntitiesXmlTextReader(filepath);
                return XmlReader.Create(nextr, CreateXmlReaderSettings());
            }
            else
            {
                XmlTextReader xtr = new XmlTextReader(filepath);
                return xtr;
            }
        }

        [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3054:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security", "MSEC1225:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3074:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        public static XmlReader CreateXmlReader(Stream datastream)
        {
            if (AppSettings.RestrictXmlControls)
            {
                NoEntitiesXmlTextReader nextr = new NoEntitiesXmlTextReader(datastream);
                return XmlReader.Create(nextr, CreateXmlReaderSettings());
            }
            else
            {
                XmlTextReader xtr = new XmlTextReader(datastream);
                return xtr;
            }
        }

        [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3054:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security", "MSEC1225:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3074:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        public static XmlReader CreateXmlReader(TextReader reader)
        {
            if (AppSettings.RestrictXmlControls)
            {
                NoEntitiesXmlTextReader nextr = new NoEntitiesXmlTextReader(reader);
                return XmlReader.Create(nextr, CreateXmlReaderSettings());
            }
            else
            {
                XmlTextReader xtr = new XmlTextReader(reader);
                return xtr;
            }
        }

        [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3054:DoNotAllowDtdOnXmlTextReader", Justification = "Handles trusted or developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security", "MSEC1225:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3074:ReviewClassesDerivedFromXmlTextReader", Justification = "NoEntitiesXmlReader is our internal mechanism for using XmlTextReaders in a reasonably safe manner.")]
        public static XmlReader CreateXmlReader(Stream contentStream, string baseURI)
        {
            if (AppSettings.RestrictXmlControls)
            {
                NoEntitiesXmlTextReader nextr = new NoEntitiesXmlTextReader(baseURI, contentStream);
                return XmlReader.Create(nextr, CreateXmlReaderSettings());
            }
            else
            {
                XmlTextReader xtr = new XmlTextReader(baseURI, contentStream);
                return xtr;
            }
        }

        // If you use any of these overloads that take in XmlReaderSettings, the suggestion is to get your base settings from
        // CreateXmlReaderSettings().  That way you will have the correct defaults for RestrictXmlControls if applicable.
        // Then you need to be smart about which settings you change before passing in here, because we will not
        // re-enforce the correct settings, just in case you intentionally meant to change them.
        public static XmlReader CreateXmlReader(TextReader reader, string baseURI, XmlReaderSettings settings)
        {
            if (settings == null) {
                settings = CreateXmlReaderSettings();
            }

            // Note:  If there is nothing materially changed in the settings, then Create() will just return your reader back
            // to you and reader.Settings might still be null.
            return XmlReader.Create(reader, settings, baseURI);
        }

        public static XslCompiledTransform CreateXslCompiledTransform(XmlReader xmlReader)
        {
            XmlReader readerToUse = xmlReader;

            // XslCompiledTransform reconstructs its own XmlReader from scratch, so we can't rely entirely on the fancy
            // protections we have in place on our readers.  We need to bring out a bigger hammer and disable DTD's
            // alltogether.  We know how to work with XmlTextReader and which of its settings XslCompiledTransform will
            // respect.  For other reader types, just try to wrap it with new settings.
            if (AppSettings.RestrictXmlControls) {
                XmlTextReader xtr = xmlReader as XmlTextReader;
                if (xtr != null) {
                    xtr.DtdProcessing = DtdProcessing.Ignore;
                }
                else {
                    XmlReaderSettings settings = xmlReader.Settings;
                    if (settings == null) {
                        settings = CreateXmlReaderSettings();
                    }
                    settings.DtdProcessing = DtdProcessing.Ignore;
                    readerToUse = XmlReader.Create(xmlReader, settings);
                }
            }

            XslCompiledTransform compiledTransform = new XslCompiledTransform();
            // The second parameter is XsltSettings.  null results in the XsltSettings.Default being used, which disables the document function, and script
            // The third parameter is an XmlResolver to be used
            compiledTransform.Load(readerToUse, null, null);
            return compiledTransform;
        }


#pragma warning disable 0618    // To avoid deprecation warning
        [SuppressMessage("Microsoft.Security", "MSEC1201:DoNotUseXslTransform", Justification = "Handles developer-controlled input xsl.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3050:DoNotUseXslTransform", Justification = "Handles developer-controlled input xsl.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        public static XslTransform CreateXslTransform(XmlReader reader)
        {
            if (!AppSettings.RestrictXmlControls)
            {
                XslTransform xform = new XslTransform();
                xform.Load(reader);
                return xform;
            }
            return null;
        }

        [SuppressMessage("Microsoft.Security", "MSEC1201:DoNotUseXslTransform", Justification = "Handles developer-controlled input xsl.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        [SuppressMessage("Microsoft.Security.Xml", "CA3050:DoNotUseXslTransform", Justification = "Handles developer-controlled input xsl.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
        public static XslTransform CreateXslTransform(XmlReader reader, XmlResolver resolver)
        {
            if (!AppSettings.RestrictXmlControls)
            {
                XslTransform xform = new XslTransform();
#if NETFRAMEWORK
                xform.Load(reader, resolver, null);
#else
                xform.Load(reader, resolver);
#endif
                return xform;
            }
            return null;
        }

        public static XslTransform GetXslTransform(XslTransform xform)
        {
            return (AppSettings.RestrictXmlControls ? null : xform);
        }
#pragma warning restore 0618

        // This class exists to override the ResolveEntity() method, which can be used to force resolution of custom/external
        // entities in Xml files.  When we use this class, we should have already set EntityHandling to EntityHandling.ExpandCharEntities,
        // which will disable custom/external entity expansion by default.  But this extra protection will keep people from unintentionally
        // shooting themselves in the foot when they think they might have been safe.
        private sealed class NoEntitiesXmlTextReader : XmlTextReader
        {
            [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
            public NoEntitiesXmlTextReader() : base() { Restrict(); }
            [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
            public NoEntitiesXmlTextReader(string filepath) : base(filepath) { Restrict(); }
            [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
            public NoEntitiesXmlTextReader(TextReader reader) : base(reader) { Restrict(); }
            [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
            public NoEntitiesXmlTextReader(Stream datastream) : base(datastream) { Restrict(); }
            [SuppressMessage("Microsoft.Security", "MSEC1205:DoNotAllowDtdOnXmlTextReader", Justification = "Handles developer-controlled input xml.  Optional safer codepath available via appSettings/aspnet:RestrictXmlControls configuration.")]
            public NoEntitiesXmlTextReader(string baseURI, Stream contentStream) : base(baseURI, contentStream) { Restrict(); }

            public override void ResolveEntity()
            {
                // Do not ever do general entity expansion/replacement, even when asked
                return;
            }

            private void Restrict() {
                EntityHandling = EntityHandling.ExpandCharEntities;
                XmlResolver = null;
            }
        }
    }
}
