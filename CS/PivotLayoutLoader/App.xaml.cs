﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace PivotLayoutLoader {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        string layoutFileName;
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            if(e.Args.Length > 0)
                layoutFileName = e.Args[0];
        }
        public string LayoutFileName { get { return layoutFileName; } }
    }
}
