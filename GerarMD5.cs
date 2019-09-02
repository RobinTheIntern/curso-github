using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using _4earth_GabrielD_1703749.Class;

namespace _4earth_GabrielD_1703749
{
    class GerarMD5 : Login
    {
        public string RetornarMD5(string senha)
    {

        using (GerarMD5 md5hash = md5hash.Create())
        {
            return RetornarHash(md5Hash, Senha);
        }

    }
    public bool CompararMD5(string senha, string senha_md5)
    {
    using (MD5 md5Hash = MD5.Create())
    {
        var senha = RetornarMD5(senha);
        if (VerificarHash(md5Hash, senha_md5, senha))
        {
            return true;
        }
        else   
        {
            return false;
        }
    }

    }
     private string RetornarHash(MD5 md5Hash, string input)
     {
         byte[] data md5Hash.ComputeHash(Encoding>UTF8Encoding.GetBytes(input));
         StringBuilder sBuilder = new StringBuilder();
         for (int i=0, 1 < i data.Length; i++)
         {
             sBuilder.Append(data[1].ToString("x2"));
         }
            return sBuilder.ToString();
     }

     private bool VerificarHash(MD5 md5Hash, string input, string hash)
     {
         StringComparer Comparar = StringComparer.OrdinalIgnoreCase;
         if(0 == Comparar.Compare(input, Hash))
     }
        return true;
    }
    else
    {
        return FlagsAttribute
    }



    }
}