﻿using Domain.Models;
using ISPSMS_JUHACA.Data.Repositories;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISPSMS_JUHACA.Data.Repositories;


namespace ISPSMS_JUHACA
{
    public partial class addSubscribersForm : MaterialForm
    {
        public readonly IConnectedSubscribersRepository? dbContext;
        internal SubscribersForm SubscribersForm;
        public string message { get; internal set; }

        public addSubscribersForm(IConnectedSubscribersRepository? dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private string GetOrdinal(int day)
        {
            if (day % 100 is 11 or 12 or 13)
                return day + "th";

            return (day % 10) switch
            {
                1 => day + "st",
                2 => day + "nd",
                3 => day + "rd",
                _ => day + "th",
            };
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var entity = SubscribersForm.ConSubsEntity;
            DateTime selectedDueDate = dueDatePicker.Value;
            decimal monthlyCharge = decimal.Parse(monthlyChargeTextBox.Text);

            entity = new Domain.Models.ConnectedSubscribers
            {
                Name = $"{lastNameTextBox.Text}, {firstNameTextBox.Text} {MITextBox.Text}",
                Address = $"{districtComboBox.Text}, {barangayComboBox.Text}",
                Plan = planComboBox.Text,
                Duedate = GetOrdinal(selectedDueDate.Day),
                MonthlyCharge = decimal.Parse(monthlyChargeTextBox.Text),
                ContactNumber = contactNumberTextBox.Text,

                CurrentDuedate = selectedDueDate,
                InstallationDate = DateTime.Now,
                Status = "Active",
                Balance = 0,
                TotalCharge = monthlyCharge + 0

            };
            dbContext.Add(entity);
            dbContext.Save();

            MessageBox.Show(message,
                "Adding Program",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            SubscribersForm.getPrograms();
            Hide();
        }
    }
}
