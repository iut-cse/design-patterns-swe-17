using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncryptionDecorator : DataSource
    {
        string encryptedData;
       
        public void writeData(string data)
        {
           encryptedData= data.ToLower();
           
        }

        public string readData()
        {
            return encryptedData;
        }
    }
}
