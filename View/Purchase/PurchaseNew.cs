using ManageIT.MedShop.Controller;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Purchase
{
    public partial class PurchaseNew : Form
    {
        public PurchaseNew()
        {
            InitializeComponent();
        }
        private void PurchaseNew_Load(object sender, EventArgs e)
        {
            init();
            fillComboBox();
            disableUpdate();
        }
        ///////////////////////////////// Custom Method /////////////////////////////////
        private void init()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTottal.Text = "";
            cbVender.Text = "";
            txtUnitPrice.Text = "";
            fillDataGridView();
        }
        private ArrayList getAllProduct()
        {
            return ProductController.getAllProduct();
        }
        private void fillDataGridView()
        {
            dgvProduct.DataSource = getAllProduct();
            dgvProduct.Columns.Remove("vender");
            dgvProduct.Refresh();
        }
        private void enableUpdate()
        {
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
        }
        private void disableUpdate()
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }
        private void fillComboBox()
        {
            ArrayList datasource = VenderController.getAllVenderNames();
            cbVender.DataSource = datasource;
        }
        private ArrayList searchProduct(string keyword)
        {
            return SearchController.searchForProduct(keyword);
        }
        private bool checkInput()
        {
            if (txtName.Text != "")
            {
                if (cbVender.Text != "")
                {
                    return true;
                }
            }
            return false;
        }
        ///////////////////////////////// Action Events ////////////////////////////////
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtName, e);
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtTottal, e);
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Rows[e.RowIndex].Selected = true;
            txtID.Text = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtName.Text = dgvProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtTottal.Text = dgvProduct.Rows[e.RowIndex].Cells["AmountLeft"].Value.ToString();
            txtUnitPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
            try
            {
                cbVender.Text = ProductController.getProduct(Int32.Parse(dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString())).vender.Name.ToString();
            }
            catch (Exception)
            {

                cbVender.Text = "None";
            }

            enableUpdate();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            init();
            disableUpdate();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                ArrayList dataSource = searchProduct(txtSearch.Text.Trim());
                if (dataSource != null)
                {
                    dgvProduct.DataSource = dataSource;
                    try
                    {
                        dgvProduct.Columns.Remove(dgvProduct.Columns[4]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No Item Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                dgvProduct.DataSource = getAllProduct();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (MessageBox.Show("ADD " + txtName.Text, "ARE YOU SURE ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (int)Utility.CodeUtility.UserStatus.Helper; //Int32.Parse(txtID.Text);
                    string name = txtName.Text.Trim();
                    string venderName = cbVender.Text;
                    double tottal = Double.Parse(txtTottal.Text.Trim());
                    double price = Double.Parse(txtUnitPrice.Text.Trim());
                    ProductController.addProduct(id, name, venderName, tottal, price);

                    MessageBox.Show("PRODUCT ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    init();
                }
            }
            else
            {
                MessageBox.Show("ALL INFORMATION MUST BE FILLED !!", "CHECK INPUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if ((MessageBox.Show("DELETE " + txtName.Text, "ARE YOU SURE ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes))
                {
                    ProductController.deleteProduct(Int32.Parse(txtID.Text.Trim()));
                    MessageBox.Show("Product Deleted".ToUpper(), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    init();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if ((MessageBox.Show("UPDATE " + txtName.Text, "ARE YOU SURE ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes))
                {
                    int id = Int32.Parse(txtID.Text);
                    string name = txtName.Text.Trim();
                    string venderName = cbVender.Text;
                    double tottal = Double.Parse(txtTottal.Text.Trim());
                    double price = Double.Parse(txtUnitPrice.Text.Trim());

                    ProductController.updateProduct(id, name, tottal, price);
                    MessageBox.Show("Product Updated".ToUpper(), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    init();
                }
            }
        }
    }
}
