﻿using System;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    internal sealed partial class MainMenuForm : Form
    {
        public MainMenuForm() => this.InitializeComponent();

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
