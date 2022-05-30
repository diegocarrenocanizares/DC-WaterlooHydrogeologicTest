using System.Configuration;
using WH.Proxy;
using WH.Shared.Entities;

namespace WH.UI
{
    public partial class CUD_Form : Form
    {
        private Station _record;
        private readonly ProxyClass _proxy;
        private Form1 _parent;

        public CUD_Form(Form1 parent, Station? record = null)
        {
            InitializeComponent();

            _parent = parent;

            if (record == null)
            {
                btnAddUpdate.Text = "Create";
                btnDelete.Visible = false;
            }
            else
            {
                _record = record;
                btnAddUpdate.Text = "Update";
                btnDelete.Visible = true;

                FillData();
            }
            _proxy = new ProxyClass(ConfigurationManager.AppSettings["ServiceEndpointUrl"] ?? string.Empty);
        }

        #region Events
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            var model = GetData();
            if (model == null)
            {
                MessageBox.Show("All the fields must be valid to proceed, please check again.");
                return;
            }

            if (_record != null)
            {
                model.Id = _record.Id;
                _proxy.StationProxy.Update(model);
            }
            else
            {
                _proxy.StationProxy.Add(model);
            }

            _parent.UpdateDataGridView();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_record != null)
            {
                _proxy.StationProxy.Delete(_record);
                _parent.UpdateDataGridView();


                this.Close();
            }
            else {
                MessageBox.Show("The record to be deleted could not be found.");
            }
            
        }
        #endregion

        #region Internal Usage
        private void FillData()
        {
            txtCUD_StationName.Text = _record.StationName;
            txtCUD_screen_id.Text = _record.ScreenId;
            txtCUD_Date.Text = _record.Date.ToString("yyyy-MM-dd");
            txtCUD_depth_to_water_level.Text = _record.DepthToWaterLvl.ToString();
            txtCUD_Comment.Text = _record.Comment;
        }

        private Station? GetData()
        {
            if(float.TryParse(txtCUD_depth_to_water_level.Text, out float DepthToWaterLvl)
                && !string.IsNullOrWhiteSpace(txtCUD_StationName.Text)
                && !string.IsNullOrWhiteSpace(txtCUD_screen_id.Text)
                && DateTime.TryParse(txtCUD_Date.Text, out DateTime date)
                && !string.IsNullOrWhiteSpace(txtCUD_Comment.Text))
            {
                return new Station()
                {
                    StationName = txtCUD_StationName.Text,
                    ScreenId = txtCUD_screen_id.Text,
                    Date = date,
                    DepthToWaterLvl = DepthToWaterLvl,
                    Comment = txtCUD_Comment.Text,
                };
            }

            return null;
        }
        #endregion
    }

}
