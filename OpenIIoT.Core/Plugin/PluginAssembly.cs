﻿namespace OpenIIoT.Core.Plugin
{
    using System;
    using System.Reflection;
    using OpenIIoT.SDK.Plugin;

    /// <summary>
    ///     The PluginAssembly class represents a plugin for which the assembly file has been loaded.
    /// </summary>
    public class PluginAssembly : IPlugin, IPluginAssembly
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PluginAssembly"/> class.
        /// </summary>
        /// <param name="name">The name of the Plugin.</param>
        /// <param name="fqn">The Fully Qualified Name of the Plugin.</param>
        /// <param name="version">The version of the Plugin.</param>
        /// <param name="pluginType">The type of Plugin.</param>
        /// <param name="fingerprint">The cryptographic fingerprint of the Plugin.</param>
        /// <param name="type">The Type of the Plugin contained within the Plugin assembly.</param>
        /// <param name="assembly">The Plugin assembly.</param>
        public PluginAssembly(string name, string fqn, string version, PluginType pluginType, string fingerprint, Type type, Assembly assembly)
        {
            Name = name;
            FQN = fqn;
            Version = Version;
            PluginType = pluginType;
            Fingerprint = fingerprint;
            Type = type;
            Assembly = assembly;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        ///     Gets the Plugin assembly.
        /// </summary>
        public Assembly Assembly { get; private set; }

        /// <summary>
        ///     Gets the cryptographic fingerprint of the Plugin.
        /// </summary>
        /// <remarks>
        ///     The SHA256 checksum of the Plugin assembly hashed again using the SHA256 algorithm and salted with the FQN + Version.
        /// </remarks>
        public string Fingerprint { get; private set; }

        /// <summary>
        ///     Gets the Fully Qualified Name of the Plugin.
        /// </summary>
        public string FQN { get; private set; }

        /// <summary>
        ///     Gets the name of the Plugin.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the type of Plugin.
        /// </summary>
        public PluginType PluginType { get; private set; }

        /// <summary>
        ///     Gets the Type of the Plugin contained within the Plugin assembly.
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        ///     Gets the version of the Plugin.
        /// </summary>
        /// <remarks>
        ///     Formatting is discretionary. Any comparisons between versions will be "equals" rather than greater than/less than.
        /// </remarks>
        public string Version { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public void SetFingerprint(string fingerprint)
        {
            Fingerprint = fingerprint;
        }

        #endregion Public Methods
    }
}