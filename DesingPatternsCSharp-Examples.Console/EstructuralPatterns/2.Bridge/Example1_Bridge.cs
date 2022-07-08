using bridge.encript;
using bridge.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class Example1_Bridge
    {
        public void Run()
        {
            IMessageEncrypt aesImpl = new DefaultMessageEncryptImpl(
                    new AESEncryptAlgorithm());
            IMessageEncrypt desImpl = new DefaultMessageEncryptImpl(
                    new DESEncryptAlgorithm());
            IMessageEncrypt noImpl = new DefaultMessageEncryptImpl(
                    new NoEncryptAlgorithm());

            try
            {
                string message = "<Person><Name>Oscar Blancarte</Name></Person>";
                string messageAES = aesImpl.EncryptMessage(message, "HG58YZ3CR9123456");
                Console.WriteLine("messageAES > " + messageAES + "\n");

                string messageDES = desImpl.EncryptMessage(message, "XMzDdG4D03CKm2Ix");
                Console.WriteLine("messageDES > " + messageDES + "\n");

                string messageNO = noImpl.EncryptMessage(message, null);
                Console.WriteLine("messageNO > " + messageNO + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
