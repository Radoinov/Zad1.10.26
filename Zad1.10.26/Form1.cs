namespace Zad1._10._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
                listBox1.Text = listBox1.SelectedItem.ToString();
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void cmdCombo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i]);
            }
        }
    }
}
