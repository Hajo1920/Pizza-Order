namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)

                return Convert.ToSingle(rdSmall.Tag);

            else if (rdMedium.Checked)

                return Convert.ToSingle(rdMedium.Tag);

            else
                return Convert.ToSingle(rdLarge.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMashroom.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMashroom.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomato.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomato.Tag);
            }

            if (chkGreenPaper.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPaper.Tag);
            }

            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rdThin.Checked)

                return Convert.ToSingle(rdThin.Tag);

            else
                return Convert.ToSingle(rdThick.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }


        void UpdateTotalPrice()
        {

            lbPrice.Text = "$" + CalculateTotalPrice().ToString();

        }


        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdSmall.Checked)
            {
                lbSize.Text = rdSmall.Text;
          
                return;
            }

            else if (rdMedium.Checked)
            {
                lbSize.Text = rdMedium.Text;
  
                return;
            }

            else
            {
                lbSize.Text = rdLarge.Text;
                
                return;
            }

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rdThick.Checked)
            {
                lbCrust.Text = rdThick.Text;
               
                return;
            }
            if (rdThin.Checked)
            {
                lbCrust.Text = rdThin.Text;
               
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            String toppingList = "";

            if (chkOnion.Checked)
            {
                toppingList += chkOnion.Text + ", ";

            }

            if (chkExtraChees.Checked)
            {
                toppingList += chkExtraChees.Text + ", ";
      

            }


            if (chkGreenPaper.Checked)
            {
                toppingList += chkGreenPaper.Text + ", ";
       

            }

            if (chkMashroom.Checked)
            {
                toppingList += chkMashroom.Text + ", ";
             
    

            }


            if (chkOlives.Checked)
            {
                toppingList += chkOlives.Text + ", ";
   
             

            }

            if (chkTomato.Checked)
            {
                toppingList += chkTomato.Text + ", ";
        
               

            }
            if (toppingList.StartsWith(","))
            {
                toppingList = toppingList.Substring(1, toppingList.Length - 1).Trim();
            }


            if (toppingList == "")
            {
                lbToppings.Text = "No Toppings";
            }

            lbToppings.Text = toppingList;

        }


        void UpdateSummary()
        {
            UpdateCrust();
            UpdateToppings();
            UpdateSize();
            UpdateTotalPrice();
        }


        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rdMedium.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMashroom.Checked = false;
            chkOlives.Checked = false;
            chkTomato.Checked = false;
            chkGreenPaper.Checked = false;

            //reset CrustType
            rdThin.Checked = true;

            //reset Where to Eat
            rdEatHere.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;

        }


        



        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void lbWhereToEat_Click(object sender, EventArgs e)
        {

        }

        private void rdTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rdTakeaway.Text;
        }

        private void rdEatHere_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rdEatHere.Text;
        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();

        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateCrust();
        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateCrust();

        }

         private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)

        {
            UpdateToppings();

        }

        private void chkGreenPaper_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void chkMashroom_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }



        private void lbToppings_TextChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to order ?", "Order Pizza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed Successfuly !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCrust.Enabled = false;
                gbSize.Enabled = false;
                gbTopping.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrder.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
