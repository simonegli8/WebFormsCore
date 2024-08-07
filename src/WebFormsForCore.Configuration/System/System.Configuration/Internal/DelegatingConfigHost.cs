//------------------------------------------------------------------------------
// <copyright file="DelegatingConfigHost.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Configuration.Internal {
    using System.Configuration;
    using System.IO;
    using System.Security.Permissions;
    using System.Reflection;
    using System.Threading;
    using System.Security;
    using System.Xml;

    //
    // A public implementation of IInternalConfigHost that simply 
    // delegates all members of the IInternalConfigHost interface to 
    // another instance of a host. All interface members are marked virtual
    // so that a derived class can override just the ones needed to
    // implement that specific host, while all others are delegated to
    // another implementation such as InternalConfigHost.
    //
    // The advantages of this arrangement are:
    //  * The IInternalConfigHost interface can be extended without
    //    requiring other hosts to be updated.
    //  * This class that we are making public has no implementation
    //    of its own that can be exploited. All the hosts with meaningful
    //    implementation can remain internal.
    //  * It allows straightforward chaining of host functionality,
    //    see UpdateConfigHost as an example.
    //
    public class DelegatingConfigHost : IInternalConfigHost, IInternalConfigurationBuilderHost {
        IInternalConfigHost _host;
        IInternalConfigurationBuilderHost _configBuilderHost;

        protected DelegatingConfigHost() {}

        // The host that is delegated to.
        protected IInternalConfigHost Host {
            get {return _host;}
            set {
                _host = value;
                _configBuilderHost = _host as IInternalConfigurationBuilderHost;
            }
        }

        protected IInternalConfigurationBuilderHost ConfigBuilderHost {
            get { return _configBuilderHost; }
        }

        public virtual void Init(IInternalConfigRoot configRoot, params object[] hostInitParams) {
            Host.Init(configRoot, hostInitParams);
        }

        public virtual void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, 
                IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams) {

            Host.InitForConfiguration(ref locationSubPath, out configPath, out locationConfigPath, configRoot, hostInitConfigurationParams);
        }

        public virtual bool IsConfigRecordRequired(string configPath) {
            return Host.IsConfigRecordRequired(configPath);
        }

        public virtual bool IsInitDelayed(IInternalConfigRecord configRecord) {
            return Host.IsInitDelayed(configRecord);
        }

        public virtual void RequireCompleteInit(IInternalConfigRecord configRecord) {
            Host.RequireCompleteInit(configRecord);
        }

        // IsSecondaryRoot
        //
        // Is this a secondary root.  This means that it is a node in which
        // everything that is defined in it should also be treated as a root.
        // So...if a factory record is defined that was already defined above
        // then throw since it is not allowed.
        //
        public virtual bool IsSecondaryRoot(string configPath) {
            return Host.IsSecondaryRoot(configPath);
        }

        public virtual string GetStreamName(string configPath) {
            return Host.GetStreamName(configPath);
        }

        public virtual string GetStreamNameForConfigSource(string streamName, string configSource) {
            return Host.GetStreamNameForConfigSource(streamName, configSource);
        }

        public virtual object GetStreamVersion(string streamName) {
            return Host.GetStreamVersion(streamName);
        }

        public virtual Stream OpenStreamForRead(string streamName) {
            return Host.OpenStreamForRead(streamName);
        }

        public virtual Stream OpenStreamForRead(string streamName, bool assertPermissions) {
            return Host.OpenStreamForRead(streamName, assertPermissions);
        }

        public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext) {
            return Host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext);
        }

        public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions) {
            return Host.OpenStreamForWrite(streamName, templateStreamName, ref writeContext, assertPermissions);
        }

        public virtual void WriteCompleted(string streamName, bool success, object writeContext) {
            Host.WriteCompleted(streamName, success, writeContext);
        }

        public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions) {
            Host.WriteCompleted(streamName, success, writeContext, assertPermissions);
        }

        public virtual void DeleteStream(string streamName) {
            Host.DeleteStream(streamName);
        }

        public virtual bool IsFile(string streamName) {
            return Host.IsFile(streamName);
        }

        public virtual bool SupportsChangeNotifications {
            get {
                return Host.SupportsChangeNotifications;
            }
        }

        public virtual object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {
            return Host.StartMonitoringStreamForChanges(streamName, callback);
        }

        public virtual void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {
            Host.StopMonitoringStreamForChanges(streamName, callback);
        }

        public virtual bool SupportsRefresh {
            get {
                return Host.SupportsRefresh;
            }
        }

        public virtual bool SupportsPath {
            get {
                return Host.SupportsPath;
            }
        }

        public virtual bool SupportsLocation {
            get {
                return Host.SupportsLocation;
            }
        }

        public virtual bool IsAboveApplication(string configPath) {
            return Host.IsAboveApplication(configPath);
        }

        public virtual bool IsDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition) {
            return Host.IsDefinitionAllowed(configPath, allowDefinition, allowExeDefinition);
        }

        public virtual void VerifyDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo) {
            Host.VerifyDefinitionAllowed(configPath, allowDefinition, allowExeDefinition, errorInfo);
        }

        public virtual string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath) {
            return Host.GetConfigPathFromLocationSubPath(configPath, locationSubPath);
        }

        public virtual bool IsLocationApplicable(string configPath) {
            return Host.IsLocationApplicable(configPath);
        }

        public virtual bool IsTrustedConfigPath(string configPath) {
            return Host.IsTrustedConfigPath(configPath);
        }

        public virtual bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord) {
            return Host.IsFullTrustSectionWithoutAptcaAllowed(configRecord);
        }

        public virtual void GetRestrictedPermissions(IInternalConfigRecord configRecord, out PermissionSet permissionSet, out bool isHostReady) {
            Host.GetRestrictedPermissions(configRecord, out permissionSet, out isHostReady);
        }

        public virtual IDisposable Impersonate() {
            return Host.Impersonate();
        }

        public virtual bool PrefetchAll(string configPath, string streamName) {
            return Host.PrefetchAll(configPath, streamName);
        }

        public virtual bool PrefetchSection(string sectionGroupName, string sectionName) {
            return Host.PrefetchSection(sectionGroupName, sectionName);
        }

        public virtual object CreateDeprecatedConfigContext(string configPath) {
            return Host.CreateDeprecatedConfigContext(configPath);
        }

        public virtual object 
        CreateConfigurationContext( string configPath, string locationSubPath ) 
        {
            return Host.CreateConfigurationContext( configPath, locationSubPath );
        }

        public virtual string DecryptSection(string encryptedXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection) {
            return Host.DecryptSection(encryptedXml, protectionProvider, protectedConfigSection);
        }

        public virtual string EncryptSection(string clearTextXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection) {
            return Host.EncryptSection(clearTextXml, protectionProvider, protectedConfigSection);
        }

        public virtual Type GetConfigType(string typeName, bool throwOnError) {
            return Host.GetConfigType(typeName, throwOnError);
        }

        public virtual string GetConfigTypeName(Type t) {
            return Host.GetConfigTypeName(t);
        }

        public virtual bool IsRemote {
            get {
                return Host.IsRemote;
            }
        }

        public virtual XmlNode ProcessRawXml(XmlNode rawXml, ConfigurationBuilder builder) {
            if (ConfigBuilderHost != null) {
                return ConfigBuilderHost.ProcessRawXml(rawXml, builder);
            }

            return rawXml;
        }

        public virtual ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection, ConfigurationBuilder builder) {
            if (ConfigBuilderHost != null) {
                return ConfigBuilderHost.ProcessConfigurationSection(configSection, builder);
            }

            return configSection;
        }

    }
}

