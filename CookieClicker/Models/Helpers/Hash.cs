using System;
using System.Text;
using System.Security.Cryptography;

namespace CookieClicker.Models.Helpers
{
    public class Hash
    {
        private readonly byte[] _entropy = { 1, 2, 3, 4, 5, 6 }; //the entropy
        private string Encrypt(string text)
        {
            // first, convert the text to byte array 
            byte[] originalText = Encoding.Unicode.GetBytes(text);

            // then use Protect() to encrypt your data 
            byte[] encryptedText = ProtectedData.Protect(originalText, _entropy, DataProtectionScope.CurrentUser);

            //and return the encrypted message 
            return Convert.ToBase64String(encryptedText);
        }

        private string Decrypt(string text)
        {
            // the encrypted text, converted to byte array 
            byte[] encryptedText = Convert.FromBase64String(text);

            // calling Unprotect() that returns the original text 
            byte[] originalText = ProtectedData.Unprotect(encryptedText, _entropy, DataProtectionScope.CurrentUser);

            // finally, returning the result 
            return Encoding.Unicode.GetString(originalText);
        }
    }
}
