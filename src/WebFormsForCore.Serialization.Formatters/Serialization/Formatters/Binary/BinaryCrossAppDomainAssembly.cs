// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    internal sealed class BinaryCrossAppDomainAssembly : IStreamable
    {
        internal int _assemId;
        internal int _assemblyIndex;

        internal BinaryCrossAppDomainAssembly()
        {
        }

        public void Write(BinaryFormatterWriter output)
        {
            output.WriteByte((byte)BinaryHeaderEnum.CrossAppDomainAssembly);
            output.WriteInt32(_assemId);
            output.WriteInt32(_assemblyIndex);
        }

        public void Read(BinaryParser input)
        {
            _assemId = input.ReadInt32();
            _assemblyIndex = input.ReadInt32();
        }
    }
}
