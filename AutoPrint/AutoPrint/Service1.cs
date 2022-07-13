using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace AutoPrint
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer(); // name space(using System.Timers;)  

        public Service1()
        {
            InitializeComponent();
        }


        protected override void OnStart(string[] args)
        {
            //The main service instruction

            if (CheckVersion() == true) //"True" means the service has to print
            {
                String pathdate = @"c:\pdf\LastDate.txt"; //path of the txt file containing the WriteTime of the last printed file
                String path = @"c:\pdf\micropdf.pdf"; //path of the generated pdf file
                System.IO.File.WriteAllText(pathdate, System.IO.File.GetLastWriteTime(path).ToString()); //Updates the TXT file to contain the last WriteTime
                Print();
            }

            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000;
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            if (CheckVersion() == true)
            {
                String pathdate = @"c:\pdf\LastDate.txt"; //path of the txt file containing the WriteTime of the last printed file
                String path = @"c:\pdf\micropdf.pdf"; //path of the generated pdf file
                System.IO.File.WriteAllText(pathdate, System.IO.File.GetLastWriteTime(path).ToString()); //Updates the TXT file to contain the last WriteTime
                Print();
            }
        }

        public bool CheckVersion()
        {
            String pathdate = @"c:\pdf\LastDate.txt"; //path of the txt file containing the WriteTime of the last printed file
            String path = @"c:\pdf\micropdf.pdf"; //path of the generated pdf file
            String dataedicao = File.ReadAllText(pathdate);
            string dataarquivo = System.IO.File.GetLastWriteTime(path).ToString();

            if (dataedicao.Equals(dataarquivo)) //If the date is the same, then it'll skip the printing
                return false;
            else 
            {
                //This "Sleep" is optional, the legacy software I was working on prints two times, this just makes sure the service will not print twice
                System.Threading.Thread.Sleep(4000); 
                return true; //The dates aren't the same, so the Service HAS to print the pdf file
            }
        }

        public static bool Print()
        {
            //This prints the file, the command is on a .bat file because I developed another software to manage the default printer;
            //Remember on this case we changed the Default Printer to Microsoft's native and this service is totally silent (so, no interfaces);
            //Since we have a main printer and a backup one, a second program is needed for "editing" the .bat, pointing out the new printer path
            Process.Start("cmd.exe", "/c call " + @"c:\pdf\print.bat"); 
            return true;
        }
    }
}
