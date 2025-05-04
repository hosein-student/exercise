using System.Diagnostics;

namespace exercise
{
    public partial class Form_price : Form
    {
        public Form_price()
        {
            InitializeComponent();
        }

        double CalculatePrice(int price, double tax = 0.1, double discount = 0.05)
        {
            double taxAmount = price * tax;
            double discountAmount = price * discount;
            double finalPrice = price + taxAmount - discountAmount;


            return finalPrice;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int price = int .Parse(txtprice.Text);
            //double tax = double.Parse(txt_tax.Text)/100;
            //double discount = double.Parse(txtdiscount.Text)/100;
            MessageBox.Show( CalculatePrice(price).ToString());
            MessageBox.Show(CalculatePrice(price,0).ToString());
            MessageBox.Show(CalculatePrice(price, 0, 0.1).ToString());
            MessageBox.Show(CalculatePrice(price,discount: 0.15).ToString());
            MessageBox.Show(CalculatePrice(price, 0.9).ToString());
            
        }
    }
}