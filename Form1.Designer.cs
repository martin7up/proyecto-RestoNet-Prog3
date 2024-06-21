using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace borrador_RestoNet_Prog3
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
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 426);
            panel1.TabIndex = 1;
            panel1.DragOver += panel1_DragOver;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(839, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 426);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(5, 243);
            button4.Name = "button4";
            button4.Size = new Size(75, 72);
            button4.TabIndex = 3;
            button4.Text = "Mesa p/ 5Personas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(5, 165);
            button3.Name = "button3";
            button3.Size = new Size(75, 72);
            button3.TabIndex = 2;
            button3.Text = "Mesa p/ 4Personas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(5, 90);
            button2.Name = "button2";
            button2.Size = new Size(75, 69);
            button2.TabIndex = 1;
            button2.Text = "Mesa p/ 3Personas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(5, 17);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(75, 70);
            button1.TabIndex = 0;
            button1.Text = "Mesa p/ 2Personas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private bool botonIzqPresionado;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button nuevoComponente, aux;
        private Point absPoint, relPoint;
    }
}
