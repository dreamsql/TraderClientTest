// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
// <OWNER>[....]</OWNER>
// 
 
//
// SHA1.cs 
//

namespace System.Security.Cryptography {
    [System.Runtime.InteropServices.ComVisible(true)] 
    public abstract class SHA1 : HashAlgorithm
    { 
        protected SHA1() { 
            HashSizeValue = 160;
        } 

        //
        // public methods
        // 

        [System.Security.SecuritySafeCritical]  // auto-generated 
        new static public SHA1 Create() { 
            return Create("System.Security.Cryptography.SHA1");
        } 

        [System.Security.SecuritySafeCritical]  // auto-generated
        new static public SHA1 Create(String hashName) {
            return (SHA1) CryptoConfig.CreateFromName(hashName); 
        }
    } 
} 


// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
// <OWNER>[....]</OWNER>
// 
 
//
// SHA1.cs 
//

namespace System.Security.Cryptography {
    [System.Runtime.InteropServices.ComVisible(true)] 
    public abstract class SHA1 : HashAlgorithm
    { 
        protected SHA1() { 
            HashSizeValue = 160;
        } 

        //
        // public methods
        // 

        [System.Security.SecuritySafeCritical]  // auto-generated 
        new static public SHA1 Create() { 
            return Create("System.Security.Cryptography.SHA1");
        } 

        [System.Security.SecuritySafeCritical]  // auto-generated
        new static public SHA1 Create(String hashName) {
            return (SHA1) CryptoConfig.CreateFromName(hashName); 
        }
    } 
} 


// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
