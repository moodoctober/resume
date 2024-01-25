using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //test
        }

        private void button3_Click(object sender, EventArgs e)
        { //btnReset
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtMocha.Text = "0";
            txtRafCoffee.Text = "0";
            txtCappu.Text = "0";
            txtAfricanCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtChineseTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCream.Text = "0";
            txtSouffleCake.Text = "0";
            txtKillburnChoco.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblCakeCostnotax.Text = "0";
            lblDrinkCostnotax.Text = "0";
            lblTax.Text = "0";
            lblTotalNoTax.Text = "0";
            lblTotal.Text = "0";

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkRafCoffee.Checked = false;
            chkCappucino.Checked = false;
            chkAfricanCoffe.Checked = false;
            chkMilkTea.Checked = false;
            chkChineseTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            chkSouffle.Checked = false;
            chkKilburnChoco.Checked = false;
            chkCheese.Checked = false;
            chkRainbowCake.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnReceipt
            rtfReceipt.Clear();

            // rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Кассовый чек" + Environment.NewLine);
            rtfReceipt.AppendText(Environment.NewLine + "ПРИХОД" + "\t\t\t" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "    Starbucks" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Продукт" + "\t\t\t" + "Кол-во" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            if (chkLatte.Checked == true)
            {
                rtfReceipt.AppendText("Латте \t\t\t\t" + txtLatte.Text + Environment.NewLine);
               // rtfReceipt.AppendText("В т.ч. НДС 10% \t\t\t" + Environment.NewLine);
            }
            else
            {

            }
            if (chkEspresso.Checked == true)
            {
                rtfReceipt.AppendText("Эспрессо \t\t\t" + txtEspresso.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkMocha.Checked == true)
            {
                rtfReceipt.AppendText("Мокко \t\t\t\t" + txtMocha.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkRafCoffee.Checked == true)
            {
                rtfReceipt.AppendText("Раф \t\t\t\t" + txtRafCoffee.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkCappucino.Checked == true)
            {
                rtfReceipt.AppendText("Капучино \t\t\t" + txtCappu.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkAfricanCoffe.Checked == true)
            {
                rtfReceipt.AppendText("Айс кофе \t\t\t" + txtAfricanCoffee.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkMilkTea.Checked == true)
            {
                rtfReceipt.AppendText("Молочный чай \t\t" + txtMilkTea.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkChineseTea.Checked == true)
            {
                rtfReceipt.AppendText("Китайский чай \t\t" + txtChineseTea.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkCoffe.Checked == true)
            {
                rtfReceipt.AppendText("Кофейный торт \t\t" + txtCoffeCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkRedValvet.Checked == true)
            {
                rtfReceipt.AppendText("Красный бархат \t\t" + txtRedValvetCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkBlackForest.Checked == true)
            {
                rtfReceipt.AppendText("Черный лес \t\t\t" + txtBlackForestCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkBostonCream.Checked == true)
            {
                rtfReceipt.AppendText("Кремовый торт \t\t" + txtBostonCream.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkSouffle.Checked == true)
            {
                rtfReceipt.AppendText("Птичье молоко \t\t" + txtSouffleCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkKilburnChoco.Checked == true)
            {
                rtfReceipt.AppendText("Шоколадный торт \t\t" + txtKillburnChoco.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkCheese.Checked == true)
            {
                rtfReceipt.AppendText("Чизкейк \t\t\t" + txtCheeseCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkRainbowCake.Checked == true)
            {
                rtfReceipt.AppendText("Радужный торт \t\t" + txtRainbowCake.Text + Environment.NewLine);
            }
            else
            {

            }

            
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            //rtfReceipt.AppendText("НДС 10% \t\t\t\t"); //+ lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Итог \t\t\t\t=" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Сумма без НДС \t\t=" + lblTotalNoTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t\t\t" + lblDate.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        { //btnTotal
            double lat, mocha, espr, Raf, cappu, afri, mTea, cTea;
            double cCake, rValvet, bFor, bCream, souf, Choco, cheese, rain;
            double tax;
            tax = 0.1;

            lat = 49; mocha = 50; espr = 80; Raf = 59; cappu = 70; afri = 85; mTea = 40; cTea = 55; //coffee pries
            cCake = 50; rValvet = 100; bFor = 60; bCream = 40; souf = 79; Choco = 109; cheese = 85; rain = 89; //cake prices
            CultureInfo culture = CultureInfo.CreateSpecificCulture("ru-RU");
           //NumberFormatInfo perc = NumberFormatInfo.PercentSymbol
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US"); //US Currency

            //Coffee
            double latteeCof = Convert.ToDouble(txtLatte.Text);
            double mochaCof = Convert.ToDouble(txtMocha.Text);
            double espressoCof = Convert.ToDouble(txtEspresso.Text);
            double RafCof = Convert.ToDouble(txtRafCoffee.Text);
            double cappCof = Convert.ToDouble(txtCappu.Text);
            double afriCof = Convert.ToDouble(txtAfricanCoffee.Text);
            double miTea = Convert.ToDouble(txtMilkTea.Text);
            double cineseTea = Convert.ToDouble(txtChineseTea.Text);
            //Cakes
            double cofCake = Convert.ToDouble(txtCoffeCake.Text);
            double redValvet = Convert.ToDouble(txtRedValvetCake.Text);
            double bForest = Convert.ToDouble(txtBlackForestCake.Text);
            double bostonCream = Convert.ToDouble(txtBostonCream.Text);
            double souffle = Convert.ToDouble(txtSouffleCake.Text);
            double kilbChoco = Convert.ToDouble(txtKillburnChoco.Text);
            double cheeseCak = Convert.ToDouble(txtCheeseCake.Text);
            double rainbow = Convert.ToDouble(txtRainbowCake.Text);

            Cafe eat_in_cafe = new Cafe(latteeCof, mochaCof, espressoCof, RafCof, cappCof, afriCof, miTea, cineseTea,
                cofCake, redValvet, bForest, bostonCream, souffle, kilbChoco, cheeseCak, rainbow);

            double drinkCosts = (latteeCof * lat * 1.1) + (mochaCof * mocha * 1.1) + (espressoCof * espr * 1.1) + (RafCof * Raf * 1.1)
                + (cappCof * cappu * 1.1) + (afriCof * afri * 1.1) + (miTea * mTea * 1.1) + (cineseTea * cTea * 1.1);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double cakeCosts = (cofCake * cCake * 1.1) + (redValvet * rValvet * 1.1) + (bForest * bFor * 1.1) + (bostonCream * bCream * 1.1)
                + (souffle * souf * 1.1) + (kilbChoco * Choco * 1.1) + (cheeseCak * cheese * 1.1) + (rainbow * rain * 1.1);
            lblCakeCost.Text = Convert.ToString(cakeCosts);

            double drinkCostsnotax = (latteeCof * lat) + (mochaCof * mocha) + (espressoCof * espr) + (RafCof * Raf) + (cappCof * cappu) + (afriCof * afri) + (miTea * mTea) + (cineseTea * cTea);
            lblDrinkCostnotax.Text = Convert.ToString(drinkCostsnotax);
            double cakeCostsnotax = (cofCake * cCake) + (redValvet * rValvet) + (bForest * bFor) + (bostonCream * bCream) + (souffle * souf) + (kilbChoco * Choco) + (cheeseCak * cheese) + (rainbow * rain);
            lblCakeCostnotax.Text = Convert.ToString(cakeCostsnotax);

            lblTotalNoTax.Text = Convert.ToString(cakeCostsnotax + drinkCostsnotax );
            lblTax.Text = Convert.ToString(tax);
            //double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cakeCosts + drinkCosts);

            lblDrinkCost.Text = String.Format(culture, "{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format(culture, "{0:C}", cakeCosts);
            lblTotalNoTax.Text = String.Format(culture, "{0:C}", (cakeCostsnotax + drinkCostsnotax ));
            lblTax.Text = String.Format(culture, "{0:P0}", tax);
            lblTotal.Text = String.Format(culture, "{0:C}", (cakeCosts + drinkCosts));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
            double latteeCof = Convert.ToDouble(txtLatte.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();


            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtMocha.Text = "0";
            txtRafCoffee.Text = "0";
            txtCappu.Text = "0";
            txtAfricanCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtChineseTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCream.Text = "0";
            txtSouffleCake.Text = "0";
            txtKillburnChoco.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblCakeCostnotax.Text = "0";
            lblDrinkCostnotax.Text = "0";
            lblTotalNoTax.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLatte.Enabled = false;
            txtEspresso.Enabled = false; ;
            txtMocha.Enabled = false;
            txtRafCoffee.Enabled = false;
            txtCappu.Enabled = false;
            txtAfricanCoffee.Enabled = false;
            txtMilkTea.Enabled = false;
            txtChineseTea.Enabled = false;
            txtCoffeCake.Enabled = false;
            txtRedValvetCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtBostonCream.Enabled = false;
            txtSouffleCake.Enabled = false;
            txtKillburnChoco.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtRainbowCake.Enabled = false;

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkRafCoffee.Checked = false;
            chkCappucino.Checked = false;
            chkAfricanCoffe.Checked = false;
            chkMilkTea.Checked = false;
            chkChineseTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            chkSouffle.Checked = false;
            chkKilburnChoco.Checked = false;
            chkCheese.Checked = false;
            chkRainbowCake.Checked = false;

            rtfReceipt.Clear();

        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked==true)
            {
                txtLatte.Enabled = true;
                txtLatte.Text = "1";
            }
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }    

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
               txtEspresso.Enabled = true;
                txtEspresso.Text = "1";
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMocha.Checked == true)
            {
                txtMocha.Enabled = true;
                txtMocha.Text = "1";
            }
            else
            {
                txtMocha.Enabled = false;
                txtMocha.Text = "0";
            }
        }

        private void txtMocha_Click(object sender, EventArgs e)
        {
            txtMocha.Text = "";
            txtMocha.Focus();
        }

        private void chkRafCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRafCoffee.Checked == true)
            {
                txtRafCoffee.Enabled = true;
                txtRafCoffee.Text = "1";
            }
            else
            {
                txtRafCoffee.Enabled = false;
                txtRafCoffee.Text = "0";
            }
        }

        private void txtRafCoffee_Click(object sender, EventArgs e)
        {
            txtRafCoffee.Text = "";
            txtRafCoffee.Focus();
        }

        private void chkCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappucino.Checked == true)
            {
                txtCappu.Enabled = true;
                txtCappu.Text = "1";
            }
            else
            {
                txtCappu.Enabled = false;
                txtCappu.Text = "0";
            }
        }

        private void txtCappu_Click(object sender, EventArgs e)
        {
            txtCappu.Text = "";
            txtCappu.Focus();
        }

        private void chkAfricanCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffe.Checked == true)
            {
                txtAfricanCoffee.Enabled = true;
                txtAfricanCoffee.Text = "1";
            }
            else
            {
                txtAfricanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }

           private void txtAfricanCoffee_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "";
            txtAfricanCoffee.Focus();
        }

        private void chkMilkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMilkTea.Checked == true)
            {
                txtMilkTea.Enabled = true;
                txtMilkTea.Text = "1";
            }
            else
            {
                txtMilkTea.Enabled = false;
                txtMilkTea.Text = "0";
            }
        }

        private void txtMilkTea_Click(object sender, EventArgs e)
        {
            txtMilkTea.Text = "";
            txtMilkTea.Focus();
        }

        private void chkChineseTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChineseTea.Checked == true)
            {
                txtChineseTea.Enabled = true;
                txtChineseTea.Text = "1";
            }
            else
            {
                txtChineseTea.Enabled = false;
                txtChineseTea.Text = "0";
            }
        }

        private void txtChineseTea_Click(object sender, EventArgs e)
        {
            txtChineseTea.Text = "";
            txtChineseTea.Focus();
        }

        private void chkCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffe.Checked == true)
            {
                txtCoffeCake.Enabled = true;
                txtCoffeCake.Text = "1";
            }
            else
            {
                txtCoffeCake.Enabled = false;
                txtCoffeCake.Text = "0";
            }
        }

        private void txtCoffeCake_Click(object sender, EventArgs e)
        {
            txtCoffeCake.Text = "";
            txtCoffeCake.Focus();
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRedValvetCake.Enabled = true;
                txtRedValvetCake.Text = "1";
            }
            else
            {
                txtRedValvetCake.Enabled = false;
                txtRedValvetCake.Text = "0";
            }
        }

        private void txtRedValvetCake_Click(object sender, EventArgs e)
        {
            txtRedValvetCake.Text = "";
            txtRedValvetCake.Focus();
        }


        private void chkBlackForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForest.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
                txtBlackForestCake.Text = "1";
            }
            else
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
        }

        private void txtBlackForestCake_Click(object sender, EventArgs e)
        {
            txtBlackForestCake.Text = "";
            txtBlackForestCake.Focus();
        }

        private void chkBostonCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCream.Checked == true)
            {
                txtBostonCream.Enabled = true;
                txtBostonCream.Text = "1";
            }
            else
            {
                txtBostonCream.Enabled = false;
                txtBostonCream.Text = "0";
            }
        }

        private void txtBostonCream_Click(object sender, EventArgs e)
        {
            txtBostonCream.Text = "";
            txtBostonCream.Focus();
        }

        private void chkSouffle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSouffle.Checked == true)
            {
               txtSouffleCake.Enabled = true;
                txtSouffleCake.Text = "1";
            }
            else
            {
                txtSouffleCake.Enabled = false;
                txtSouffleCake.Text = "0";
            }
        }

        private void txtSouffleCake_Click(object sender, EventArgs e)
        {
            txtSouffleCake.Text = "";
            txtSouffleCake.Focus();
        }

        private void chkKilburnChoco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburnChoco.Checked == true)
            {
                txtKillburnChoco.Enabled = true;
                txtKillburnChoco.Text = "1";
            }
            else
            {
                txtKillburnChoco.Enabled = false;
                txtKillburnChoco.Text = "0";
            }
        }


        private void txtKillburnChoco_Click(object sender, EventArgs e)
        {
            txtKillburnChoco.Text = "";
            txtKillburnChoco.Focus();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked == true)
            {
                txtCheeseCake.Enabled = true;
                txtCheeseCake.Text = "1";
            }
            else
            {
                txtCheeseCake.Enabled = false;
                txtCheeseCake.Text = "0";
            }
        }


        private void txtCheeseCake_Click(object sender, EventArgs e)
        {
            txtCheeseCake.Text = "";
            txtCheeseCake.Focus();
        }

        private void chkRainbowCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRainbowCake.Checked == true)
            {
               txtRainbowCake.Enabled = true;
                txtRainbowCake.Text = "1";
            }
            else
            {
                txtRainbowCake.Enabled = false;
                txtRainbowCake.Text = "0";
            }
        }

        private void txtRainbowCake_Click(object sender, EventArgs e)
        {
            txtRainbowCake.Text = "";
            txtRainbowCake.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            
            
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalNoTax_Click(object sender, EventArgs e)
        {

        }

        private void lblCakeCost_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtChineseTea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMilkTea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAfricanCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCappu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRafCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMocha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspresso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLatte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRainbowCake_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void lblDrinkCost_Click(object sender, EventArgs e)
        {

        }

        private void txtBostonCream_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
