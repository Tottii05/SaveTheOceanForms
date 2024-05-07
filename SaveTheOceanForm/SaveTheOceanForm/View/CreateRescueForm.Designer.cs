namespace SaveTheOceanForm.View
{
    partial class CreateRescueForm
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
            components = new System.ComponentModel.Container();
            CreateTitle_lbl = new Label();
            location_TextBox = new TextBox();
            name_TextBox = new TextBox();
            specie_TextBox = new TextBox();
            weight_TextBox = new TextBox();
            family_lbl = new Label();
            location_lbl = new Label();
            name_lbl = new Label();
            specie_lbl = new Label();
            weight_lbl = new Label();
            CreateRescueBtn = new Button();
            EmptyError = new ErrorProvider(components);
            NotNumberError = new ErrorProvider(components);
            superFamily_ComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)EmptyError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotNumberError).BeginInit();
            SuspendLayout();
            // 
            // CreateTitle_lbl
            // 
            CreateTitle_lbl.AutoSize = true;
            CreateTitle_lbl.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTitle_lbl.Location = new Point(12, 9);
            CreateTitle_lbl.Name = "CreateTitle_lbl";
            CreateTitle_lbl.Size = new Size(298, 29);
            CreateTitle_lbl.TabIndex = 0;
            CreateTitle_lbl.Text = "ENTRADA PERSONALIZADA";
            // 
            // location_TextBox
            // 
            location_TextBox.Location = new Point(107, 125);
            location_TextBox.Name = "location_TextBox";
            location_TextBox.Size = new Size(100, 23);
            location_TextBox.TabIndex = 2;
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new Point(107, 169);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(100, 23);
            name_TextBox.TabIndex = 3;
            // 
            // specie_TextBox
            // 
            specie_TextBox.Location = new Point(107, 213);
            specie_TextBox.Name = "specie_TextBox";
            specie_TextBox.Size = new Size(100, 23);
            specie_TextBox.TabIndex = 4;
            // 
            // weight_TextBox
            // 
            weight_TextBox.Location = new Point(107, 258);
            weight_TextBox.Name = "weight_TextBox";
            weight_TextBox.Size = new Size(100, 23);
            weight_TextBox.TabIndex = 5;
            // 
            // family_lbl
            // 
            family_lbl.AutoSize = true;
            family_lbl.Location = new Point(122, 63);
            family_lbl.Name = "family_lbl";
            family_lbl.Size = new Size(73, 15);
            family_lbl.TabIndex = 6;
            family_lbl.Text = "Superfamília";
            // 
            // location_lbl
            // 
            location_lbl.AutoSize = true;
            location_lbl.Location = new Point(122, 107);
            location_lbl.Name = "location_lbl";
            location_lbl.Size = new Size(72, 15);
            location_lbl.TabIndex = 7;
            location_lbl.Text = "Localización";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(132, 151);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(51, 15);
            name_lbl.TabIndex = 8;
            name_lbl.Text = "Nombre";
            // 
            // specie_lbl
            // 
            specie_lbl.AutoSize = true;
            specie_lbl.Location = new Point(133, 195);
            specie_lbl.Name = "specie_lbl";
            specie_lbl.Size = new Size(46, 15);
            specie_lbl.TabIndex = 9;
            specie_lbl.Text = "Especie";
            // 
            // weight_lbl
            // 
            weight_lbl.AutoSize = true;
            weight_lbl.Location = new Point(140, 240);
            weight_lbl.Name = "weight_lbl";
            weight_lbl.Size = new Size(32, 15);
            weight_lbl.TabIndex = 10;
            weight_lbl.Text = "Peso";
            // 
            // CreateRescueBtn
            // 
            CreateRescueBtn.Location = new Point(120, 287);
            CreateRescueBtn.Name = "CreateRescueBtn";
            CreateRescueBtn.Size = new Size(75, 23);
            CreateRescueBtn.TabIndex = 11;
            CreateRescueBtn.Text = "CREAR";
            CreateRescueBtn.UseVisualStyleBackColor = true;
            CreateRescueBtn.Click += CreateRescueBtn_Click;
            // 
            // EmptyError
            // 
            EmptyError.ContainerControl = this;
            // 
            // NotNumberError
            // 
            NotNumberError.ContainerControl = this;
            // 
            // superFamily_ComboBox
            // 
            superFamily_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            superFamily_ComboBox.FormattingEnabled = true;
            superFamily_ComboBox.Location = new Point(107, 81);
            superFamily_ComboBox.Name = "superFamily_ComboBox";
            superFamily_ComboBox.Size = new Size(100, 23);
            superFamily_ComboBox.TabIndex = 12;
            // 
            // CreateRescueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 338);
            Controls.Add(superFamily_ComboBox);
            Controls.Add(CreateRescueBtn);
            Controls.Add(weight_lbl);
            Controls.Add(specie_lbl);
            Controls.Add(name_lbl);
            Controls.Add(location_lbl);
            Controls.Add(family_lbl);
            Controls.Add(weight_TextBox);
            Controls.Add(specie_TextBox);
            Controls.Add(name_TextBox);
            Controls.Add(location_TextBox);
            Controls.Add(CreateTitle_lbl);
            Name = "CreateRescueForm";
            Text = "CreateRescueForm";
            Load += CreateRescueForm_Load;
            ((System.ComponentModel.ISupportInitialize)EmptyError).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotNumberError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTitle_lbl;
        private TextBox location_TextBox;
        private TextBox name_TextBox;
        private TextBox specie_TextBox;
        private TextBox weight_TextBox;
        private Label family_lbl;
        private Label location_lbl;
        private Label name_lbl;
        private Label specie_lbl;
        private Label weight_lbl;
        private Button CreateRescueBtn;
        private ErrorProvider EmptyError;
        private ErrorProvider NotNumberError;
        private ComboBox superFamily_ComboBox;
    }
}