// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    internal sealed class BinaryCrossAppDomainMap : IStreamable
    {
        internal int _crossAppDomainArrayIndex;

        public void Write(BinaryFormatterWriter output)
        {
            output.WriteByte((byte)BinaryHeaderEnum.CrossAppDomainMap);
            output.WriteInt32(_crossAppDomainArrayIndex);
        }

        public void Read(BinaryParser input)
        {
            _crossAppDomainArrayIndex = input.ReadInt32();
        }
    }
}
