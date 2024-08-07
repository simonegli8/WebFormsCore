// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
 /*============================================================
 **
 ** Class: ISoapMessage
 **
 **
 ** Purpose: Interface For Soap Method Call
 **
 **
 ===========================================================*/
#if WebFormsForCore || FEATURE_REMOTING || MOBILE_LEGACY
#nullable disable
namespace System.Runtime.Serialization.Formatters.Legacy {

    using System.Runtime.Remoting;
    using System.Runtime.Serialization;
    using System.Runtime.Remoting.Messaging.Legacy;    
    using System;
    // Used to specify a call record to either the binary or xml serializer
    // The call record can be transmitted as the SOAP Top record which contains
    // a method name instead of an object name as the Top record's element name
[System.Runtime.InteropServices.ComVisible(true)]
    public interface ISoapMessage
    {
        // Name of parameters, if null the default param names will be used

        String[] ParamNames {get; set;}
    
        // Parameter Values
        Object[] ParamValues {get; set;}

        // Parameter Types
        Type[] ParamTypes {get; set;}        
    
        // MethodName
        String MethodName {get; set;}

        // MethodName XmlNameSpace
        String XmlNameSpace {get; set;}

        // Headers
        Header[] Headers {get; set;}
    }
}
#endif // FEATURE_REMOTING

