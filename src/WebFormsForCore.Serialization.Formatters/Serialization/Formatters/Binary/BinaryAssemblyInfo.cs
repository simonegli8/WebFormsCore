// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    internal sealed class BinaryAssemblyInfo
    {
        internal string _assemblyString;
        private Assembly? _assembly;

        internal BinaryAssemblyInfo(string assemblyString)
        {
            _assemblyString = assemblyString;
        }

        internal BinaryAssemblyInfo(string assemblyString, Assembly? assembly) : this(assemblyString)
        {
            _assembly = assembly;
        }

        internal Assembly GetAssembly()
        {
            if (_assembly == null)
            {
                _assembly = FormatterServices.LoadAssemblyFromStringNoThrow(_assemblyString);
                if (_assembly == null)
                {
                    throw new SerializationException(SR.Format(SR.Serialization_AssemblyNotFound, _assemblyString));
                }
            }
            return _assembly;
        }
    }
}
