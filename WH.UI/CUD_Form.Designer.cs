namespace WH.UI
{
    partial class CUD_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCUD_StationName = new System.Windows.Forms.Label();
            this.lblCUD_screen_id = new System.Windows.Forms.Label();
            this.lblCUD_Date = new System.Windows.Forms.Label();
            this.lblCUD_depth_to_water_level = new System.Windows.Forms.Label();
            this.lblCUD_Comment = new System.Windows.Forms.Label();
            this.txtCUD_StationName = new System.Windows.Forms.TextBox();
            this.txtCUD_screen_id = new System.Windows.Forms.TextBox();
            this.txtCUD_depth_to_water_level = new System.Windows.Forms.TextBox();
            this.txtCUD_Comment = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtCUD_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblCUD_StationName
            // 
            this.lblCUD_StationName.AutoSize = true;
            this.lblCUD_StationName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUD_StationName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCUD_StationName.Location = new System.Drawing.Point(35, 40);
            this.lblCUD_StationName.Name = "lblCUD_StationName";
            this.lblCUD_StationName.Size = new System.Drawing.Size(333, 61);
            this.lblCUD_StationName.TabIndex = 0;
            this.lblCUD_StationName.Text = "Station Name:";
            // 
            // lblCUD_screen_id
            // 
            this.lblCUD_screen_id.AutoSize = true;
            this.lblCUD_screen_id.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUD_screen_id.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCUD_screen_id.Location = new System.Drawing.Point(35, 125);
            this.lblCUD_screen_id.Name = "lblCUD_screen_id";
            this.lblCUD_screen_id.Size = new System.Drawing.Size(243, 61);
            this.lblCUD_screen_id.TabIndex = 1;
            this.lblCUD_screen_id.Text = "Screen Id:";
            // 
            // lblCUD_Date
            // 
            this.lblCUD_Date.AutoSize = true;
            this.lblCUD_Date.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUD_Date.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCUD_Date.Location = new System.Drawing.Point(35, 209);
            this.lblCUD_Date.Name = "lblCUD_Date";
            this.lblCUD_Date.Size = new System.Drawing.Size(144, 61);
            this.lblCUD_Date.TabIndex = 2;
            this.lblCUD_Date.Text = "Date:";
            // 
            // lblCUD_depth_to_water_level
            // 
            this.lblCUD_depth_to_water_level.AutoSize = true;
            this.lblCUD_depth_to_water_level.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUD_depth_to_water_level.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCUD_depth_to_water_level.Location = new System.Drawing.Point(35, 297);
            this.lblCUD_depth_to_water_level.Name = "lblCUD_depth_to_water_level";
            this.lblCUD_depth_to_water_level.Size = new System.Drawing.Size(500, 61);
            this.lblCUD_depth_to_water_level.TabIndex = 3;
            this.lblCUD_depth_to_water_level.Text = "Depth to Water Level:";
            // 
            // lblCUD_Comment
            // 
            this.lblCUD_Comment.AutoSize = true;
            this.lblCUD_Comment.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUD_Comment.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCUD_Comment.Location = new System.Drawing.Point(35, 383);
            this.lblCUD_Comment.Name = "lblCUD_Comment";
            this.lblCUD_Comment.Size = new System.Drawing.Size(251, 61);
            this.lblCUD_Comment.TabIndex = 4;
            this.lblCUD_Comment.Text = "Comment:";
            // 
            // txtCUD_StationName
            // 
            this.txtCUD_StationName.Location = new System.Drawing.Point(577, 59);
            this.txtCUD_StationName.Name = "txtCUD_StationName";
            this.txtCUD_StationName.Size = new System.Drawing.Size(368, 39);
            this.txtCUD_StationName.TabIndex = 5;
            // 
            // txtCUD_screen_id
            // 
            this.txtCUD_screen_id.Location = new System.Drawing.Point(577, 144);
            this.txtCUD_screen_id.Name = "txtCUD_screen_id";
            this.txtCUD_screen_id.Size = new System.Drawing.Size(368, 39);
            this.txtCUD_screen_id.TabIndex = 6;
            // 
            // txtCUD_depth_to_water_level
            // 
            this.txtCUD_depth_to_water_level.Location = new System.Drawing.Point(577, 316);
            this.txtCUD_depth_to_water_level.Name = "txtCUD_depth_to_water_level";
            this.txtCUD_depth_to_water_level.Size = new System.Drawing.Size(368, 39);
            this.txtCUD_depth_to_water_level.TabIndex = 8;
            // 
            // txtCUD_Comment
            // 
            this.txtCUD_Comment.Location = new System.Drawing.Point(577, 402);
            this.txtCUD_Comment.Name = "txtCUD_Comment";
            this.txtCUD_Comment.Size = new System.Drawing.Size(368, 39);
            this.txtCUD_Comment.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(35, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(368, 112);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUpdate.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddUpdate.Location = new System.Drawing.Point(577, 499);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(368, 112);
            this.btnAddUpdate.TabIndex = 11;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = false;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtCUD_Date
            // 
            this.txtCUD_Date.CustomFormat = "yyyy-MM-dd";
            this.txtCUD_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCUD_Date.Location = new System.Drawing.Point(577, 226);
            this.txtCUD_Date.Name = "txtCUD_Date";
            this.txtCUD_Date.Size = new System.Drawing.Size(368, 39);
            this.txtCUD_Date.TabIndex = 12;
            // 
            // CUD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 646);
            this.Controls.Add(this.txtCUD_Date);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCUD_Comment);
            this.Controls.Add(this.txtCUD_depth_to_water_level);
            this.Controls.Add(this.txtCUD_screen_id);
            this.Controls.Add(this.txtCUD_StationName);
            this.Controls.Add(this.lblCUD_Comment);
            this.Controls.Add(this.lblCUD_depth_to_water_level);
            this.Controls.Add(this.lblCUD_Date);
            this.Controls.Add(this.lblCUD_screen_id);
            this.Controls.Add(this.lblCUD_StationName);
            this.Name = "CUD_Form";
            this.Text = "CUD_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCUD_StationName;
        private Label lblCUD_screen_id;
        private Label lblCUD_Date;
        private Label lblCUD_depth_to_water_level;
        private Label lblCUD_Comment;
        private TextBox txtCUD_StationName;
        private TextBox txtCUD_screen_id;
        private TextBox txtCUD_depth_to_water_level;
        private TextBox txtCUD_Comment;
        private Button btnDelete;
        private Button btnAddUpdate;
        private DateTimePicker txtCUD_Date;
    }
}