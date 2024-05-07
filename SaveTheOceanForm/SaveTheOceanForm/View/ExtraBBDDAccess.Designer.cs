namespace SaveTheOceanForm.View
{
    partial class ExtraBBDDAccess
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
            RescuesDGV = new DataGridView();
            ExtraTitle_lbl = new Label();
            GetAllBtn = new Button();
            ResCodes_ComboBox = new ComboBox();
            GetById = new Button();
            ExtrasDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RescuesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExtrasDGV).BeginInit();
            SuspendLayout();
            // 
            // RescuesDGV
            // 
            RescuesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RescuesDGV.Location = new Point(144, 130);
            RescuesDGV.Name = "RescuesDGV";
            RescuesDGV.Size = new Size(544, 132);
            RescuesDGV.TabIndex = 0;
            // 
            // ExtraTitle_lbl
            // 
            ExtraTitle_lbl.AutoSize = true;
            ExtraTitle_lbl.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExtraTitle_lbl.Location = new Point(385, 19);
            ExtraTitle_lbl.Name = "ExtraTitle_lbl";
            ExtraTitle_lbl.Size = new Size(90, 27);
            ExtraTitle_lbl.TabIndex = 1;
            ExtraTitle_lbl.Text = "EXTRAS";
            // 
            // GetAllBtn
            // 
            GetAllBtn.Location = new Point(306, 49);
            GetAllBtn.Name = "GetAllBtn";
            GetAllBtn.Size = new Size(113, 23);
            GetAllBtn.TabIndex = 2;
            GetAllBtn.Text = "MOSTRAR TODOS";
            GetAllBtn.UseVisualStyleBackColor = true;
            GetAllBtn.Click += GetAllBtn_Click;
            // 
            // ResCodes_ComboBox
            // 
            ResCodes_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ResCodes_ComboBox.FormattingEnabled = true;
            ResCodes_ComboBox.Location = new Point(365, 78);
            ResCodes_ComboBox.Name = "ResCodes_ComboBox";
            ResCodes_ComboBox.Size = new Size(121, 23);
            ResCodes_ComboBox.TabIndex = 3;
            // 
            // GetById
            // 
            GetById.Location = new Point(425, 49);
            GetById.Name = "GetById";
            GetById.Size = new Size(113, 23);
            GetById.TabIndex = 4;
            GetById.Text = "BUSCAR POR ID";
            GetById.UseVisualStyleBackColor = true;
            GetById.Click += GetById_Click;
            // 
            // ExtrasDGV
            // 
            ExtrasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExtrasDGV.Location = new Point(191, 268);
            ExtrasDGV.Name = "ExtrasDGV";
            ExtrasDGV.Size = new Size(443, 132);
            ExtrasDGV.TabIndex = 5;
            // 
            // ExtraBBDDAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExtrasDGV);
            Controls.Add(GetById);
            Controls.Add(ResCodes_ComboBox);
            Controls.Add(GetAllBtn);
            Controls.Add(ExtraTitle_lbl);
            Controls.Add(RescuesDGV);
            Name = "ExtraBBDDAccess";
            Text = "ExtraBBDDAccess";
            Load += ExtraBBDDAccess_Load;
            ((System.ComponentModel.ISupportInitialize)RescuesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExtrasDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RescuesDGV;
        private Label ExtraTitle_lbl;
        private Button GetAllBtn;
        private ComboBox ResCodes_ComboBox;
        private Button GetById;
        private DataGridView ExtrasDGV;
    }
}