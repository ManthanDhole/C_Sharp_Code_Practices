using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message;
            Message = Console.ReadLine();

            //Use this to specify 1.Name for the Log file, 2.What to write in the Log File as a string message
            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1} - {2}", "Log is Created at", DateTime.Now, Message));

            Console.WriteLine("Log is Written Successfully");
        }

    }

    class WriteLogFile
    {
        //The WriteLog method would accept the 1. File Name  & 2. What is the Message to be written in the Log file
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                //File stream - Gets access for a path to store the file, Mode(Append or Read or Create New file), What to do with the file
                FileStream objFileStream = new FileStream(string.Format($"{Path.GetFullPath(@"C:\Users\mdhole.INFOR\OneDrive - Infor\Desktop\DotNet Test\Writing_Logs")}\\{strFileName}"), FileMode.Append, FileAccess.Write);

                //Used to write something to the mentioned file
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFileStream);
                //Stream casting in the previous line for objFileStream is redundant 

                objStreamWriter.WriteLine(strMessage);
                //Write this message that you got from the console to the mentioned file and append the file with the message

                objStreamWriter.Close();
                objFileStream.Close();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
