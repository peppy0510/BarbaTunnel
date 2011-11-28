﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarbaMonitor
{
    class BarbaNotify : IDisposable
    {
        NotifyIcon _NotifyIcon = new NotifyIcon();
        public NotifyIcon NotifyIcon { get { return _NotifyIcon; } }
        public MenuItem ExitMenu { get; private set; }
        public MenuItem StartMenu { get; private set; }
        public MenuItem RestartMenu { get; private set; }
        public MenuItem StopMenu { get; private set; }
        public BarbaNotify()
        {
            var menu = new System.Windows.Forms.ContextMenu();
            StartMenu = menu.MenuItems.Add("&Start");
            RestartMenu = menu.MenuItems.Add("Restart");
            StopMenu = menu.MenuItems.Add("Stop");
            menu.MenuItems.Add("-");
            ExitMenu = menu.MenuItems.Add("Exit");

            NotifyIcon.Icon = Resource1.Status_Stopped;
            NotifyIcon.Visible = true;
            NotifyIcon.ContextMenu = menu;
        }


        public void Dispose()
        {
            NotifyIcon.Dispose();
        }
    }
}
