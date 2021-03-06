// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*==============================================================================
** 
** Class: DllNotFoundException 
**
** 
** Purpose: The exception class for some failed P/Invoke calls.
**
**
=============================================================================*/ 

namespace System { 
 
    using System;
    using System.Runtime.Serialization; 

[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable] public class DllNotFoundException : TypeLoadException {
        public DllNotFoundException() 
            : base(Environment.GetResourceString("Arg_DllNotFoundException")) {
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND); 
        } 

        public DllNotFoundException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND);
        }
 
        public DllNotFoundException(String message, Exception inner)
            : base(message, inner) { 
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND); 
        }
 
        [System.Security.SecuritySafeCritical]  // auto-generated
        protected DllNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
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
** Class: DllNotFoundException 
**
** 
** Purpose: The exception class for some failed P/Invoke calls.
**
**
=============================================================================*/ 

namespace System { 
 
    using System;
    using System.Runtime.Serialization; 

[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable] public class DllNotFoundException : TypeLoadException {
        public DllNotFoundException() 
            : base(Environment.GetResourceString("Arg_DllNotFoundException")) {
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND); 
        } 

        public DllNotFoundException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND);
        }
 
        public DllNotFoundException(String message, Exception inner)
            : base(message, inner) { 
            SetErrorCode(__HResults.COR_E_DLLNOTFOUND); 
        }
 
        [System.Security.SecuritySafeCritical]  // auto-generated
        protected DllNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    } 
}

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
