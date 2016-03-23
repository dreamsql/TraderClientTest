// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*==============================================================================
** 
** Class: AccessViolationException 
**
** 
** Purpose: Exception class representing an AV that was deemed unsafe and may have corrupted the application.
**
**
=============================================================================*/ 

namespace System 
{ 

    using System; 
    using System.Runtime.Serialization;
    [System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class AccessViolationException : SystemException 
    {
        public AccessViolationException() 
            : base(Environment.GetResourceString("Arg_AccessViolationException")) 
        {
            SetErrorCode(__HResults.E_POINTER); 
        }

        public AccessViolationException(String message)
            : base(message) 
        {
            SetErrorCode(__HResults.E_POINTER); 
        } 

        public AccessViolationException(String message, Exception innerException) 
            : base(message, innerException)
        {
            SetErrorCode(__HResults.E_POINTER);
        } 

        [System.Security.SecuritySafeCritical]  // auto-generated 
        protected AccessViolationException(SerializationInfo info, StreamingContext context) : base(info, context) {} 

#pragma warning disable 169  // Field is not used from managed. 
        private IntPtr _ip;             // Address of faulting instruction.
        private IntPtr _target;         // Address that could not be accessed.
        private int _accessType;        // 0:read, 1:write
#pragma warning restore 169 

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
** Class: AccessViolationException 
**
** 
** Purpose: Exception class representing an AV that was deemed unsafe and may have corrupted the application.
**
**
=============================================================================*/ 

namespace System 
{ 

    using System; 
    using System.Runtime.Serialization;
    [System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class AccessViolationException : SystemException 
    {
        public AccessViolationException() 
            : base(Environment.GetResourceString("Arg_AccessViolationException")) 
        {
            SetErrorCode(__HResults.E_POINTER); 
        }

        public AccessViolationException(String message)
            : base(message) 
        {
            SetErrorCode(__HResults.E_POINTER); 
        } 

        public AccessViolationException(String message, Exception innerException) 
            : base(message, innerException)
        {
            SetErrorCode(__HResults.E_POINTER);
        } 

        [System.Security.SecuritySafeCritical]  // auto-generated 
        protected AccessViolationException(SerializationInfo info, StreamingContext context) : base(info, context) {} 

#pragma warning disable 169  // Field is not used from managed. 
        private IntPtr _ip;             // Address of faulting instruction.
        private IntPtr _target;         // Address that could not be accessed.
        private int _accessType;        // 0:read, 1:write
#pragma warning restore 169 

    } 
 
}

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.