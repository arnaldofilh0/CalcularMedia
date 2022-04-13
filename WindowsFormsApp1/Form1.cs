using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double nota1, nota2, nota3, media;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            lblMedia.Text = media.ToString();

           
            if (media >= 7.0)
            {
                
                lblSituacao.Text = "Aluno Aprovado!";
            }
            else
            {
                
                lblSituacao.Text = "Aluno Reprovado!";

            }  
        }
    }
}
