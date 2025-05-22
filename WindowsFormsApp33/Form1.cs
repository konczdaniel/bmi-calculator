using System;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;        
        }
        private double CalculeazaIMC(double greutate, double inaltime)
        {
            inaltime = inaltime / 100;
            return greutate / (inaltime * inaltime);
        }
       
        private double CalculeazaMasaideala(double inaltime)
        {
            double greutate = 0;
            
            if (checkBox1.Checked==true)
            {
                greutate = 23;
            }
            else if (checkBox2.Checked==true)
            {
                greutate = 20;
            }
            
            inaltime = inaltime / 100;
            return greutate * (inaltime * inaltime);
        }


        //Interpretare IMC
        private string InterpreteazaIMC(double imc)
        { 
            if (imc < 18.5)
            {
                return "Subponderal\n\nMasa corporală este prea mică.\nContactează-ți medicul pentru o consultație\nși pentru recomandări de analize și/sau modificarea dietei.";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return " Greutate Normala\n\nMasa corporală este normală.\nȚine o dietă bogată în fructe și legume,\nalături de un program zilnic mișcare pentru a menține o formă bună.";

            }
            else if (imc >= 25 && imc < 30)
            {
                return "Supraponderal\n\nMasa corporală este prea mare.\nFă-ți o consultație medicală sau revizuiește-ți stilul de viață";
            }
            else if (imc >= 30 && imc < 35)
            {
                return "Obezitate (gradul I)\n\nMasa corporală este prea mare,\niar indicatorul indică obezitate de grad 1.\nContactează-ți medicul, care va recomanda modificarea dietei și sport în fiecare zi.\nDacă vei lua măsuri din timp, eviți complicațiile aduse de obezitate\nși-ți păstrezi sănătatea pentru mai mult timp.";
            }
            else if (imc >= 35 && imc < 40)
            {
                return "Obezitate (gradul II)\n\nMasa corporală este mult prea mare,\niar indicatorul indică obezitate de grad 2.\nContactează-ți medicul, care va recomanda modificarea dietei și sport în fiecare zi.\nDacă vei lua măsuri din timp, eviți complicațiile aduse de obezitate\nși-ți păstrezi sănătatea pentru mai mult timp.";
            }
            else
            {
                return "Obezitate morbidă MASA CORPORALA MULT PREAM MARE.\n VA ROG SA CONSULTATI MEDICUL PENTRU BINELE DUMNEAVOASTRA.\nSANATATEA DUMNEAVOASTRA AR PUTEA FI IN PERICOL!! ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double greutate = (double)numericUpDown1.Value;  //greutetea val
            double inaltime = (double)numericUpDown2.Value;  //inaltimea val

           
            // Calculul IMC-ului
            double imc = CalculeazaIMC(greutate, inaltime);

            // Interpretarea IMC-ului
            string interpretare = InterpreteazaIMC(imc);

            // Afișarea rezultatului 
            if (greutate == 0 && inaltime == 0)
            {
                label1.Text = $"Valoarea introdusa este invalida!";
            }
            else
            {
                label1.Text = $"IMC-ul dumneavoastra este: {imc:F3}";
                label2.Text = $"Interpretare: {interpretare}";
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double greutate = (double)numericUpDown1.Value;  //greutetea val
            double inaltime = (double)numericUpDown2.Value;  //inaltimea val

            double mid = CalculeazaMasaideala(inaltime);

            label1.Text = $"Greutatea ideala este: {mid}";
            label2.Text = " ";

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
            button2.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox2.Checked;
            button2.Enabled = checkBox2.Checked;
        }

        
    }
}
