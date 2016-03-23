﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Adan.Client.ViewModel;
using CSLib.Net.Annotations;
using CSLib.Net.Diagnostics;
using Adan.Client.Common.Settings;

namespace Adan.Client.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для ProfilesOptionsEditDialog.xaml
    /// </summary>
    public partial class ProfileOptionsEditDialog : Window
    {
        private string profileName;

        /// <summary>
        /// 
        /// </summary>
        public ProfileOptionsEditDialog(string profileName)
        {
            InitializeComponent();

            this.profileName = profileName;
            this.Title += profileName;
            this.Closed += ProfileOptionsEditDialog_Closed;
        }

        private void ProfileOptionsEditDialog_Closed(object sender, EventArgs e)
        {
            SettingsHolder.Instance.SetProfile(profileName);
        }

        private void HandleItemDoubleClick([NotNull] object sender, [NotNull] RoutedEventArgs e)
        {
            ((ProfileOptionsViewModel)this.DataContext).EditOptionsCommand.Execute(this);
        }

        private void HandleCloseClick([NotNull] object sender, [NotNull] RoutedEventArgs e)
        {
            //DialogResult = true;
            this.Close();
        }
    }
}
