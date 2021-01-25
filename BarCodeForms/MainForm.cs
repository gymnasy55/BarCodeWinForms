using System;
using System.Drawing;
using System.Windows.Forms;
using BarcodeLib;

namespace BarCodeForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMakeBarcode_Click(object sender, EventArgs e)
        {
            var text = txtText.Text;
            var barcode = new Barcode();
            var barcodeImage = barcode.Encode(TYPE.CODE128, text, Color.Black, Color.White, pictureBox1.Width - 20, pictureBox1.Height - 20);
            pictureBox1.Image = barcodeImage;
        }
    }
}
