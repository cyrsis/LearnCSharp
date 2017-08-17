using System;
using System.Security.Cryptography;

namespace AllCodeRush.Code.Methods
{
  /* •————————————————————————————————————————————————————————•
      Feature: Make Extension
          
      Use Case: Creates an extension method for active method 
      based on one of that method's parameters.
           
      Available: When the caret is at a method declaration 
      having no other dependencies.
     •————————————————————————————————————————————————————————• */

  public class MakeExtension
  {
    public void TestEncryption(string testStr, string key)
    {
      string roundTrip = Decrypt(Encrypt(testStr, key), key);

      if (roundTrip != testStr)
        throw new Exception("Encryption failed!");
    }

    private string Encrypt(string str, string key)
    {
      if (string.IsNullOrEmpty(str))
        throw new ArgumentException("Empty strings cannot be encrypted.");

      if (string.IsNullOrEmpty(key))
        throw new ArgumentException("Encryption key must be supplied.");

      CspParameters cspArgs = new CspParameters() { KeyContainerName = key };
      using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspArgs) { PersistKeyInCsp = true })
        return BitConverter.ToString(rsa.Encrypt(System.Text.UTF8Encoding.UTF8.GetBytes(str), true));
    }

    private string Decrypt(string str, string key)
    {
      if (string.IsNullOrEmpty(str))
        throw new ArgumentException("Empty strings cannot be decrypted");

      if (string.IsNullOrEmpty(key))
        throw new ArgumentException("Decryption key must be supplied.");

      using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(new CspParameters() { KeyContainerName = key }))
      {
        rsa.PersistKeyInCsp = true;
        string[] decryptArray = str.Split(new string[] { "-" }, StringSplitOptions.None);
        byte[] decryptByteArray = Array.ConvertAll<string, byte>(decryptArray, (s => Convert.ToByte(byte.Parse(s, System.Globalization.NumberStyles.HexNumber))));
        return System.Text.UTF8Encoding.UTF8.GetString(rsa.Decrypt(decryptByteArray, true));
      }
    }
  }
}
