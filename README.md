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
- The service will be running checking a PDF's modified datetime on a specified folder;
- It'll check if the file's last modified datetime is different from the last printed file datetime;
- If it's not equal, it'll print and update the last modified date;
