﻿namespace joguinho3
{
    partial class Form5
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
            grpBxPergunta = new GroupBox();
            rdBtn4 = new RadioButton();
            rdBtn3 = new RadioButton();
            rdBtn2 = new RadioButton();
            rdBtn1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            grpBxPergunta.SuspendLayout();
            SuspendLayout();
            // 
            // grpBxPergunta
            // 
            grpBxPergunta.Controls.Add(rdBtn4);
            grpBxPergunta.Controls.Add(rdBtn3);
            grpBxPergunta.Controls.Add(rdBtn2);
            grpBxPergunta.Controls.Add(rdBtn1);
            grpBxPergunta.FlatStyle = FlatStyle.Flat;
            grpBxPergunta.Font = new Font("Eight Bit Dragon", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBxPergunta.Location = new Point(43, 74);
            grpBxPergunta.Name = "grpBxPergunta";
            grpBxPergunta.Size = new Size(448, 152);
            grpBxPergunta.TabIndex = 5;
            grpBxPergunta.TabStop = false;
            grpBxPergunta.Text = "groupBox1";
            // 
            // rdBtn4
            // 
            rdBtn4.AutoSize = true;
            rdBtn4.Location = new Point(27, 116);
            rdBtn4.Name = "rdBtn4";
            rdBtn4.Size = new Size(115, 16);
            rdBtn4.TabIndex = 3;
            rdBtn4.TabStop = true;
            rdBtn4.Text = "radioButton1";
            rdBtn4.UseVisualStyleBackColor = true;
            // 
            // rdBtn3
            // 
            rdBtn3.AutoSize = true;
            rdBtn3.Location = new Point(27, 91);
            rdBtn3.Name = "rdBtn3";
            rdBtn3.Size = new Size(115, 16);
            rdBtn3.TabIndex = 2;
            rdBtn3.TabStop = true;
            rdBtn3.Text = "radioButton1";
            rdBtn3.UseVisualStyleBackColor = true;
            // 
            // rdBtn2
            // 
            rdBtn2.AutoSize = true;
            rdBtn2.Location = new Point(27, 66);
            rdBtn2.Name = "rdBtn2";
            rdBtn2.Size = new Size(115, 16);
            rdBtn2.TabIndex = 1;
            rdBtn2.TabStop = true;
            rdBtn2.Text = "radioButton1";
            rdBtn2.UseVisualStyleBackColor = true;
            // 
            // rdBtn1
            // 
            rdBtn1.AutoSize = true;
            rdBtn1.Location = new Point(27, 41);
            rdBtn1.Name = "rdBtn1";
            rdBtn1.Size = new Size(115, 16);
            rdBtn1.TabIndex = 0;
            rdBtn1.TabStop = true;
            rdBtn1.Text = "radioButton1";
            rdBtn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Eight Bit Dragon", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 12);
            label1.TabIndex = 4;
            label1.Text = "PERGUNTA PARA P2";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Eight Bit Dragon", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(216, 247);
            button1.Name = "button1";
            button1.Size = new Size(97, 43);
            button1.TabIndex = 3;
            button1.Text = "Confirmar resposta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 313);
            Controls.Add(grpBxPergunta);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            grpBxPergunta.ResumeLayout(false);
            grpBxPergunta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBxPergunta;
        private RadioButton rdBtn4;
        private RadioButton rdBtn3;
        private RadioButton rdBtn2;
        private RadioButton rdBtn1;
        private Label label1;
        private Button button1;
    }
}