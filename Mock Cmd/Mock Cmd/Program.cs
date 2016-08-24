using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;


namespace Mock_Cmd
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Command Prompt";
            Console.WriteLine("Microsoft Windows [Version 10.0.10586]\n(c) 2015 Microsoft Corporation. All rights reserved.\n");
            Console.Write("C:\\Users\\" + Environment.UserName + ">");
            Start();
            Process.GetCurrentProcess().WaitForExit();
        }

        static void Start()
        {
            while (true)
            {
                try
                {
                    Console.Title = "Command Prompt";
                    send_command(Console.ReadLine());
            }
                catch
            {
                //null
            }

        }
        }

        static void send_command(string command)
        {
            string[] command_split = command.Split(' ');
            switch (command_split[0])
            {
                case "netstat":
                    {
                        Console.Title = "Command Prompt - netstat";
                        Create_Fake_Netstat_scan();
                        break;
                    }
                case "NETSTAT":
                    {
                        Console.Title = "Command Prompt - NETSTAT";
                        Create_Fake_Netstat_scan();
                        break;
                    }
                case "tree":
                    {
                        Console.Title = "Command Prompt - tree";
                        Create_Fake_Tree_scan();
                        break;
                    }
                case "TREE":
                    {
                        Console.Title = "Command Prompt - TREE";
                        Create_Fake_Tree_scan();
                        break;
                    }
                case "cls":
                    {
                        Console.Clear();
                        break;
                    }
                case "CLS":
                    {
                        Console.Clear();
                        break;
                    }
                case "help":
                    {
                        Console.WriteLine("For more information on a specific command, type HELP command-name\nASSOC          Displays or modifies file extension associations.\nATTRIB         Displays or changes file attributes.\nBREAK          Sets or clears extended CTRL+C checking.\nBCDEDIT        Sets properties in boot database to control boot loading.\nCACLS          Displays or modifies access control lists (ACLs) of files.\nCALL           Calls one batch program from another.\nCD             Displays the name of or changes the current directory.\nCHCP           Displays or sets the active code page number.\nCHDIR          Displays the name of or changes the current directory.\nCHKDSK         Checks a disk and displays a status report.\nCHKNTFS        Displays or modifies the checking of disk at boot time.\nCLS            Clears the screen.\nCMD            Starts a new instance of the Windows command interpreter.\nCOLOR          Sets the default console foreground and background colors.\nCOMP           Compares the contents of two files or sets of files.\nCOMPACT        Displays or alters the compression of files on NTFS partitions.\nCONVERT        Converts FAT volumes to NTFS.  You cannot convert the\n               current drive.\nCOPY           Copies one or more files to another location.\nDATE           Displays or sets the date.\nDEL            Deletes one or more files.\nDIR            Displays a list of files and subdirectories in a directory.\nDISKPART       Displays or configures Disk Partition properties.\nDOSKEY         Edits command lines, recalls Windows commands, and\n               creates macros.\nDRIVERQUERY    Displays current device driver status and properties.\nECHO           Displays messages, or turns command echoing on or off.\nENDLOCAL       Ends localization of environment changes in a batch file.\nERASE          Deletes one or more files.\nEXIT           Quits the CMD.EXE program (command interpreter).\nFC             Compares two files or sets of files, and displays the\n               differences between them.\nFIND           Searches for a text string in a file or files.\nFINDSTR        Searches for strings in files.\nFOR            Runs a specified command for each file in a set of files.\nFORMAT         Formats a disk for use with Windows.\nFSUTIL         Displays or configures the file system properties.\nFTYPE          Displays or modifies file types used in file extension\n               associations.\nGOTO           Directs the Windows command interpreter to a labeled line in\n               a batch program.\nGPRESULT       Displays Group Policy information for machine or user.\nGRAFTABL       Enables Windows to display an extended character set in\n               graphics mode.\nHELP           Provides Help information for Windows commands.\nICACLS         Display, modify, backup, or restore ACLs for files and\n               directories.\nIF             Performs conditional processing in batch programs.\nLABEL          Creates, changes, or deletes the volume label of a disk.\nMD             Creates a directory.\nMKDIR          Creates a directory.\nMKLINK         Creates Symbolic Links and Hard Links\nMODE           Configures a system device.\nMORE           Displays output one screen at a time.\nMOVE           Moves one or more files from one directory to another\n               directory.\nOPENFILES      Displays files opened by remote users for a file share.\nPATH           Displays or sets a search path for executable files.\nPAUSE          Suspends processing of a batch file and displays a message.\nPOPD           Restores the previous value of the current directory saved by\n               PUSHD.\nPRINT          Prints a text file.\nPROMPT         Changes the Windows command prompt.\nPUSHD          Saves the current directory then changes it.\nRD             Removes a directory.\nRECOVER        Recovers readable information from a bad or defective disk.\nREM            Records comments (remarks) in batch files or CONFIG.SYS.\nREN            Renames a file or files.\nRENAME         Renames a file or files.\nREPLACE        Replaces files.\nRMDIR          Removes a directory.\nROBOCOPY       Advanced utility to copy files and directory trees\nSET            Displays, sets, or removes Windows environment variables.\nSETLOCAL       Begins localization of environment changes in a batch file.\nSC             Displays or configures services (background processes).\nSCHTASKS       Schedules commands and programs to run on a computer.\nSHIFT          Shifts the position of replaceable parameters in batch files.\nSHUTDOWN       Allows proper local or remote shutdown of machine.\nSORT           Sorts input.\nSTART          Starts a separate window to run a specified program or command.\nSUBST          Associates a path with a drive letter.\nSYSTEMINFO     Displays machine specific properties and configuration.\nTASKLIST       Displays all currently running tasks including services.\nTASKKILL       Kill or stop a running process or application.\nTIME           Displays or sets the system time.\nTITLE          Sets the window title for a CMD.EXE session.\nTREE           Graphically displays the directory structure of a drive or\n               path.\nTYPE           Displays the contents of a text file.\nVER            Displays the Windows version.\nVERIFY         Tells Windows whether to verify that your files are written\n               correctly to a disk.\nVOL            Displays a disk volume label and serial number.\nXCOPY          Copies files and directory trees.\nWMIC           Displays WMI information inside interactive command shell.\n\nFor more information on tools see the command-line reference in the online help.");
                        break;
                    }
                case "HELP":
                    {
                        Console.WriteLine("For more information on a specific command, type HELP command-name\nASSOC          Displays or modifies file extension associations.\nATTRIB         Displays or changes file attributes.\nBREAK          Sets or clears extended CTRL+C checking.\nBCDEDIT        Sets properties in boot database to control boot loading.\nCACLS          Displays or modifies access control lists (ACLs) of files.\nCALL           Calls one batch program from another.\nCD             Displays the name of or changes the current directory.\nCHCP           Displays or sets the active code page number.\nCHDIR          Displays the name of or changes the current directory.\nCHKDSK         Checks a disk and displays a status report.\nCHKNTFS        Displays or modifies the checking of disk at boot time.\nCLS            Clears the screen.\nCMD            Starts a new instance of the Windows command interpreter.\nCOLOR          Sets the default console foreground and background colors.\nCOMP           Compares the contents of two files or sets of files.\nCOMPACT        Displays or alters the compression of files on NTFS partitions.\nCONVERT        Converts FAT volumes to NTFS.  You cannot convert the\n               current drive.\nCOPY           Copies one or more files to another location.\nDATE           Displays or sets the date.\nDEL            Deletes one or more files.\nDIR            Displays a list of files and subdirectories in a directory.\nDISKPART       Displays or configures Disk Partition properties.\nDOSKEY         Edits command lines, recalls Windows commands, and\n               creates macros.\nDRIVERQUERY    Displays current device driver status and properties.\nECHO           Displays messages, or turns command echoing on or off.\nENDLOCAL       Ends localization of environment changes in a batch file.\nERASE          Deletes one or more files.\nEXIT           Quits the CMD.EXE program (command interpreter).\nFC             Compares two files or sets of files, and displays the\n               differences between them.\nFIND           Searches for a text string in a file or files.\nFINDSTR        Searches for strings in files.\nFOR            Runs a specified command for each file in a set of files.\nFORMAT         Formats a disk for use with Windows.\nFSUTIL         Displays or configures the file system properties.\nFTYPE          Displays or modifies file types used in file extension\n               associations.\nGOTO           Directs the Windows command interpreter to a labeled line in\n               a batch program.\nGPRESULT       Displays Group Policy information for machine or user.\nGRAFTABL       Enables Windows to display an extended character set in\n               graphics mode.\nHELP           Provides Help information for Windows commands.\nICACLS         Display, modify, backup, or restore ACLs for files and\n               directories.\nIF             Performs conditional processing in batch programs.\nLABEL          Creates, changes, or deletes the volume label of a disk.\nMD             Creates a directory.\nMKDIR          Creates a directory.\nMKLINK         Creates Symbolic Links and Hard Links\nMODE           Configures a system device.\nMORE           Displays output one screen at a time.\nMOVE           Moves one or more files from one directory to another\n               directory.\nOPENFILES      Displays files opened by remote users for a file share.\nPATH           Displays or sets a search path for executable files.\nPAUSE          Suspends processing of a batch file and displays a message.\nPOPD           Restores the previous value of the current directory saved by\n               PUSHD.\nPRINT          Prints a text file.\nPROMPT         Changes the Windows command prompt.\nPUSHD          Saves the current directory then changes it.\nRD             Removes a directory.\nRECOVER        Recovers readable information from a bad or defective disk.\nREM            Records comments (remarks) in batch files or CONFIG.SYS.\nREN            Renames a file or files.\nRENAME         Renames a file or files.\nREPLACE        Replaces files.\nRMDIR          Removes a directory.\nROBOCOPY       Advanced utility to copy files and directory trees\nSET            Displays, sets, or removes Windows environment variables.\nSETLOCAL       Begins localization of environment changes in a batch file.\nSC             Displays or configures services (background processes).\nSCHTASKS       Schedules commands and programs to run on a computer.\nSHIFT          Shifts the position of replaceable parameters in batch files.\nSHUTDOWN       Allows proper local or remote shutdown of machine.\nSORT           Sorts input.\nSTART          Starts a separate window to run a specified program or command.\nSUBST          Associates a path with a drive letter.\nSYSTEMINFO     Displays machine specific properties and configuration.\nTASKLIST       Displays all currently running tasks including services.\nTASKKILL       Kill or stop a running process or application.\nTIME           Displays or sets the system time.\nTITLE          Sets the window title for a CMD.EXE session.\nTREE           Graphically displays the directory structure of a drive or\n               path.\nTYPE           Displays the contents of a text file.\nVER            Displays the Windows version.\nVERIFY         Tells Windows whether to verify that your files are written\n               correctly to a disk.\nVOL            Displays a disk volume label and serial number.\nXCOPY          Copies files and directory trees.\nWMIC           Displays WMI information inside interactive command shell.\n\nFor more information on tools see the command-line reference in the online help.");
                        break;
                    }

                case "echo":
                    {
                        Console.WriteLine(command_split[1]);
                        break;
                    }
                case "ECHO":
                    {
                        Console.WriteLine(command_split[1]);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("'" + command + "'" + " is not recognized as an internal or external command,\noperable program or batch file.\n");
                        break;
                    }
            }
            Console.Write("C:\\Users\\" + Environment.UserName + ">");
        }



        static void Create_Fake_Tree_scan()
        {
            string[] Messages = { "\nScanning computer for viruses.", "Volume serial number is 2E8F-5EFC",
            "C:.","├───Pics","├───Indian Phone Scammers","├───Errors","├───Private","│   ├───Indian","│   ├───Ebony",
            "│   │   └───Minecraft Roleplay","│   ├───Huge black c***s","│   └───Homosexual","├───Movies","├───redist","│   └───miles","├───replay",
                "├───Southpark","│   ├───Season 09","│   └───Season 08","└───support","│   ├───Technical support","│   ├───Images",
            "│   │   ├───Cute indian","│   │   └───Nawwwwwwwwwww","│   ├───Photos","│   ├───Readme","│   ├───Support","│   └───Radio","└───Youtube"
                ,"├───Pics","├───Indian Phone Scammers","├───Errors","├───Private","│   ├───Indian","│   ├───Ebony",
            "│   │   └───Minecraft Roleplay","│   ├───Huge black c***s","│   └───Homosexual","├───Movies","├───redist","│   └───miles","├───replay",
                "├───Southpark","│   ├───Season 09","│   └───Season 08","└───support","│   ├───Technical support","│   ├───Images",
            "│   │   ├───Cute indian","│   │   └───Nawwwwwwwwwww","│   ├───Photos","│   ├───Readme","│   ├───Support","│   └───Radio","└───Youtube","\n",
            "   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄", "   ▌SCAN COMPLETED, NO VIRUS FOUND.▌","   ▌YOUR COMPUTER IS 100% CLEAN    ▌" , "   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n"};

            for(int i = 0; i <= Messages.Length - 1; i++)
            {
                Console.WriteLine(Messages[i]);
                System.Threading.Thread.Sleep(25);
            }
        }
        static void Create_Fake_Netstat_scan()
        {
            string[] Messages = {"\nActive Secure Connections","\n  Proto  Local Address          Foreign Address        State","  TCP    127.0.0.1:5354         microsoft:49682         SAFE_CONNECTION",
                "  TCP    127.0.0.1:5354         microsoft:49683         SAFE_CONNECTION","  TCP    127.0.0.1:27015        microsoft:49850         SAFE_CONNECTION","  TCP    127.0.0.1:49676        microsoft:49677         SAFE_CONNECTION",
                "  TCP    127.0.0.1:49677        microsoft:49676         SAFE_CONNECTION","  TCP    127.0.0.1:49682        microsoft:5354          SAFE_CONNECTION","  TCP    127.0.0.1:49683        microsoft:5354          SAFE_CONNECTION",
                "  TCP    127.0.0.1:49850        microsoft:27015         SAFE_CONNECTION","  TCP    127.0.0.1:57491        microsoft:57492         SAFE_CONNECTION","  UDP    127.0.0.1:57492        microsoft:57491         SAFE_CONNECTION",
                "  TCP    127.0.0.1:57494        microsoft:57495         SAFE_CONNECTION","  TCP    127.0.0.1:57495        microsoft:57494         SAFE_CONNECTION" ,"  TCP    192.168.1.202:49893    arn09s10-in-f134:http   SAFE_CONNECTION",
                "  TCP    192.168.1.202:50031    191.232.139.254:https   SAFE_CONNECTION","  TCP    192.168.1.202:50515    151.101.84.246:http     SAFE_CONNECTION","  TCP    192.168.1.202:51233    131.120.188.139:https   SAFE_CONNECTION",
                "  TCP    192.168.1.202:51236    131.120.188.139:https   SAFE_CONNECTION","  TCP    192.168.1.202:51257    191.232.139.254:https   SAFE_CONNECTION","  TCP    192.168.1.202:51265    213.156.250.37:http     SAFE CONNECTION",
            "\n","  All connections are clean and secure. (Firewall status: [Active])"};

            for (int i = 0; i <= Messages.Length - 1; i++)
            {
                Console.WriteLine(Messages[i]);
                System.Threading.Thread.Sleep(540);
            }
        }
    }
}
