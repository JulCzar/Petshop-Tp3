using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.aplication {
  class Encrypt {
    public static string Sha256(string text) {
      using (SHA256 hash = SHA256.Create()) {
        byte[] textBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(text));

        StringBuilder builder = new();
        for (int i = 0; i < textBytes.Length; i++)
          builder.Append(textBytes[i].ToString("x2"));

        Console.WriteLine(builder.ToString());
        return builder.ToString();
      }
    }
  }
}
