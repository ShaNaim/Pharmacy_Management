using ManageIT.MedShop.Controller;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Purchase
{
    public partial class PurchaseMain : Form
    {
        public PurchaseMain()
        {
            InitializeComponent();
        }
        ///////////////////////////////// Custom Method /////////////////////////////////
        private ArrayList searchProduct(string productName)
        {
            return SearchController.searchForProduct(productName);
        }
        ///////////////////////////////// Action Events /////////////////////////////////
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtAmount, e);
        private void TxtVender_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtPrice, e);
        private void PurchaseMain_Load(object sender, EventArgs e)
        {

        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Rows[e.RowIndex].Selected = true;
            txtID.Text = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtName.Text = dgvProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtAmount.Text = dgvProduct.Rows[e.RowIndex].Cells["AmountLeft"].Value.ToString();
            txtVender.Text = dgvProduct.Rows[e.RowIndex].Cells["VenderId"].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            dtpPurchaseDate.Value = DateTime.Parse(dgvProduct.Rows[e.RowIndex].Cells["PurchaseDate"].Value.ToString());
        }
        private void txtSearchMed_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchMed.Text != "")
            {
                ArrayList dataSource = searchProduct(txtSearchMed.Text.Trim());
                if (dataSource != null)
                {
                    dgvSearchView.DataSource = dataSource;
                    try
                    {
                        dgvSearchView.Columns.Remove(dgvSearchView.Columns[4]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No Item Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                dgvSearchView.DataSource = "";
            }
        }
        private void dgvSearchView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSearchView.Rows[e.RowIndex].Selected = true;
            txtID.Text = dgvSearchView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtName.Text = dgvSearchView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtAmount.Text = dgvSearchView.Rows[e.RowIndex].Cells["AmountLeft"].Value.ToString();
            txtVender.Text = dgvSearchView.Rows[e.RowIndex].Cells["VenderId"].Value.ToString();
        }
    }
}
