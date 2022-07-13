using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaImpressora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*------------------------------------------
         * 
         * This program doesn't have a Try/Catch, the reason is:
         * It wasn't developed for a high end usage, the users have absolutely no power to change any file
         * with the exception of the pdf.
         * 
         * 
         * If you adapt this code for your corporation it most likely NEEDS a Try/Catch
         * Not adding the Try/Catch WILL make your software crash if it doesn't locate the "c:\pdf\print.bat"
         * 
         * -----------------------------------------
        */

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            //"Atualiza" means "Update", this button will update the default printer into the pdf file;
            //This is a software that writes commands on a .bat file that will be used later for the main service

            string path = @"c:\pdf\print.bat";
            if (rdb_zebra1.Checked)
            {
                //First printer is selected, this means that it has to set up the default printer as the printer named Printer1
                string instrucao = "call " + (char)34 + @"C:\Program Files (x86)\Foxit Software\Foxit PDF Reader\FoxitPDFReader.exe" + (char)34 + " -t " + (char)34 + @"c:\pdf\micropdf.pdf" + (char)34 + " Printer1";
                System.IO.File.WriteAllText(path, instrucao + "\n" + instrucao);
                MessageBox.Show("Impressora padrão alterada"); //Tells the user the Default printer has changed
            } else if(rdb_zebra2.Checked)
            {
                //Second printer is selected, this means that it has to set up the default printer as the printer named Printer2
                string instrucao = "call " + (char)34 + @"C:\Program Files (x86)\Foxit Software\Foxit PDF Reader\FoxitPDFReader.exe" + (char)34 + " -t " + (char)34 + @"c:\pdf\micropdf.pdf" + (char)34 + " Printer2";
                System.IO.File.WriteAllText(path, instrucao + "\n" + instrucao);
                MessageBox.Show("Impressora padrão alterada"); //Tells the user the Default printer has changed
            } else
            {
                MessageBox.Show("Nenhuma impressora selecionada"); //Tells the user there is no Radio Button checked
            }

        }
    }
}
