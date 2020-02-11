using System;
using System.Collections.Generic;

using System.Text;

namespace Bsoft.Common
{
    public class clsEncryptorDecryptor
        {
        
            private string password = "Bsoft";
            private System.Byte[] saltByte = System.Text.Encoding.ASCII.GetBytes("CMSSystem");

            private System.Byte[] keyByte = null;
            private System.Byte[] IVByte = null;

            private System.Security.Cryptography.RijndaelManaged myrijManaged;



            private void GenerateIVandKey()
            {
                System.Security.Cryptography.Rfc2898DeriveBytes myDeriveBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(password, saltByte);
                keyByte = myDeriveBytes.GetBytes(myrijManaged.KeySize / 8);
                IVByte = myDeriveBytes.GetBytes(myrijManaged.BlockSize / 8);
            }

            public string Decrypt(string CypherText)
            {
                string outText = string.Empty;
                System.Security.Cryptography.CryptoStream myCryptoStream = null;
                try
                {
                    System.Byte[] data = System.Convert.FromBase64String(CypherText);
                    System.IO.MemoryStream memStream = new System.IO.MemoryStream(data.Length);

                    myrijManaged.Key = keyByte;
                    myrijManaged.IV = IVByte;
                    System.Security.Cryptography.ICryptoTransform myCryptoTransform = myrijManaged.CreateDecryptor();
                    myCryptoStream = new System.Security.Cryptography.CryptoStream(memStream, myCryptoTransform, System.Security.Cryptography.CryptoStreamMode.Read);

                    memStream.Write(data, 0, data.Length);
                    memStream.Position = 0;
                    outText = new System.IO.StreamReader(myCryptoStream).ReadToEnd();

                }
                catch (Exception exp)
                {
                    throw exp;
                }
                finally
                {
                    if (myCryptoStream != null)
                        myCryptoStream.Close();
                }
                return outText;


            }

            public string Encrypt(string Text)
            {
                string outText = string.Empty;
                System.Security.Cryptography.CryptoStream myCryptoStream = null;
                try
                {
                    System.Byte[] bufferRead = System.Text.Encoding.ASCII.GetBytes(Text);
                    System.IO.MemoryStream myOutMemStream = new System.IO.MemoryStream(1024);


                    myrijManaged.Key = keyByte;
                    myrijManaged.IV = IVByte;
                    System.Security.Cryptography.ICryptoTransform myCryptoTransform = myrijManaged.CreateEncryptor();
                    myCryptoStream = new System.Security.Cryptography.CryptoStream(myOutMemStream, myCryptoTransform, System.Security.Cryptography.CryptoStreamMode.Write);
                    myCryptoStream.Write(bufferRead, 0, bufferRead.Length);
                    myCryptoStream.FlushFinalBlock();
                    System.Byte[] result = new byte[(int)myOutMemStream.Position];
                    myOutMemStream.Position = 0;
                    myOutMemStream.Read(result, 0, result.Length);
                    outText = System.Convert.ToBase64String(result);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
                finally
                {
                    if (myCryptoStream != null)
                        myCryptoStream.Close();

                }

                return outText;

            }




            public clsEncryptorDecryptor()
            {
                myrijManaged = new System.Security.Cryptography.RijndaelManaged();
                GenerateIVandKey();
            }
        }
    
}
