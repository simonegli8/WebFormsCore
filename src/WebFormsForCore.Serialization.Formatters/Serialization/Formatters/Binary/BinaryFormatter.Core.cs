// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    public sealed partial class BinaryFormatter : IFormatter
    {

		internal const string RequiresUnreferencedCodeMessage = "BinaryFormatter serialization is not trim compatible because the Type of objects being processed cannot be statically discovered.";

#if !Legacy
        [Obsolete(Obsoletions.BinaryFormatterMessage, DiagnosticId = Obsoletions.BinaryFormatterDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
#endif
		[RequiresUnreferencedCode(RequiresUnreferencedCodeMessage)]

        public object Deserialize(Stream serializationStream)
        {
            // don't refactor the 'throw' into a helper method; linker will have difficulty trimming
            if (!LocalAppContextSwitches.BinaryFormatterEnabled)
            {
                throw new NotSupportedException(SR.BinaryFormatter_SerializationDisallowed);
            }

            ArgumentNullException.ThrowIfNull(serializationStream);

            if (serializationStream.CanSeek && (serializationStream.Length == 0))
            {
                throw new SerializationException(SR.Serialization_Stream);
            }

            var formatterEnums = new InternalFE()
            {
                _typeFormat = _typeFormat,
                _serializerTypeEnum = InternalSerializerTypeE.Binary,
                _assemblyFormat = _assemblyFormat,
                _securityLevel = _securityLevel,
            };

            var reader = new ObjectReader(serializationStream, _surrogates, _context, formatterEnums, _binder)
            {
                _crossAppDomainArray = _crossAppDomainArray
            };
            try
            {
                BinaryFormatterEventSource.Log.DeserializationStart();
                var parser = new BinaryParser(serializationStream, reader);
                return reader.Deserialize(parser);
            }
            catch (SerializationException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new SerializationException(SR.Serialization_CorruptedStream, e);
            }
            finally
            {
                BinaryFormatterEventSource.Log.DeserializationStop();
            }
        }

#if !Legacy
        [Obsolete(Obsoletions.BinaryFormatterMessage, DiagnosticId = Obsoletions.BinaryFormatterDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
#endif
		[RequiresUnreferencedCode(RequiresUnreferencedCodeMessage)]

        public void Serialize(Stream serializationStream, object graph)
        {
            // don't refactor the 'throw' into a helper method; linker will have difficulty trimming
            if (!LocalAppContextSwitches.BinaryFormatterEnabled)
            {
                throw new NotSupportedException(SR.BinaryFormatter_SerializationDisallowed);
            }

            ArgumentNullException.ThrowIfNull(serializationStream);

            var formatterEnums = new InternalFE()
            {
                _typeFormat = _typeFormat,
                _serializerTypeEnum = InternalSerializerTypeE.Binary,
                _assemblyFormat = _assemblyFormat,
            };

            try
            {
                BinaryFormatterEventSource.Log.SerializationStart();
                var sow = new ObjectWriter(_surrogates, _context, formatterEnums, _binder);
                BinaryFormatterWriter binaryWriter = new BinaryFormatterWriter(serializationStream, sow, _typeFormat);
                sow.Serialize(graph, binaryWriter);
                _crossAppDomainArray = sow._crossAppDomainArray;
            }
            finally
            {
                BinaryFormatterEventSource.Log.SerializationStop();
            }
        }
    }
}
