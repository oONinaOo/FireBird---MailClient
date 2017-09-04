using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using CredentialManagement;



namespace MailClient

{

    class FileHandler

    {
        private static string path = @"C:\BirdCool\accountInf.dat";
        private string accountID;
        private string accountPassword;

        public FileHandler(string accountID, string accountPassword)

        {
            this.accountID = accountID;

            this.accountPassword = accountPassword;

        }
        public static Boolean checkAccountFile()
        {

            if (File.Exists(path))
            {
                return true;

            }

            else

            {
                return false;

            }



        }

        public static string getAccountInfo()

        {

            System.IO.StreamReader oRead = null;

            oRead = System.IO.File.OpenText(path);

            string accountInfo = "";

            while (!oRead.EndOfStream)

            {

                accountInfo = oRead.ReadLine();

            }

            return accountInfo;

        }

        public void writeDataFile()

        {

            if (File.Exists(path))

            {

                File.Delete(path);

            }

            try

            {

                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(fs);

                fs.Flush();

                sw.Flush();

                sw.WriteLine(this.accountID);

                fs.Flush();

                sw.Flush();

                File.SetAttributes(path, FileAttributes.Hidden);

                fs.Close();
            }

            catch (DirectoryNotFoundException e)

            {

            }



        }

        public void SavePassword()

        {

            using (var cred = new Credential())

            {

                cred.Password = this.accountPassword;

                cred.Target = this.accountID;

                cred.Type = CredentialType.Generic;

                cred.PersistanceType = PersistanceType.LocalComputer;

                cred.Save();

            }

        }

        public static string GetPassword(string accountID)

        {

            using (var cred = new Credential())

            {

                cred.Target = accountID;

                cred.Load();

                return cred.Password;

            }

        }





    }







}