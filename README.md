# AutoPrint
This software is about a Windows .Net Service meant to automatically print new PDF Files.

The project was initially created for Zebra printers that weren't compatible with a legacy software.

For it to work you need:

1- An Virtual Printer to PDF;
* I mostly recomend using Microsoft Print to PDF Printer with a standard printer port (ex: "c:\pdf\micropdf.pdf")

2- A PDF reader with a cmd printing command;
* This project was made considering Foxit PDF Reader

3- A .bat script on the same folder as the PDF;
* You can skip the .bat file if you configure the printing work into the code, but for my company the .bat was mandatory

The .bat file has the following command:

---------
call "C:\Program Files (x86)\Foxit Software\Foxit PDF Reader\FoxitPDFReader.exe" -t "c:\pdf\micropdf.pdf" PrinterName
---------


How it works:
- The service will be running checking a PDF's WriteTime on a specified folder;
- It'll check if the file's last WriteTime registered is different from the last printed file Writetime;
- If it's not equal, it'll print and update the last Writetime;


---------
PS: You've to install the service using the following command:

C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe "<path>\autoprint.exe"

If needed to, you can set the service as "auto".


# TrocaImpressora

This translates to "Change Printer";

Windows Form Application, you just need a Windows PC with .Net Framework Updated for it to run;

It mostly just edits the .bat file with the new default printer (Since the Windows Default Printer HAS to be Microsoft's PDF Printer).
