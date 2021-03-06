// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*==============================================================================
** 
** Class: InsufficientExecutionStackException 
**
** 
** Purpose: The exception class used when there is insufficient execution stack
**          to allow most Framework methods to execute.
**
** 
=============================================================================*/
 
namespace System { 

    using System; 
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class InsufficientExecutionStackException : SystemException 
    {
        public InsufficientExecutionStackException() 
            : base(Environment.GetResourceString("Arg_InsufficientExecutionStackException")) 
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK); 
        }

        public InsufficientExecutionStackException(String message)
            : base(message) 
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK); 
        } 

        public InsufficientExecutionStackException(String message, Exception innerException) 
            : base(message, innerException)
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK);
        } 

        private InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) 
            : base(info, context) 
        {
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
** Class: InsufficientExecutionStackException 
**
** 
** Purpose: The exception class used when there is insufficient execution stack
**          to allow most Framework methods to execute.
**
** 
=============================================================================*/
 
namespace System { 

    using System; 
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class InsufficientExecutionStackException : SystemException 
    {
        public InsufficientExecutionStackException() 
            : base(Environment.GetResourceString("Arg_InsufficientExecutionStackException")) 
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK); 
        }

        public InsufficientExecutionStackException(String message)
            : base(message) 
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK); 
        } 

        public InsufficientExecutionStackException(String message, Exception innerException) 
            : base(message, innerException)
        {
            SetErrorCode(__HResults.COR_E_INSUFFICIENTEXECUTIONSTACK);
        } 

        private InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) 
            : base(info, context) 
        {
        } 

    }
}

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
