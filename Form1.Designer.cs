namespace WinFormsApp1
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
            label1 = new Label();
            lblMensagem = new Label();
            btnMensagem = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            lblmensagem3 = new Label();
            lblmensagem2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = SystemColors.ControlLightLight;
            lblMensagem.Location = new Point(367, 180);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(32, 15);
            lblMensagem.TabIndex = 1;
            lblMensagem.Text = "teste";
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;
            lblMensagem.Click += label2_Click;
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(346, 234);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(75, 23);
            btnMensagem.TabIndex = 2;
            btnMensagem.Text = "Clique aqui";
            btnMensagem.TextAlign = ContentAlignment.TopLeft;
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += button1_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(321, 86);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(321, 122);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 4;
            // 
            // lblmensagem3
            // 
            lblmensagem3.AutoSize = true;
            lblmensagem3.ForeColor = SystemColors.ControlLightLight;
            lblmensagem3.Location = new Point(263, 89);
            lblmensagem3.Name = "lblmensagem3";
            lblmensagem3.Size = new Size(52, 15);
            lblmensagem3.TabIndex = 5;
            lblmensagem3.Text = "Primeiro";
            lblmensagem3.TextAlign = ContentAlignment.MiddleCenter;
            lblmensagem3.Click += label2_Click_1;
            // 
            // lblmensagem2
            // 
            lblmensagem2.AutoSize = true;
            lblmensagem2.ForeColor = SystemColors.ControlLightLight;
            lblmensagem2.Location = new Point(261, 125);
            lblmensagem2.Name = "lblmensagem2";
            lblmensagem2.Size = new Size(54, 15);
            lblmensagem2.TabIndex = 6;
            lblmensagem2.Text = "Segundo";
            lblmensagem2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmensagem2);
            Controls.Add(lblmensagem3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnMensagem);
            Controls.Add(lblMensagem);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMensagem;
        private Button btnMensagem;
        private TextBox txt1;
        private TextBox txt2;
        private Label lblmensagem3;
        private Label lblmensagem2;
    }
}
