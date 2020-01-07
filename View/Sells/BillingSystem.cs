using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iTextSharp.text; //for ItextSharp
//using iTextSharp.text.pdf; //for ItextSharp ->> PDF
using System.IO; //for Input and Output
using ManageIT.MedShop.Controller;
using ManageIT.MedShop.Model;

namespace ManageIT.MedShop.View.Sells
{
    public partial class BillingSystem : Form
    {
        ArrayList billProduct = new ArrayList();
        public BillingSystem()
        {
            InitializeComponent();
            
        }
        private void createInvoice()
        {
            billProduct.Add(BillingController.createInvoice());
            dgvItemTable.DataSource = billProduct;
            dgvItemTable.Refresh();
        }
        private string getTottal(string amount,string price)
        {
            double Amount = double.Parse(amount);
            double Price = double.Parse(price);
            double Tottal = Amount * Price;

            return Tottal.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            createInvoice();
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text != "")
            {
                dgvSearchView.DataSource = SearchController.searchForProduct(txtProductName.Text.Trim());
                try
                {
                    dgvSearchView.Columns.Remove("ID");
                    dgvSearchView.Columns.Remove("AmountLeft");
                    dgvSearchView.Columns.Remove("vender");
                    dgvSearchView.Rows[0].Selected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("No ItemFound", "NOT FOUND");
                }
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar.Equals((Char)Keys.Enter))
            {
                if (dgvSearchView.SelectedRows.Count == 1)
                {
                    txtProductName.Text = dgvSearchView.Rows[0].Cells[0].Value.ToString();
                    txtUnitPrice.Text = ProductController.getProductByName(txtProductName.Text).UnitPrice.ToString();
                    txtProductId.Text = ProductController.getProductByName(txtProductName.Text).ID.ToString();
                }
                Utility.FramesUtility.FocusOn(txtQuantity, e);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
                if (txtUnitPrice.Text != "")
                {
                    txtAmount.Text = getTottal(txtQuantity.Text.Trim(), txtUnitPrice.Text.Trim());
                }
            }
            else
            {
                txtAmount.Text = "0.00";
            }
        }
    }
}
