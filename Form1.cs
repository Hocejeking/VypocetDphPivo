namespace Pivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,int>  ceny = new Dictionary<string,int>();


        //10 : To�en� alko i nealko v provozovn�, v lahvi alko i nealko.
        //15 : To�en� nealko sebou, To�en� nealko u st�nku i lahev.
        //21 : To�en� sebou,To�en� u st�nku, pivo plech,l�hev

        double cena = 0;


        private void btnVlozit_Click(object sender, EventArgs e)
            {

            if (txtBoxBirellLH.Text != "" || txtBoxCerna12.Text != "" || txtBoxNeGrep.Text != "" || txtBoxSpecialLH.Text != "" || txtBoxSvetla12.Text != "")
            {
                ceny.Clear();
                ceny.Add("�ern� 12", Convert.ToInt32(txtBoxCerna12.Text));
                ceny.Add("Sv�tl� 12", Convert.ToInt32(txtBoxSvetla12.Text));
                ceny.Add("Nealko grep", Convert.ToInt32(txtBoxNeGrep.Text));
                ceny.Add("Star� speci�l lh", Convert.ToInt32(txtBoxSpecialLH.Text));
                ceny.Add("Birell", Convert.ToInt32(txtBoxBirellLH.Text));
            }
            else
            {
                MessageBox.Show("Zadejte nejprve v�echny ceny");
            }
        }

        private void btnTady_Click(object sender, EventArgs e)
        {
            

            if (rdbBtnCerna12.Checked)
            {
                pgBar.Value = 0;
                double cenaDph;
                
                pgBar.PerformStep();
                cena = ((ceny["�ern� 12"] / 100.0) * 10.0) + ceny["�ern� 12"];
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
                cena = ((ceny["Sv�tl� 12"] / 100.0) * 10.0) + ceny["Sv�tl� 12"];
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
                cena = ((ceny["Star� speci�l lh"] / 100.0) * 10.0) + ceny["Star� speci�l lh"];
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

            MessageBox.Show("p�id�no do objedn�vky");
        }
    }
}