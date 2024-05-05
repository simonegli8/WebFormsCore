﻿// Decompiled with JetBrains decompiler
// Type: System.Configuration.NameValueSectionHandler
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 84F5A18A-F2B1-435C-B86E-09CE162E61E4
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// XML documentation location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8.1\System.xml

using System.Collections;
using System.Xml;

#nullable disable
namespace System.Configuration
{
  /// <summary>Provides name/value-pair configuration information from a configuration section.</summary>
  public class NameValueSectionHandler : IConfigurationSectionHandler
  {
    private const string defaultKeyAttribute = "key";
    private const string defaultValueAttribute = "value";

    /// <summary>Creates a new configuration handler and adds it to the section-handler collection based on the specified parameters.</summary>
    /// <param name="parent">Parent object.</param>
    /// <param name="context">Configuration context object.</param>
    /// <param name="section">Section XML node.</param>
    /// <returns>A configuration object.</returns>
    public object Create(object parent, object context, XmlNode section)
    {
      return NameValueSectionHandler.CreateStatic(parent, section, this.KeyAttributeName, this.ValueAttributeName);
    }

    internal static object CreateStatic(object parent, XmlNode section)
    {
      return NameValueSectionHandler.CreateStatic(parent, section, "key", "value");
    }

    internal static object CreateStatic(
      object parent,
      XmlNode section,
      string keyAttriuteName,
      string valueAttributeName)
    {
      ReadOnlyNameValueCollection nameValueCollection = parent != null ? new ReadOnlyNameValueCollection((ReadOnlyNameValueCollection) parent) : new ReadOnlyNameValueCollection((IEqualityComparer) StringComparer.OrdinalIgnoreCase);
      HandlerBase.CheckForUnrecognizedAttributes(section);
      foreach (XmlNode childNode in section.ChildNodes)
      {
        if (!HandlerBase.IsIgnorableAlsoCheckForNonElement(childNode))
        {
          if (childNode.Name == "add")
          {
            string name = HandlerBase.RemoveRequiredAttribute(childNode, keyAttriuteName);
            string str = HandlerBase.RemoveRequiredAttribute(childNode, valueAttributeName, true);
            HandlerBase.CheckForUnrecognizedAttributes(childNode);
            nameValueCollection[name] = str;
          }
          else if (childNode.Name == "remove")
          {
            string name = HandlerBase.RemoveRequiredAttribute(childNode, keyAttriuteName);
            HandlerBase.CheckForUnrecognizedAttributes(childNode);
            nameValueCollection.Remove(name);
          }
          else if (childNode.Name.Equals("clear"))
          {
            HandlerBase.CheckForUnrecognizedAttributes(childNode);
            nameValueCollection.Clear();
          }
          else
            HandlerBase.ThrowUnrecognizedElement(childNode);
        }
      }
      nameValueCollection.SetReadOnly();
      return (object) nameValueCollection;
    }

    /// <summary>Gets the XML attribute name to use as the key in a key/value pair.</summary>
    /// <returns>A <see cref="T:System.String" /> value containing the name of the key attribute.</returns>
    protected virtual string KeyAttributeName => "key";

    /// <summary>Gets the XML attribute name to use as the value in a key/value pair.</summary>
    /// <returns>A <see cref="T:System.String" /> value containing the name of the value attribute.</returns>
    protected virtual string ValueAttributeName => "value";
  }
}
