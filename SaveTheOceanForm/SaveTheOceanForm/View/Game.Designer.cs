namespace SaveTheOceanForm.View
{
    partial class Game
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
            gameTitle_lbl = new Label();
            DBAccess = new Button();
            gameChoice_lbl = new Label();
            CreateAnimal = new Button();
            RescueDGV = new DataGridView();
            ExtraInfoBtn = new Button();
            ExtraInfoDGV = new DataGridView();
            NotInfoYetError = new ErrorProvider(components);
            Heal = new Button();
            Move = new Button();
            Leave = new Button();
            DBAccessExtra = new Button();
            CetaceanIncident = new ErrorProvider(components);
            ExtraInfoDGVError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)RescueDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExtraInfoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotInfoYetError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CetaceanIncident).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExtraInfoDGVError).BeginInit();
            SuspendLayout();
            // 
            // gameTitle_lbl
            // 
            gameTitle_lbl.AutoSize = true;
            gameTitle_lbl.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameTitle_lbl.Location = new Point(258, 9);
            gameTitle_lbl.Name = "gameTitle_lbl";
            gameTitle_lbl.Size = new Size(276, 38);
            gameTitle_lbl.TabIndex = 0;
            gameTitle_lbl.Text = "SAVE THE OCEAN!";
            gameTitle_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // DBAccess
            // 
            DBAccess.Location = new Point(296, 69);
            DBAccess.Name = "DBAccess";
            DBAccess.Size = new Size(90, 23);
            DBAccess.TabIndex = 1;
            DBAccess.Text = "Base de datos";
            DBAccess.UseVisualStyleBackColor = true;
            DBAccess.Click += DBAccess_Click;
            // 
            // gameChoice_lbl
            // 
            gameChoice_lbl.AutoSize = true;
            gameChoice_lbl.Font = new Font("Segoe UI", 10F);
            gameChoice_lbl.Location = new Point(319, 47);
            gameChoice_lbl.Name = "gameChoice_lbl";
            gameChoice_lbl.Size = new Size(131, 19);
            gameChoice_lbl.TabIndex = 2;
            gameChoice_lbl.Text = "Que prefieres hacer:";
            // 
            // CreateAnimal
            // 
            CreateAnimal.Location = new Point(392, 69);
            CreateAnimal.Name = "CreateAnimal";
            CreateAnimal.Size = new Size(90, 23);
            CreateAnimal.TabIndex = 3;
            CreateAnimal.Text = "Crear entrada";
            CreateAnimal.UseVisualStyleBackColor = true;
            CreateAnimal.Click += CreateAnimal_Click;
            // 
            // RescueDGV
            // 
            RescueDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            RescueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RescueDGV.Location = new Point(161, 98);
            RescueDGV.Name = "RescueDGV";
            RescueDGV.Size = new Size(460, 94);
            RescueDGV.TabIndex = 4;
            // 
            // ExtraInfoBtn
            // 
            ExtraInfoBtn.Location = new Point(334, 207);
            ExtraInfoBtn.Name = "ExtraInfoBtn";
            ExtraInfoBtn.Size = new Size(126, 23);
            ExtraInfoBtn.TabIndex = 5;
            ExtraInfoBtn.Text = "Información extra";
            ExtraInfoBtn.UseVisualStyleBackColor = true;
            ExtraInfoBtn.Click += ExtraInfoBtn_Click;
            // 
            // ExtraInfoDGV
            // 
            ExtraInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExtraInfoDGV.Location = new Point(170, 248);
            ExtraInfoDGV.Name = "ExtraInfoDGV";
            ExtraInfoDGV.Size = new Size(445, 99);
            ExtraInfoDGV.TabIndex = 6;
            ExtraInfoDGV.Visible = false;
            // 
            // NotInfoYetError
            // 
            NotInfoYetError.ContainerControl = this;
            // 
            // Heal
            // 
            Heal.Location = new Point(305, 353);
            Heal.Name = "Heal";
            Heal.Size = new Size(81, 23);
            Heal.TabIndex = 7;
            Heal.Text = "CURAR";
            Heal.UseVisualStyleBackColor = true;
            Heal.Click += Heal_Click;
            // 
            // Move
            // 
            Move.Location = new Point(392, 353);
            Move.Name = "Move";
            Move.Size = new Size(81, 23);
            Move.TabIndex = 8;
            Move.Text = "TRASLADAR";
            Move.UseVisualStyleBackColor = true;
            Move.Click += Move_Click;
            // 
            // Leave
            // 
            Leave.Location = new Point(354, 382);
            Leave.Name = "Leave";
            Leave.Size = new Size(75, 23);
            Leave.TabIndex = 9;
            Leave.Text = "SALIR";
            Leave.UseVisualStyleBackColor = true;
            Leave.Click += Leave_Click;
            // 
            // DBAccessExtra
            // 
            DBAccessExtra.Location = new Point(642, 399);
            DBAccessExtra.Name = "DBAccessExtra";
            DBAccessExtra.Size = new Size(130, 23);
            DBAccessExtra.TabIndex = 10;
            DBAccessExtra.Text = "Extras (base de datos)";
            DBAccessExtra.UseVisualStyleBackColor = true;
            DBAccessExtra.Click += DBAccessExtra_Click;
            // 
            // CetaceanIncident
            // 
            CetaceanIncident.ContainerControl = this;
            // 
            // ExtraInfoDGVError
            // 
            ExtraInfoDGVError.ContainerControl = this;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DBAccessExtra);
            Controls.Add(Leave);
            Controls.Add(Move);
            Controls.Add(Heal);
            Controls.Add(ExtraInfoDGV);
            Controls.Add(ExtraInfoBtn);
            Controls.Add(RescueDGV);
            Controls.Add(CreateAnimal);
            Controls.Add(gameChoice_lbl);
            Controls.Add(DBAccess);
            Controls.Add(gameTitle_lbl);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)RescueDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExtraInfoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotInfoYetError).EndInit();
            ((System.ComponentModel.ISupportInitialize)CetaceanIncident).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExtraInfoDGVError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameTitle_lbl;
        private Button DBAccess;
        private Label gameChoice_lbl;
        private Button CreateAnimal;
        private DataGridView RescueDGV;
        private Button ExtraInfoBtn;
        private DataGridView ExtraInfoDGV;
        private ErrorProvider NotInfoYetError;
        private Button Move;
        private Button Heal;
        private Button Leave;
        private Button DBAccessExtra;
        private ErrorProvider CetaceanIncident;
        private ErrorProvider ExtraInfoDGVError;
    }
}