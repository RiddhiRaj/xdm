﻿using System;
using Gtk;
using Translations;
using XDM.Core.Lib.Common;
using XDMApp;

namespace XDM.GtkUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            //var screen = Gdk.Screen.Default;
            //var provider = new CssProvider();
            //provider.LoadFromData(@".dark 
            //                                    {
            //                                        color: gray;
            //                                        background: rgb(36,41,46);
            //                                    }

            //                                    treeview.view :selected 
            //                                    {
            //                                        background-color: rgb(10,106,182);
            //                                        color: white;
            //                                    }
            //.listt
            //{
            //font-family: Segoe UI;
            //}
            //                                    .dark2
            //                                    {
            //                                        color: gray;
            //                                        background: rgb(35,35,35);
            //                                        /*background: rgb(36,41,46);*/
            //                                    }
            //                                    .toolbar-border-dark
            //                                    {  
            //                                        border-bottom: 1px solid rgb(20,20,20);
            //                                    }
            //                                    .toolbar-border-light
            //                                    {  
            //                                        border-bottom: 2px solid rgb(240,240,240);
            //                                    }
            //                                  ");
            //Gtk.StyleContext.AddProviderForScreen(screen, provider, 800);

            var app = new XDMApp.XDMApp();
            TextResource.Load(Config.Instance.Language);
            var appWin = new AppWinPeer();
            app.AppUI = new XDMApp.AppWin(appWin, app);
            appWin.ShowAll();
            Application.Run();

            //var app = new XDMApp.XDMApp();
            //var appWin = new AppWinPeer(app);
            //appWin.ShowAll();
            //Application.Run();


            //            Environment.SetEnvironmentVariable("PANGOCAIRO_BACKEND", "fc", EnvironmentVariableTarget.User);
            //            //Console.WriteLine(Environment.GetEnvironmentVariable("PANGOCAIRO_BACKEND"));
            //            //var arr = new string[] {  "PANGOCAIRO_BACKEND=fc" };
            //            Application.Init();// "app", ref arr);
            //            Gtk.Settings.Default.ThemeName = "Adwaita";
            //            Gtk.Settings.Default.ApplicationPreferDarkTheme = true;

            //            App app = new App();



            //            var appWin = new AppWin();
            //            Console.WriteLine("Starting show all");
            //            appWin.Show();
            //            Console.WriteLine("Finished show all");
            //            Application.Run();
        }
    }
}