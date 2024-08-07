// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    // When an ObjectWithMap or an ObjectWithMapTyped is read off the stream, an ObjectMap class is created
    // to remember the type information.
    internal sealed class ObjectMap
    {
        internal string _objectName;
        internal Type? _objectType;

        internal BinaryTypeEnum[] _binaryTypeEnumA;
        internal object?[] _typeInformationA;
        internal Type?[] _memberTypes;
        internal string[] _memberNames;
        internal ReadObjectInfo _objectInfo;
        internal bool _isInitObjectInfo = true;
        internal ObjectReader? _objectReader;
        internal int _objectId;
        internal BinaryAssemblyInfo _assemblyInfo;

        internal ObjectMap(
            string objectName,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type objectType,
            string[] memberNames,
            ObjectReader objectReader,
            int objectId,
            BinaryAssemblyInfo assemblyInfo)
        {
            _objectName = objectName;
            _objectType = objectType;
            _memberNames = memberNames;
            _objectReader = objectReader;
            _objectId = objectId;
            _assemblyInfo = assemblyInfo;

            _objectInfo = objectReader.CreateReadObjectInfo(objectType);
            _memberTypes = _objectInfo.GetMemberTypes(memberNames, objectType)!;

            _binaryTypeEnumA = new BinaryTypeEnum[_memberTypes.Length];
            _typeInformationA = new object[_memberTypes.Length];

            for (int i = 0; i < _memberTypes.Length; i++)
            {
                BinaryTypeEnum binaryTypeEnum = BinaryTypeConverter.GetParserBinaryTypeInfo(_memberTypes[i]!, out object? typeInformation);
                _binaryTypeEnumA[i] = binaryTypeEnum;
                _typeInformationA[i] = typeInformation;
            }
        }

        [RequiresUnreferencedCode("Types might be removed")]
        internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object?[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
        {
            _objectName = objectName;
            _memberNames = memberNames;
            _binaryTypeEnumA = binaryTypeEnumA;
            _typeInformationA = typeInformationA;
            _objectReader = objectReader;
            _objectId = objectId;
            _assemblyInfo = assemblyInfo;

            if (assemblyInfo == null)
            {
                throw new SerializationException(SR.Format(SR.Serialization_Assembly, objectName));
            }

            _objectType = objectReader.GetType(assemblyInfo, objectName);
            _memberTypes = new Type[memberNames.Length];

            for (int i = 0; i < memberNames.Length; i++)
            {
                BinaryTypeConverter.TypeFromInfo(
                    binaryTypeEnumA[i], typeInformationA[i], objectReader, (BinaryAssemblyInfo?)assemIdToAssemblyTable[memberAssemIds[i]],
                    out _, out _, out Type? type, out _);
                _memberTypes[i] = type;
            }

            _objectInfo = objectReader.CreateReadObjectInfo(_objectType, memberNames, null);
            if (!_objectInfo._isSi)
            {
                _objectInfo.GetMemberTypes(memberNames, _objectInfo._objectType);  // Check version match
            }
        }

        internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo? si, ref object?[]? memberData)
        {
            if (_isInitObjectInfo)
            {
                _isInitObjectInfo = false;
                _objectInfo.InitDataStore(ref si, ref memberData);
                return _objectInfo;
            }
            else
            {
                _objectInfo.PrepareForReuse();
                _objectInfo.InitDataStore(ref si, ref memberData);
                return _objectInfo;
            }
        }

        // No member type information
        internal static ObjectMap Create(
            string name,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type objectType,
            string[] memberNames,
            ObjectReader objectReader,
            int objectId,
            BinaryAssemblyInfo assemblyInfo) =>
            new ObjectMap(name, objectType, memberNames, objectReader, objectId, assemblyInfo);

        // Member type information
        [RequiresUnreferencedCode("Types might be removed")]
        internal static ObjectMap Create(
            string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object?[] typeInformationA,
            int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) =>
            new ObjectMap(name, memberNames, binaryTypeEnumA, typeInformationA, memberAssemIds, objectReader, objectId, assemblyInfo, assemIdToAssemblyTable);
    }
}
