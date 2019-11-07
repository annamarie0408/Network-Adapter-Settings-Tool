namespace Network_Adapter_Settings_Tool__Win_10_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dropDownComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionSelectionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dropDownComboBox
            // 
            this.dropDownComboBox.AllowDrop = true;
            this.dropDownComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownComboBox.FormattingEnabled = true;
            this.dropDownComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dropDownComboBox.Items.AddRange(new object[] {
            "Ethernet",
            "Ethernet 2",
            "Ethernet 3",
            "Ethernet 4",
            "Ethernet 5",
            " ",
            "Wi-Fi",
            "Wi-Fi 2",
            "Wi-Fi 3",
            "Wi-Fi 4",
            "Wi-Fi 5"});
            this.dropDownComboBox.Location = new System.Drawing.Point(12, 78);
            this.dropDownComboBox.Name = "dropDownComboBox";
            this.dropDownComboBox.Size = new System.Drawing.Size(522, 30);
            this.dropDownComboBox.TabIndex = 2;
            this.dropDownComboBox.SelectedIndexChanged += new System.EventHandler(this.dropDownComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please choose a network adapter connection, that needs to\r\nbe enabled, from the d" +
    "rop down list below.";
            // 
            // connectionSelectionBtn
            // 
            this.connectionSelectionBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionSelectionBtn.Location = new System.Drawing.Point(12, 147);
            this.connectionSelectionBtn.Name = "connectionSelectionBtn";
            this.connectionSelectionBtn.Size = new System.Drawing.Size(522, 61);
            this.connectionSelectionBtn.TabIndex = 4;
            this.connectionSelectionBtn.Text = "Words go Here ";
            this.connectionSelectionBtn.UseVisualStyleBackColor = true;
            this.connectionSelectionBtn.Visible = false;
            this.connectionSelectionBtn.Click += new System.EventHandler(this.connectionSelectionBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 219);
            this.Controls.Add(this.connectionSelectionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Network Adapter Settings Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectionSelectionBtn;
        public System.Windows.Forms.ComboBox dropDownComboBox;
    }
}

