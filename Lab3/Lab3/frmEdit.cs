using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmEdit : Form
    {
        private DataGridView dgvForm1;
        public frmEdit(DataGridView dgv)
        {
            InitializeComponent();
            dgvForm1 = dgv;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isSeriesValid = (txtSeriesEdit.Text).All(Char.IsDigit) && (txtSeriesEdit.Text != "") && (txtSeriesEdit.Text.Length <= 2);
            bool isAlphaValid = (txtAlphaEdit.Text).All(Char.IsLetter) && (txtAlphaEdit.Text != "") && (txtAlphaEdit.Text.Length == 1);
            double pricePaid;
            bool isPricePaidValid = Double.TryParse(txtPriceEdit.Text, out pricePaid);

            if (isSeriesValid && isAlphaValid && isPricePaidValid && isPricePaidValid)
            {

                dgvForm1.CurrentRow.Cells[0].Value = txtSeriesEdit.Text;
                dgvForm1.CurrentRow.Cells[1].Value = txtAlphaEdit.Text;
                dgvForm1.CurrentRow.Cells[2].Value = comboVariationEdit.SelectedItem.ToString();
                dgvForm1.CurrentRow.Cells[3].Value = GetImageFromUrl(txtPictureEdit.Text);
                dgvForm1.CurrentRow.Cells[5].Value = txtNoteEdit.Text;
                dgvForm1.CurrentRow.Cells[6].Value = comboConditionEdit.SelectedItem.ToString();
                dgvForm1.CurrentRow.Cells[7].Value = pricePaid.ToString();

                this.Close();
            } else
            {
                errorEdit.Clear();
                if (!isSeriesValid)
                    errorEdit.SetError(txtSeriesEdit, "Please enter in a number between 1-75.");
                if (!isAlphaValid)
                    errorEdit.SetError(txtAlphaEdit, "Please enter in a character between a-f");
                if (isPricePaidValid)
                    errorEdit.SetError(txtPriceEdit, "Please enter in a valid price (i.e. xxx.xx");
            }


        }

        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
