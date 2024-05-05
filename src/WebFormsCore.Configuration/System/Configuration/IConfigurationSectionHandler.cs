﻿// Decompiled with JetBrains decompiler
// Type: System.Configuration.IConfigurationSectionHandler
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 84F5A18A-F2B1-435C-B86E-09CE162E61E4
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// XML documentation location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8.1\System.xml

using System.Xml;

#nullable disable
namespace System.Configuration
{
  /// <summary>Handles the access to certain configuration sections.</summary>
  public interface IConfigurationSectionHandler
  {
    /// <summary>Creates a configuration section handler.</summary>
    /// <param name="parent">Parent object.</param>
    /// <param name="configContext">Configuration context object.</param>
    /// <param name="section">Section XML node.</param>
    /// <returns>The created section handler object.</returns>
    object Create(object parent, object configContext, XmlNode section);
  }
}
