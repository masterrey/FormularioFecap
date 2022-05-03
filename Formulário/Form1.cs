namespace Formulário
{
    public partial class Form1 : Form
    {
        string[] nomes = new string[10];
        /*int[] dia=new int[10];
        int[] mes = new int[10];
        int[] ano = new int[10];*/
        DateTime[] datanasc = new DateTime[10];
        double[] altura = new double[10];
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomes[indice] = textBox1.Text;
            datanasc[indice] = dateTimePicker1.Value;
            altura[indice] = (double) numericUpDown4.Value;
            indice++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                listView1.Items.Add(nomes[i]);
            }
        }
    }
}