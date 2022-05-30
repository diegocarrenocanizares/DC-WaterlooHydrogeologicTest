namespace WH.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReplaceCharacters = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthToWaterLvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_ComboExample = new System.Windows.Forms.ComboBox();
            this.btnDisplaySelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplaceCharacters
            // 
            this.btnReplaceCharacters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReplaceCharacters.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReplaceCharacters.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReplaceCharacters.Location = new System.Drawing.Point(467, 62);
            this.btnReplaceCharacters.Name = "btnReplaceCharacters";
            this.btnReplaceCharacters.Size = new System.Drawing.Size(548, 112);
            this.btnReplaceCharacters.TabIndex = 1;
            this.btnReplaceCharacters.Text = "Replace Characters";
            this.btnReplaceCharacters.UseVisualStyleBackColor = false;
            this.btnReplaceCharacters.Click += new System.EventHandler(this.btnReplaceCharacters_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(1284, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 112);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStations
            // 
            this.dgvStations.AutoGenerateColumns = false;
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationNameDataGridViewTextBoxColumn,
            this.screenIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.depthToWaterLvlDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvStations.DataSource = this.stationBindingSource;
            this.dgvStations.Location = new System.Drawing.Point(12, 230);
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.RowHeadersWidth = 82;
            this.dgvStations.RowTemplate.Height = 41;
            this.dgvStations.Size = new System.Drawing.Size(1484, 668);
            this.dgvStations.TabIndex = 3;
            this.dgvStations.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStations_RowHeaderMouseClick);
            // 
            // stationNameDataGridViewTextBoxColumn
            // 
            this.stationNameDataGridViewTextBoxColumn.DataPropertyName = "StationName";
            this.stationNameDataGridViewTextBoxColumn.HeaderText = "Station Name";
            this.stationNameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.stationNameDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.stationNameDataGridViewTextBoxColumn.Name = "stationNameDataGridViewTextBoxColumn";
            this.stationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // screenIdDataGridViewTextBoxColumn
            // 
            this.screenIdDataGridViewTextBoxColumn.DataPropertyName = "ScreenId";
            this.screenIdDataGridViewTextBoxColumn.HeaderText = "Screen Id";
            this.screenIdDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.screenIdDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.screenIdDataGridViewTextBoxColumn.Name = "screenIdDataGridViewTextBoxColumn";
            this.screenIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.screenIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // depthToWaterLvlDataGridViewTextBoxColumn
            // 
            this.depthToWaterLvlDataGridViewTextBoxColumn.DataPropertyName = "DepthToWaterLvl";
            this.depthToWaterLvlDataGridViewTextBoxColumn.HeaderText = "Depth To Water Level";
            this.depthToWaterLvlDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.depthToWaterLvlDataGridViewTextBoxColumn.Name = "depthToWaterLvlDataGridViewTextBoxColumn";
            this.depthToWaterLvlDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthToWaterLvlDataGridViewTextBoxColumn.Width = 300;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 500;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 500;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(WH.Shared.Entities.Station);
            // 
            // cb_ComboExample
            // 
            this.cb_ComboExample.DisplayMember = "Name";
            this.cb_ComboExample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ComboExample.FormattingEnabled = true;
            this.cb_ComboExample.Location = new System.Drawing.Point(15, 956);
            this.cb_ComboExample.Name = "cb_ComboExample";
            this.cb_ComboExample.Size = new System.Drawing.Size(480, 40);
            this.cb_ComboExample.TabIndex = 4;
            this.cb_ComboExample.ValueMember = "Id";
            // 
            // btnDisplaySelected
            // 
            this.btnDisplaySelected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplaySelected.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplaySelected.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDisplaySelected.Location = new System.Drawing.Point(501, 911);
            this.btnDisplaySelected.Name = "btnDisplaySelected";
            this.btnDisplaySelected.Size = new System.Drawing.Size(533, 112);
            this.btnDisplaySelected.TabIndex = 5;
            this.btnDisplaySelected.Text = "Display Selected Item";
            this.btnDisplaySelected.UseVisualStyleBackColor = false;
            this.btnDisplaySelected.Click += new System.EventHandler(this.btnDisplaySelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 1060);
            this.Controls.Add(this.btnDisplaySelected);
            this.Controls.Add(this.cb_ComboExample);
            this.Controls.Add(this.dgvStations);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReplaceCharacters);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnReplaceCharacters;
        private Button btnAdd;
        private DataGridView dgvStations;
        private BindingSource stationBindingSource;
        private DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn screenIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthToWaterLvlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private ComboBox cb_ComboExample;
        private Button btnDisplaySelected;
    }
}