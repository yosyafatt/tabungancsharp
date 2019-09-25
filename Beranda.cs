using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabungan_GUI
{
    public partial class Beranda : Form
    {
        Tabungan tab = new Tabungan(25000);

        public Beranda()
        {
            InitializeComponent();
        }

        private void Beranda_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (radioIDR.Checked == true)
            {
                bool status = tab.tarikUangIDR(int.Parse(nominalTarik.Text));
                if (status == true)
                {
                    MessageBox.Show("Silahkan Ambil Uang Anda.");
                    label4.Text = tab.getSaldo().ToString();
                } else
                {
                    MessageBox.Show("Saldo anda tidak mencukupi");
                }
            }
            else if (radioUSD.Checked == true)
            {
                bool status = tab.tarikUangUSD(int.Parse(nominalTarik.Text));
                if (status == true)
                {
                    MessageBox.Show("Silahkan Ambil Uang Anda.");
                    label4.Text = tab.getSaldo().ToString();
                }
                else
                {
                    MessageBox.Show("Saldo anda tidak mencukupi");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label4.Text = tab.getSaldo().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int nom = int.Parse(nominalSetor.Text);
            if (nom > 5000)
            {
                bool status = tab.setorUang(nom);
                if (status == true)
                {
                    MessageBox.Show("Transaksi berhasil.");
                    label4.Text = tab.getSaldo().ToString();
                }
                else
                {
                    MessageBox.Show("Saldo anda tidak mencukupi");
                }
            } else
            {
                MessageBox.Show("Uang yang anda setor kurang dari syarat minimum");

            }

        }
    }
}
