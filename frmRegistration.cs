using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography; 

namespace KnPictureViewer
{
    public partial class frmRegistration : Form
    {

        private const string GUID_APP_KEY = "FEF9FB7E-EF4F-4820-B96A-20414ECE9E72";


        public frmRegistration()
        {
            InitializeComponent();
        }

        private bool ValidateFirstName()
        {
            bool bStatus = true;
            if (txtFirstName.Text == "")
            {
                errValidator.SetError(txtFirstName, "Please enter your First Name");
                lblFirstName.BackColor = Color.Red;

                bStatus = false;
            }
            else
            {
                errValidator.SetError(txtFirstName, "");
                lblFirstName.BackColor = Color.Transparent;
            }
            return bStatus;
        }

        private bool ValidateLastName()
        {
            bool bStatus = true;
            if (txtLastName.Text == "")
            {
                errValidator.SetError(txtLastName, "Please enter your Last Name");
                lblLastName.BackColor = Color.Red;
                bStatus = false;
            }
            else
            {
                errValidator.SetError(txtLastName, "");
                lblLastName.BackColor = Color.Transparent;
            }
            return bStatus;
        }

        private bool ValidatEmail()
        {
            bool bStatus = true;
            if (txtEmail.Text == "")
            {
                errValidator.SetError(txtEmail, "Please enter a valid E-mail Address");
                lblEmail.BackColor = Color.Red;
                bStatus = false;
            }
            else
            {
                errValidator.SetError(txtEmail, "");
                lblEmail.BackColor = Color.Transparent;
            }
            return bStatus;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool checkData = false;
            idnClient obj = new idnClient();

            string[] arrReg = new string[13];

            checkData = ValidateFirstName();
            if (checkData == false)
                goto Finish;


            arrReg[0] = txtFirstName.Text;

            
            checkData = ValidateLastName();
            if (checkData == false)
                goto Finish;

            arrReg[1] = txtLastName.Text;

            checkData = ValidatEmail();
            if (checkData == false)
                goto Finish;
            
            arrReg[2] = txtEmail.Text;

            arrReg[3] = txtCompany.Text;
            arrReg[4] = txtAddress1.Text;
            arrReg[5] = txtAddress2.Text;
            arrReg[6] = txtCity.Text;

            arrReg[7] = txtZipCode.Text;
            arrReg[8] = txtState.Text;
            arrReg[9] = txtCountry.Text;
            arrReg[10] = txtPhone.Text;

            arrReg[11] = obj.strCpuDetails;
            arrReg[12] = obj.strDriveDetails;


            encData enc = new encData();
            string encStr = string.Empty;

            encStr = enc.stringEncrypt("fsdjfhsjdhfj skjfhsdjkhf jkdsh fjdhfkjhdsjfh kjsdfkjdshfkjhdhdfhsdjhfjksdhfsdhhsdkhsdjkfhkjsdhfjksd fsdjfhsjdhfj skjfhsdjkhf jkdsh fjdhfkjhdsjfh kjsdfkjdshfkjhdhdfhsdjhfjksdhfsdhhsdkhsdjkfhkjsdhfjksd fsdjfhsjdhfj skjfhsdjkhf jkdsh fjdhfkjhdsjfh kjsdfkjdshfkjhdhdfhsdjhfjksdhfsdhhsdkhsdjkfhkjsdhfjksd", true, GUID_APP_KEY);
            txtEncrypt.Text = encStr;

            string decryptStr = string.Empty;

            decryptStr = enc.stringDecrypt(txtEncrypt.Text, true, GUID_APP_KEY);
            txtText.Text = decryptStr;

            Finish:
                int i = 0;
                

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
}

    public class encData
    {
        public encData() { }

        public string stringEncrypt(string ToEncrypt, bool useHasing, string Key)         
        {             
                    byte[] keyArray;             
                    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(ToEncrypt);             
                    //System.Configuration.AppSettingsReader settingsReader = new     AppSettingsReader();            
                   // string Key = "Bhagwati";             
                    if (useHasing)             
                    {                 
                        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();                 
                        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));                 
                        hashmd5.Clear();               
                    }            
                    else             
                    {                 
                        keyArray = UTF8Encoding.UTF8.GetBytes(Key);             
                    }             
                    TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();             
                    tDes.Key = keyArray;             
                    tDes.Mode = CipherMode.ECB;             
                    tDes.Padding = PaddingMode.PKCS7;            
                    ICryptoTransform cTransform = tDes.CreateEncryptor();             
                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);             
                    tDes.Clear();   
         
                    return (Convert.ToBase64String(resultArray, 0, resultArray.Length));
        } 

        public string stringDecrypt(string cypherString, bool useHasing, string key)         
        {
            string sError = string.Empty;
 
            byte[] keyArray;             
            byte[] toDecryptArray = Convert.FromBase64String(cypherString);             
            //byte[] toEncryptArray = Convert.FromBase64String(cypherString);            
            //System.Configuration.AppSettingsReader settingReader = new     AppSettingsReader();             
            
            //string key = "Bhagwati";             
            if (useHasing)             
            {                 
                MD5CryptoServiceProvider hashmd = new MD5CryptoServiceProvider();                 
                keyArray = hashmd.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));                 
                hashmd.Clear();             
            }             
            else             
            {                 
                keyArray = UTF8Encoding.UTF8.GetBytes(key);             
            }             
            
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();             
            tDes.Key = keyArray;             
            tDes.Mode = CipherMode.ECB;             
            tDes.Padding = PaddingMode.PKCS7;             
            ICryptoTransform cTransform = tDes.CreateDecryptor();             
            
            try             
            {                 
                byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);                  
                tDes.Clear();                 
                
                sError = UTF8Encoding.UTF8.GetString(resultArray,0,resultArray.Length);             
            }             
            catch (Exception ex)             
            {
                sError =  ex.Message;              
            }

            return (sError);
        } 

    }


    public class idnClient
    {

        public idnClient() { }

        private const string WIN32_PROCESSOR = "win32_processor";
        private const string PROCESSOR_ID = "processorID";
        private const string ERR = "ERROR25";
        private const string DRIVE_C = "C";
        private const string VOLUME_C = "VolumeSerialNumber";
        
        // private string _strCpuDetails;

        public string strDriveDetails
        {
            get
            {
                string strID = string.Empty;

                try
                {

                    ManagementObject dsk = new ManagementObject(String.Concat(@"win32_logicaldisk.deviceid=""", DRIVE_C, @":"""));
                    dsk.Get();
                    strID = dsk[VOLUME_C].ToString();
                }
                catch (Exception exc)
                {
                    strID = ERR;
                }

                return (strID); 
            }
         }
        
        public string strCpuDetails
        {
            get
            {
                string strID = string.Empty;

                try 
                {
                    ManagementClass mc = new ManagementClass(WIN32_PROCESSOR);
                    ManagementObjectCollection moc = mc.GetInstances();
                
                    foreach (ManagementObject mo in moc)
                    {
                        strID = mo.Properties[PROCESSOR_ID].Value.ToString();
                        break;
                    }
                }
                catch (Exception exc)
                {
                    strID = ERR;
                }

                return (strID);
            }

        }


      

          
    }
}
