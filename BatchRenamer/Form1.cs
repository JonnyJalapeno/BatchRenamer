namespace BatchRenamer
{
    public partial class Form1 : Form
    {
        public string[] fileChoices { get; set; }
        public string[] fileNames { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 && fileChoices != null)
            {
                FindAndReplace findAndReplace = new FindAndReplace(fileChoices);
                findAndReplace.ShowDialog();
                if (findAndReplace.result != null)
                {
                    this.fileNames = findAndReplace.result;
                    foreach (string s in findAndReplace.result)
                    {
                        textBox2.AppendText(s);
                        textBox2.AppendText(Environment.NewLine);
                    }
                }
                else {
                    MessageBox.Show("Wyst¹pi³ b³¹d z zamian¹ nazw plików");
                }      
            }
            else if (comboBox1.SelectedIndex != 0 && fileChoices == null)
            {
                MessageBox.Show("Proszê wybraæ pliki na których ma zostaæ wykonana operacja");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] boxChoices = ofd.FileNames;
            if (boxChoices != null && boxChoices.Length > 0)
            {
                foreach (string box in boxChoices)
                {
                    textBox1.AppendText(box);
                    textBox1.AppendText(Environment.NewLine);
                    this.fileChoices = boxChoices;
                }
            }
        }

        public static void SaveFiles(string[] fileChoices, string[] fileNames)
        {
            for(int i = 0; i < fileChoices.Length; i++)
            {
                File.Move(fileChoices[i], fileNames[i], true);
                File.Delete(fileChoices[i]);
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            SaveFiles(fileChoices, fileNames);
            MessageBox.Show("Operacja przebieg³a pomyœlnie");
        }
    }
}