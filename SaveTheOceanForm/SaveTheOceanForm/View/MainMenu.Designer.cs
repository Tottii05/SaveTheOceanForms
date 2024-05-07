namespace SaveTheOceanForm
{
    partial class MainMenu
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
            Play = new Button();
            Leave = new Button();
            title_lbl = new Label();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Location = new Point(112, 60);
            Play.Name = "Play";
            Play.Size = new Size(75, 23);
            Play.TabIndex = 0;
            Play.Text = "JUGAR";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Leave
            // 
            Leave.Location = new Point(112, 89);
            Leave.Name = "Leave";
            Leave.Size = new Size(75, 23);
            Leave.TabIndex = 1;
            Leave.Text = "SALIR";
            Leave.UseVisualStyleBackColor = true;
            Leave.Click += Leave_Click;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.Location = new Point(39, 26);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(226, 16);
            title_lbl.TabIndex = 2;
            title_lbl.Text = "BIENVENIDO A SAVE THE OCEAN!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 156);
            Controls.Add(title_lbl);
            Controls.Add(Leave);
            Controls.Add(Play);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Leave;
        private Label title_lbl;
    }
}
