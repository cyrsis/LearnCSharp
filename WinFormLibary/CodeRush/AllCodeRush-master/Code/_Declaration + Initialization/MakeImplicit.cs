using System;
using System.IO;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————•
      Feature: Make Implicit
        
      Use Case: Converts an explicitly-typed local variable 
      to a variable with an implicit type.
         
      Available: When the caret is on an explicit variable 
      declaration.
        
      See also: Make Explicit
     •———————————————————————————————————————————————————————• */

  public class MakeImplicit
	{
    public void SaveWithRestrictedAccess(string fileName, byte[] decryptedXML)
    {
      FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
      fileStream.Write(decryptedXML, 0, decryptedXML.Length);
      fileStream.Close();
    

      // Consider using implicit variable declaration on the following line:
      System.Security.AccessControl.FileSecurity fileSecurity = new System.Security.AccessControl.FileSecurity();


      AllowFullAccess(fileSecurity);
      File.SetAccessControl(fileName, fileSecurity);
    }
  
    private static void AllowFullAccess(System.Security.AccessControl.FileSecurity fileSecurity)
    {
      fileSecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule("Everyone", System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));
    }
  }
}
