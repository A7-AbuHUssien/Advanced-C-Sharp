
// You Can Hash but You Can't return it to Original Value => (One-Way-Function)
// Hash Create Fixed Size <string> 
// SHA-256 => Secure Hash Algorithm - 256 bit
// Library => System.Security.Cryptography


using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {

        string input = "Ahmedesam90";

        HashAlgorithm hashAlg = SHA256.Create();                         // Declare The Hashing Algorithm

        byte[] inputbytes = Encoding.UTF8.GetBytes(input);               // Convert input to bytes
        byte[] hashbytes = hashAlg.ComputeHash(inputbytes);              // Convert inputBytes to Hashed Bytes

        StringBuilder sb = new StringBuilder();                          // Declare String
        foreach (byte b in hashbytes ) sb.Append(b.ToString("x2"));      // Convert each byte to 2x string
       
        Console.WriteLine(sb.ToString());
       
    }
    
    static string ComputeHash(string input, string algorithm)
    {
        HashAlgorithm hashAlg;

        switch (algorithm.ToUpper())
        {
            case "SHA256":
                hashAlg = SHA256.Create();
                break;
            case "SHA1":
                hashAlg = SHA1.Create();
                break;
            case "MD5":
                hashAlg = MD5.Create();
                break;
            default:
                throw new ArgumentException("NOT Supported Alorithm");
        }

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashBytes = hashAlg.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
            sb.Append(b.ToString("x2")); // تحويل كل بايت إلى نص Hex

        return sb.ToString();
    }

    static byte[] ComputeHashAsBytes(string input, string algorithm)
    {
        HashAlgorithm hashAlg;

        switch (algorithm.ToUpper())
        {
            case "SHA256":
                hashAlg = SHA256.Create();
                break;
            case "SHA1":
                hashAlg = SHA1.Create();
                break;
            case "MD5":
                hashAlg = MD5.Create();
                break;
            default:
                throw new ArgumentException("خوارزمية غير مدعومة.");
        }

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        return hashAlg.ComputeHash(inputBytes);
    }
    
}
