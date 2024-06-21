using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Resto_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 270);
            this.panel1.TabIndex = 0;
            // 
            // labelBlue
            // 
            this.labelBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBlue.Location = new System.Drawing.Point(553, 13);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(90, 54);
            this.labelBlue.TabIndex = 1;
            this.labelBlue.Click += new System.EventHandler(this.LabelBlue_Click);
            // 
            // labelGreen
            // 
            this.labelGreen.BackColor = System.Drawing.Color.Green;
            this.labelGreen.Location = new System.Drawing.Point(659, 13);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(90, 54);
            this.labelGreen.TabIndex = 2;
            this.labelGreen.Click += new System.EventHandler(this.LabelGreen_Click);
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(552, 81);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(90, 54);
            this.labelRed.TabIndex = 3;
            this.labelRed.Click += new System.EventHandler(this.LabelRed_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(659, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 54);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
        private Point dragStartPoint;
        private Label draggedLabel;
        private List<Label> labels = new List<Label>();
        private Label label1;
    }
}

