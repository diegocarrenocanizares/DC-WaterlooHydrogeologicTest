using WH.Shared.Entities;
using System.Configuration;
using WH.Proxy;
using System.Linq;

namespace WH.UI
{
    public partial class Form1 : Form
    {
        private readonly ProxyClass _proxy;
        public Form1()
        {
            InitializeComponent();

            _proxy = new ProxyClass(ConfigurationManager.AppSettings["ServiceEndpointUrl"] ?? string.Empty);

            UpdateDataGridView();
            LoadComboExample();
        }

        #region Events
        private void btnReplaceCharacters_Click(object sender, EventArgs e)
        {
            List<int> selectedColumnsIndex = new List<int>();
            foreach (DataGridViewCell selectedCell in dgvStations.SelectedCells)
            {
                selectedColumnsIndex.Add(selectedCell.ColumnIndex);
            }

            _proxy.StationProxy.UpdateColumns(selectedColumnsIndex);
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CUD_Form form = new CUD_Form(this);
            form.Show();
        }

        private void dgvStations_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selectedRow = (Station)dgvStations.Rows[e.RowIndex].DataBoundItem;

                CUD_Form form = new CUD_Form(this, selectedRow);
                form.Show();
            }
            catch// (Exception ex)
            {
                MessageBox.Show($"The item could not be retrieved, please reload and try again.");
            }
        }

        private void btnDisplaySelected_Click(object sender, EventArgs e)
        {
            var selectedValue = cb_ComboExample.SelectedValue;
            var selectedText = ((ComboExample)cb_ComboExample.SelectedItem).Name;
            MessageBox.Show($"The item '{selectedText}' with id '{selectedValue}' was clicked'");
        }
        #endregion

        #region Internal usage 
        public void UpdateDataGridView()
        {
            var response = _proxy.StationProxy.GetAll();
            if(response?.Result == Shared.Enum.ResultType.SUCCESS)
            {
                dgvStations.DataSource = response.Data;
            }
        }

        public void LoadComboExample()
        {
            var response = _proxy.CommonProxy.GetAllComboList();
            if (response?.Result == Shared.Enum.ResultType.SUCCESS)
            {
                cb_ComboExample.DataSource = response.Data;
            }
        }

        #endregion

    }
}