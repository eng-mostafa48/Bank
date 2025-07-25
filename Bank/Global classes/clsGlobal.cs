using Bank.Properties;
using Bank_BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Bank.Global_classes
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RemamberUserNameAndPassWord(string UserName, string Password)
        {
            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (UserName == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = UserName + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredUserNameAndPassword(ref string UserName, ref string Password)
        {
            try
            {

                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader Reader = new StreamReader(filePath))
                    {
                        string Line = "";
                        while ((Line = Reader.ReadLine()) != null)
                        {
                            string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            UserName = Result[0];
                            Password = Result[1];
                        }

                        return true;
                    }

                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
