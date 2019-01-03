using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void SoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        static int A, B;
        private void KetQua_Click_1(object sender, EventArgs e)
        {


            if (Int32.TryParse(SoA.Text, out A) && Int32.TryParse(SoB.Text, out B))
            {
                A = int.Parse(SoA.Text);
                B = int.Parse(SoB.Text);
            }
            else
            {
              DialogResult result =  MessageBox.Show("Bạn chưa nhập A hoặc B", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Cancel:
                        Environment.Exit(0);
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.No:
                       
                        break;
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Retry:
                        Form1 d = new Form1();
                        this.Hide();
                        d.ShowDialog();
                        this.Close();
                        break;
                    case DialogResult.Yes:
                       
                        break;
                    default:
                        break;
                }

            }




            float ketqua;
            switch (chon.GetItemText(chon.SelectedItem))
            {
                case "Cộng":
                    ketqua = A + B;
                    KetQua.Text = ketqua.ToString();
                    break;
                case "Trừ":
                    ketqua = A - B;
                    KetQua.Text = ketqua.ToString();
                    break;
                case "Nhân":
                    ketqua = A * B;
                    KetQua.Text = ketqua.ToString();
                    break;
                case "Chia":

                    if (B != 0)
                    {
                        ketqua = A / B;
                        KetQua.Text = ketqua.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("Sai rồi thằng lồn", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    break;
                default:
                    MessageBox.Show("Mày có chọn cái đéo gì đâu", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    break;
            }
        }
    }
}
