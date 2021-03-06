﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using pheonix.util;

namespace pheonix {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if(args.Length == 0) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmTheHighLander generator = new frmTheHighLander();
                generator.Icon = new Icon("favicon.ico");
                Application.Run(generator);
            } else {
                if(args.Length != 6) {
                    Console.WriteLine("Must enter 6 arguments.  Enter help as first parameter for assistance.");
                    Environment.Exit(0);
                } else {
                    if(args[0].ToLower().Equals("help")) {
                        Console.WriteLine("Enter the root directory of the solution to be processed, the product name, the content output filename, the config output filename the product output filename and the directory to move the files to.\n" +
                                          "For Example: WIXContentWriter C:\\MySolutionRoot ProductName ProductContent.wxs Config.wxi Product.wxs C:\\MyDestinationDir");
                        Environment.Exit(0);
                    } else {
                        if(!Directory.Exists(args[0])) {
                            Console.WriteLine("Solution directory specified does not exist.  Exiting.");
                            Environment.Exit(0);
                        } else {
                            //Correct number of arguments - ready to attempt processing.
                            ContentWriter cw = new ContentWriter();
                            cw.writePagesOutputFile(args[0], args[2], args[3]);
                            Console.WriteLine("Successfully completed writing WIX Content file.");
                            cw.writeGoToOutputFile(args[1], args[3]);
                            Console.WriteLine("Successfully completed writing WIX Config file.");
                            cw.writeProductOutputFile(args[3], args[4]);
                            Console.WriteLine("Successfully completed writing WIX Product file.");

                            int filesMoved = FileUtil.moveFiles(args[5]);

                            Console.WriteLine("Finished moving " + filesMoved + " files to " + args[5] + ".");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}