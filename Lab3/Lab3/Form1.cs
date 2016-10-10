using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool isSeriesValid = (txtSeries.Text).All(Char.IsDigit) && (txtSeries.Text != "" && (txtSeries.Text.Length <= 2));
            bool isAlphaValid = (txtAlpha.Text).All(Char.IsLetter) && (txtAlpha.Text != "") && (txtAlpha.Text.Length == 1);
            double pricePaid;
            bool isPricePaidValid = Double.TryParse(txtPrice.Text, out pricePaid);

            if (isSeriesValid && isAlphaValid && isPricePaidValid && isPricePaidValid)
            {
                string seriesID = txtSeries.Text;
                string alphaID = txtAlpha.Text;
                string variationID = comboVariation.SelectedItem.ToString();
                string picture = txtPicture.Text;
                string URL = txtPicture.Text;
                string note = txtNote.Text;
                string condition = comboCondition.SelectedItem.ToString();
                
                

                gridCars.Rows.Add(seriesID, alphaID, variationID, GetImageFromUrl(picture),URL, note, condition, pricePaid);

                txtSeries.Clear();
                txtAlpha.Clear();
                comboVariation.SelectedIndex = -1;
                txtPicture.Clear();
                txtNote.Clear();
                comboCondition.SelectedIndex = -1;
                txtPrice.Clear();
                errorProvider1.Clear();

                txtSeries.Focus();

            }
            else
            {
                errorProvider1.Clear();
                if (!isSeriesValid)
                    errorProvider1.SetError(txtSeries, "Please enter in a number between 1-75.");
                if (!isAlphaValid)
                    errorProvider1.SetError(txtAlpha, "Please enter in a character between a-f");
                if (isPricePaidValid)
                    errorProvider1.SetError(txtPrice, "Please enter in a valid price (i.e. xxx.xx");
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


        private void txtPicture_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colPicture.Width = 150;
            colPicture.ImageLayout = DataGridViewImageCellLayout.Stretch;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            gridCars.Rows.Add("65", "a", "Green", GetImageFromUrl("http://www.fcarnahan.com/img/75i/67a1.jpg"), "http://www.fcarnahan.com/img/75i/67a1.jpg", "Around 100k miles driven", "Good", "20.40");
            gridCars.Rows.Add("12", "f", "Red", GetImageFromUrl("http://www.fcarnahan.com/img/75i/67b1.jpg"), "http://www.fcarnahan.com/img/75i/67b1.jpg", "A couple of scratches, still pretty much mint!", "Minor Damage", "40.65");
            gridCars.Rows.Add("75", "b", "Red", GetImageFromUrl("http://www.fcarnahan.com/img/75i/71b2.jpg"), "http://www.fcarnahan.com/img/75i/71b2.jpg", "Present from grandson, still in box", "Perfect", "50.50");
            gridCars.Rows.Add("1", "d", "Red", GetImageFromUrl("http://www.fcarnahan.com/img/9i/5c1.jpg"), "http://www.fcarnahan.com/img/9i/5c1.jpg", "Tires have some wear on them", "Fair", "10.40");
            gridCars.Rows.Add("45", "c", "Yellow", GetImageFromUrl("http://www.fcarnahan.com/img/19i/18e3.jpg"), "http://www.fcarnahan.com/img/19i/18e3.jpg", "Door broken off, still rides well", "Poor", "32.75");
            gridCars.Rows.Add("5", "a", "Green", GetImageFromUrl("http://www.fcarnahan.com/img/29i/21a1.jpg"), "http://www.fcarnahan.com/img/29i/21a1.jpg", "Polished every day", "Perfect", "85.00");
            gridCars.Rows.Add("33", "a", "Orange", GetImageFromUrl("http://www.fcarnahan.com/img/29i/28d1.jpg"), "http://www.fcarnahan.com/img/29i/28d1.jpg", "A couple scratches on the hood", "Good", "23.25");
            gridCars.Rows.Add("24", "e", "Yellow", GetImageFromUrl("http://www.fcarnahan.com/img/49i/42a1.jpg"), "http://www.fcarnahan.com/img/49i/42a1.jpg", "Around 2k miles driven", "Good", "5.75");
            gridCars.Rows.Add("52", "d", "White", GetImageFromUrl("http://www.fcarnahan.com/img/59i/54b1.jpg"), "http://www.fcarnahan.com/img/59i/54b1.jpg", "Some-what rare, one minor scratch", "Good", "1000");
            gridCars.Rows.Add("71", "f", "Blue", GetImageFromUrl("http://www.fcarnahan.com/img/59i/56b1.jpg"), "http://www.fcarnahan.com/img/59i/56b1.jpg", "Rarest car", "Perfect", "1000000");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit FrmEdit = new frmEdit(gridCars);
            
            FrmEdit.txtSeriesEdit.Text = gridCars.CurrentRow.Cells[0].Value.ToString();
            FrmEdit.txtAlphaEdit.Text = gridCars.CurrentRow.Cells[1].Value.ToString();
            FrmEdit.comboVariationEdit.SelectedItem = gridCars.CurrentRow.Cells[2].Value.ToString();
            FrmEdit.txtPictureEdit.Text = gridCars.CurrentRow.Cells[4].Value.ToString();
            FrmEdit.txtNoteEdit.Text = gridCars.CurrentRow.Cells[5].Value.ToString();
            FrmEdit.comboConditionEdit.SelectedItem = gridCars.CurrentRow.Cells[6].Value.ToString();
            FrmEdit.txtPriceEdit.Text = gridCars.CurrentRow.Cells[7].Value.ToString();


            FrmEdit.ShowDialog();

        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gridCars.SelectedRows)
            {
                gridCars.Rows.RemoveAt(item.Index);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
