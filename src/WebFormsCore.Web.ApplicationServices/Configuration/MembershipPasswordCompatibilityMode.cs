﻿// Decompiled with JetBrains decompiler
// Type: System.Web.Configuration.MembershipPasswordCompatibilityMode
// Assembly: System.Web.ApplicationServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 49FC561C-A827-422E-A5C7-EDE4066C7817
// Assembly location: C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll
// XML documentation location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8.1\System.Web.ApplicationServices.xml

#nullable disable
namespace System.Web.Configuration
{
  /// <summary>Enumerates the password-compatibility modes for ASP.NET membership.</summary>
  public enum MembershipPasswordCompatibilityMode
  {
    /// <summary>Passwords are in ASP.NET 2.0 mode.</summary>
    Framework20,
    /// <summary>Passwords are in ASP.NET 4 mode.</summary>
    Framework40,
  }
}
