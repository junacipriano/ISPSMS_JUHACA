using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using ISPSMS_JUHACA.Data;
using Infastructure.Data.Repositories.IRepositories;

namespace ISPSMS_JUHACA
{
    public partial class SubscribersForm : MaterialForm
    {
        public readonly IConnectedSubscribersRepository dbContext;
        private BindingSource bindingSource;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        public SubscribersForm(IConnectedSubscribersRepository dbContext)
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
            var connectedSubscribers = dbContext.GetAll();
            bindingSource.DataSource = connectedSubscribers;
            connectedsubscribersGridView.DataSource = bindingSource;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ConSubsEntity = (Domain.Models.ConnectedSubscribers)bindingSource.Current;
            var AddForm = new addSubscribersForm(dbContext);            
            AddForm.ShowDialog();

        }

        private void connectedsubscribersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConSubsEntity = (Domain.Models.ConnectedSubscribers)bindingSource.Current;
        }
    }
}
