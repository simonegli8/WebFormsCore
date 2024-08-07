﻿
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

#nullable disable
namespace System.Net.Configuration
{
  internal sealed class AuthenticationModulesSectionInternal
  {
    private List<Type> authenticationModules;
    private static object classSyncObject;

    internal AuthenticationModulesSectionInternal(AuthenticationModulesSection section)
    {
      if (section.AuthenticationModules.Count <= 0)
        return;
      this.authenticationModules = new List<Type>(section.AuthenticationModules.Count);
      foreach (AuthenticationModuleElement authenticationModule in (ConfigurationElementCollection) section.AuthenticationModules)
      {
        Type type;
        try
        {
          type = Type.GetType(authenticationModule.Type, true, true);
          if (!typeof (IAuthenticationModule).IsAssignableFrom(type))
            throw new InvalidCastException(SR.GetString("net_invalid_cast", (object) type.FullName, (object) "IAuthenticationModule"));
        }
        catch (Exception ex)
        {
          if (!NclUtilities.IsFatal(ex))
            throw new ConfigurationErrorsException(SR.GetString("net_config_authenticationmodules"), ex);
          throw;
        }
        this.authenticationModules.Add(type);
      }
    }

    internal List<Type> AuthenticationModules => this.authenticationModules ?? new List<Type>(0);

    internal static object ClassSyncObject
    {
      get
      {
        if (AuthenticationModulesSectionInternal.classSyncObject == null)
        {
          object obj = new object();
          Interlocked.CompareExchange(ref AuthenticationModulesSectionInternal.classSyncObject, obj, (object) null);
        }
        return AuthenticationModulesSectionInternal.classSyncObject;
      }
    }

    internal static AuthenticationModulesSectionInternal GetSection()
    {
      lock (AuthenticationModulesSectionInternal.ClassSyncObject)
        return !(PrivilegedConfigurationManager.GetSection(ConfigurationStrings.AuthenticationModulesSectionPath) is AuthenticationModulesSection section) ? (AuthenticationModulesSectionInternal) null : new AuthenticationModulesSectionInternal(section);
    }
  }
}
