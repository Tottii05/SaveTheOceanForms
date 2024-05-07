namespace SaveTheOceanForm.View
{
    partial class PlayerForm
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
            name_lbl = new Label();
            name_TextBox = new TextBox();
            role_lbl = new Label();
            role_ComboBox = new ComboBox();
            create_lbl = new Label();
            Create = new Button();
            NameError = new ErrorProvider(components);
            RoleError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoleError).BeginInit();
            SuspendLayout();
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(93, 55);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(54, 15);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Nombre:";
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new Point(71, 73);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(100, 23);
            name_TextBox.TabIndex = 1;
            // 
            // role_lbl
            // 
            role_lbl.AutoSize = true;
            role_lbl.Location = new Point(107, 99);
            role_lbl.Name = "role_lbl";
            role_lbl.Size = new Size(27, 15);
            role_lbl.TabIndex = 2;
            role_lbl.Text = "Rol:";
            // 
            // role_ComboBox
            // 
            role_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            role_ComboBox.FormattingEnabled = true;
            role_ComboBox.Location = new Point(71, 117);
            role_ComboBox.Name = "role_ComboBox";
            role_ComboBox.Size = new Size(100, 23);
            role_ComboBox.TabIndex = 3;
            // 
            // create_lbl
            // 
            create_lbl.AutoSize = true;
            create_lbl.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_lbl.Location = new Point(15, 21);
            create_lbl.Name = "create_lbl";
            create_lbl.Size = new Size(211, 25);
            create_lbl.TabIndex = 4;
            create_lbl.Text = "CREA TU PERSONAJE";
            // 
            // Create
            // 
            Create.Location = new Point(81, 185);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 5;
            Create.Text = "CREAR";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // NameError
            // 
            NameError.ContainerControl = this;
            // 
            // RoleError
            // 
            RoleError.ContainerControl = this;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 255);
            Controls.Add(Create);
            Controls.Add(create_lbl);
            Controls.Add(role_ComboBox);
            Controls.Add(role_lbl);
            Controls.Add(name_TextBox);
            Controls.Add(name_lbl);
            Name = "PlayerForm";
            Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)NameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoleError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private TextBox name_TextBox;
        private Label role_lbl;
        private ComboBox role_ComboBox;
        private Label create_lbl;
        private Button Create;
        private ErrorProvider NameError;
        private ErrorProvider RoleError;
    }
}