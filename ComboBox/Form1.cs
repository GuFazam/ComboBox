using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
           string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Janeiro";
                        break;

                case 2:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Fevereiro";
                       break;

                case 3:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Março";
                       break;

                case 4:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Abril";
                    break;

                case 5:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Maio";
                    break;

                case 6:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Junho";
                    break;

                case 7:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Julho";
                    break;

                case 8:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Agosto";
                    break;

                case 9:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Setembro";
                    break;

                case 10:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Outubro";
                    break;

                case 11:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Novembro";
                    break;

                case 12:
                    label2.Text = "Olá " + textBoxNome.Text + "Você nasceu em Dezembro";
                    break;

                default:
                    label2.Text = "Por favor escolha uma opção de números, MÊS não encontrado";
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
