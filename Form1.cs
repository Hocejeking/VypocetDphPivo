namespace Pivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,int>  ceny = new Dictionary<string,int>();


        //10 : Toèené alko i nealko v provozovnì, v lahvi alko i nealko.
        //15 : Toèené nealko sebou, Toèené nealko u stánku i lahev.
        //21 : Toèené sebou,Toèené u stánku, pivo plech,láhev

        double cena = 0;


        private void btnVlozit_Click(object sender, EventArgs e)
            {

            if (txtBoxBirellLH.Text != "" || txtBoxCerna12.Text != "" || txtBoxNeGrep.Text != "" || txtBoxSpecialLH.Text != "" || txtBoxSvetla12.Text != "")
            {
                ceny.Clear();
                ceny.Add("Èerná 12", Convert.ToInt32(txtBoxCerna12.Text));
                ceny.Add("Svìtlá 12", Convert.ToInt32(txtBoxSvetla12.Text));
                ceny.Add("Nealko grep", Convert.ToInt32(txtBoxNeGrep.Text));
                ceny.Add("Starý speciál lh", Convert.ToInt32(txtBoxSpecialLH.Text));
                ceny.Add("Birell", Convert.ToInt32(txtBoxBirellLH.Text));
            }
            else
            {
                MessageBox.Show("Zadejte nejprve všechny ceny");
            }
        }

        private void btnTady_Click(object sender, EventArgs e)
        {
            

            if (rdbBtnCerna12.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                
                pgBar.PerformStep();
                cena = ((ceny["Èerná 12"] / 100.0) * 10.0) + ceny["Èerná 12"];
                pgBar.PerformStep();
                cenaDph = Convert.ToDouble(lblVyslednaCena.Text) + cena;
                pgBar.PerformStep();
                lblVyslednaCena.Text = Convert.ToString(cenaDph);
                pgBar.PerformStep();
                cena = 0;
            }
            else if (rdbButtonSvetla12.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                pgBar.PerformStep();
                cena = ((ceny["Svìtlá 12"] / 100.0) * 10.0) + ceny["Svìtlá 12"];
                pgBar.PerformStep();
                cenaDph = Convert.ToDouble(lblVyslednaCena.Text) + cena;
                pgBar.PerformStep();
                lblVyslednaCena.Text = Convert.ToString(cenaDph);
                pgBar.PerformStep();
                cena = 0;
            }
            else if (rdbBtnNealkoGrep.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                pgBar.PerformStep();
                cena = ((ceny["Nealko grep"] / 100.0) * 10.0) + ceny["Nealko grep"];
                pgBar.PerformStep();
                cenaDph = Convert.ToDouble(lblVyslednaCena.Text) + cena;
                pgBar.PerformStep();
                lblVyslednaCena.Text = Convert.ToString(cenaDph);
                pgBar.PerformStep();
                cena = 0;
            }
            else if (rdbBtnStarySpecial.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                pgBar.PerformStep();
                cena = ((ceny["Starý speciál lh"] / 100.0) * 10.0) + ceny["Starý speciál lh"];
                pgBar.PerformStep();
                cenaDph = Convert.ToDouble(lblVyslednaCena.Text) + cena;
                pgBar.PerformStep();
                lblVyslednaCena.Text = Convert.ToString(cenaDph);
                pgBar.PerformStep();
                cena = 0;
            }
            else if (rdbBtnBirell.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                pgBar.PerformStep();
                cena = ((ceny["Birell"] / 100.0) * 10.0) + ceny["Birell"];
                pgBar.PerformStep();
                cenaDph = Convert.ToDouble(lblVyslednaCena.Text) + cena;
                pgBar.PerformStep();
                lblVyslednaCena.Text = Convert.ToString(cenaDph);
                pgBar.PerformStep();
                cena = 0;
            }

            MessageBox.Show("pøidáno do objednávky");
        }
    }
}