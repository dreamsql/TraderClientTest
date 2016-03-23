// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*==============================================================================
** 
** Class: NullReferenceException 
**
** 
** Purpose: Exception class for dereferencing a null reference.
**
**
=============================================================================*/ 

namespace System { 
 
    using System;
    using System.Runtime.Serialization; 
[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class NullReferenceException : SystemException {
        public NullReferenceException() 
            : base(Environment.GetResourceString("Arg_NullReferenceException")) {
            SetErrorCode(__HResults.COR_E_NULLREFERENCE); 
        } 

        public NullReferenceException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_NULLREFERENCE);
        }
 
        public NullReferenceException(String message, Exception innerException)
            : base(message, innerException) { 
            SetErrorCode(__HResults.COR_E_NULLREFERENCE); 
        }
 
        [System.Security.SecuritySafeCritical]  // auto-generated
        protected NullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context) {}

    } 

} 

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*==============================================================================
** 
** Class: NullReferenceException 
**
** 
** Purpose: Exception class for dereferencing a null reference.
**
**
=============================================================================*/ 

namespace System { 
 
    using System;
    using System.Runtime.Serialization; 
[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class NullReferenceException : SystemException {
        public NullReferenceException() 
            : base(Environment.GetResourceString("Arg_NullReferenceException")) {
            SetErrorCode(__HResults.COR_E_NULLREFERENCE); 
        } 

        public NullReferenceException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_NULLREFERENCE);
        }
 
        public NullReferenceException(String message, Exception innerException)
            : base(message, innerException) { 
            SetErrorCode(__HResults.COR_E_NULLREFERENCE); 
        }
 
        [System.Security.SecuritySafeCritical]  // auto-generated
        protected NullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context) {}

    } 

} 

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.