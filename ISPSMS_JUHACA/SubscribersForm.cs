using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using ISPSMS_JUHACA.Data;
using Infastructure.Data.Repositories.IRepositories;

namespace ISPSMS_JUHACA
{
    public partial class SubscribersForm : MaterialForm
    {
        public readonly IUnitOfWork dbContext;
        private BindingSource bindingSource;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public SubscribersForm(IUnitOfWork dbContext)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.dbContext = dbContext;
            bindingSource = new BindingSource();
        }

        private void SubscribersForm_Load(object sender, EventArgs e)
        {
            getPrograms();


            if (connectedsubscribersGridView.Columns.Count > 9)
            {
                connectedsubscribersGridView.Columns[7].Visible = false;
                connectedsubscribersGridView.Columns[8].Visible = false;
                connectedsubscribersGridView.Columns[9].Visible = false;
            }
        }

        public void getPrograms()
        {
            var connectedSubscribers = dbContext.connectedSubscriberRepository.GetAll();
            bindingSource.DataSource = connectedSubscribers;
            connectedsubscribersGridView.DataSource = bindingSource;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (Domain.Models.ConnectedSubscribers)bindingSource.Current;
            var AddForm = new addSubscribersForm(dbContext);
            AddForm.SubscribersForm = this;
            AddForm.lastNameTextBox.Text = "";
            AddForm.firstNameTextBox.Text = "";
            AddForm.MITextBox.Text = "";
            AddForm.barangayComboBox.Text = "";
            AddForm.districtComboBox.Text = "";
            AddForm.planComboBox.Text = "";
            AddForm.dueDatePicker.Text = "";
            AddForm.monthlyChargeTextBox.Text = "";
            AddForm.contactNumberTextBox.Text = "";

            AddForm.ShowDialog();

        }

        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConSubsEntity = (Domain.Models.ConnectedSubscribers)bindingSource.Current;
        }
    }
}