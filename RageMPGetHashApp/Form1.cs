using GTANetworkAPI;

namespace RageMPGetHashApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                listBox1.Items.Add(textBox1.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {

                listBox2.Items.Add($"{item} - {NAPI.Util.GetHashKey(item.ToString())}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var item in listBox2.Items)
            {
                text += $"{item}\n";
            }

            Clipboard.SetText(text);
        }
    }
}