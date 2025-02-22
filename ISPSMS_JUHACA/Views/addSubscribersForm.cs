using Domain.Models;

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

using Infastructure.Data.Repositories.IRepositories;


namespace ISPSMS_JUHACA
{
    public partial class addSubscribersForm : MaterialForm
    {
        public readonly IUnitOfWork? dbContext;
        internal SubscribersForm SubscribersForm;
        public string message { get; internal set; }

        public addSubscribersForm(IUnitOfWork? dbContext)
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


        private void SaveBtn_Click_1(object sender, EventArgs e)
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
                Charge = decimal.Parse(monthlyChargeTextBox.Text),
                ContactNumber = contactNumberTextBox.Text,

                CurrentDuedate = selectedDueDate,
                InstallationDate = DateTime.Now,
                Status = "Active",
                Balance = 0,
                MonthlyCharge = monthlyCharge + 0

            };
            dbContext.connectedSubscriberRepository.Add(entity);
            dbContext.Save();

            message = "Subscriber successfully added!";

            MessageBox.Show(message,
                "Adding Program",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            SubscribersForm.getPrograms();
            Hide();
        }
    }
}