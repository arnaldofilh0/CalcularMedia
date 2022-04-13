
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSit = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(13, 25);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(13, 51);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 0;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(13, 79);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 0;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(13, 128);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(36, 13);
            this.lblMed.TabIndex = 1;
            this.lblMed.Text = "Média";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(68, 128);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "lebel5";
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Location = new System.Drawing.Point(13, 175);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(49, 13);
            this.lblSit.TabIndex = 1;
            this.lblSit.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(68, 175);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(165, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(74, 22);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(110, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(74, 48);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(110, 20);
            this.txtNota2.TabIndex = 3;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(74, 76);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(110, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 268);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
    }
}

