using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4earth_GabrielD_1703749
{
    public class Login
    {
        private int length;

        public int ID { get { return ID; } set { ID = value; } }
        public string User_Name { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get => senha; set => senha = value; }

        public Login() { }

        //Tentativa Gerar Hash -- Abstract(N/A) Mother Class
         public string Encripto(String senhamain)
        {
               byte[] bytesSenhamain;
               byte[] codificar;
               MD5 mD5;

               mD5 = new MD5CryptoServiceProvider();
               bytesSenhamain = ASCIIEncoding.Default.GetBytes(senhamain);
               codificar = mD5.ComputeHash(bytesSenhamain);
               return BitConverter.ToString(codificar);
        }


        public void EfetuarCadastro()

        {

        }
    }
}
