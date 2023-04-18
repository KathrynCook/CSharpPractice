using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {           
      Console.WriteLine("Provide a secret message to encrypt: ");
      var message = Console.ReadLine().ToLower();
      char[] secretMessage = message.ToCharArray();
      
      var encrypted = Encrypt(secretMessage, 3);
      var decrypted = Decrypt(encrypted, 3);

      Console.WriteLine("Encypted message: " + String.Join("", encrypted));
      Console.WriteLine("Decrypted message: " + String.Join("", decrypted));
    }

    public static char[] Encrypt(char[] message, int key){
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char[] symbols = new char[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', ',', '.', '?', '/', '~', ' '};
      char[] encryptedMessage = new char[message.Length];

      for (var i = 0; i < message.Length; i++){
        if(Array.IndexOf(symbols, message[i]) != -1) {
          encryptedMessage[i] = message[i];
        }
        else {
          var letter = message[i];
          var letterIndex = Array.IndexOf(alphabet, letter);
          letterIndex = (letterIndex + key) % 26;
          var letterEncrypted = alphabet[letterIndex];
          encryptedMessage[i] = letterEncrypted;
        }
      }
      return encryptedMessage;
    }

    public static char[] Decrypt(char[] message, int key){
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char[] symbols = new char[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', ',', '.', '?', '/', '~', ' '};
      char[] decryptedMessage = new char[message.Length];

      for (var i = 0; i < message.Length; i++){
        if(Array.IndexOf(symbols, message[i]) != -1) {
          decryptedMessage[i] = message[i];
        }
        else {
          var letter = message[i];
          var letterIndex = Array.IndexOf(alphabet, letter);
          letterIndex = (letterIndex - key) % 26;
          var letterDecrypted = alphabet[letterIndex];
          decryptedMessage[i] = letterDecrypted;
        }
      }
      return decryptedMessage;
    }
  }
}