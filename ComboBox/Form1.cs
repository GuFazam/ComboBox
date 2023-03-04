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
            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    label2.Text = "O mês 1 é equivalente a Janeiro";
                        break;

                case 2:
                    label2.Text = "O mês 2 é equivalente a Fevereiro";
                       break;

                case 3:
                    label2.Text = "O mês 3 é equivalente a Março";
                       break;

                case 4:
                    label2.Text = "O mês 4 é equivalente a Abril";
                       break;

                case 5:
                    label2.Text = "O mês 5 é equivalente a Maio";
                       break;

                case 6:
                    label2.Text = "O mês 6 é equivalente a Junho";
                       break;

                case 7:
                    label2.Text = "O mês 7 é equivalente a Julho";
                       break;

                case 8:
                    label2.Text = "O mês 8 é equivalente a Agosto";
                       break;

                case 9:
                    label2.Text = "O mês 9 é equivalente a Setembro";
                       break;

                case 10:
                    label2.Text = "O mês 10 é equivalente a Outubro";
                       break;

                case 11:
                    label2.Text = "O mês 11 é equivalente a Novembro";
                       break;

                case 12:
                    label2.Text = "O mês " + cmbEscolha.Text + "é equivalente a Dezembro";
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
