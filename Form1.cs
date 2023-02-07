namespace WinFormsDataTim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int time = numericUpDown1.Value.ToString - numericUpDown6.Value.ToString;
            //int number = numericUpDown1 + numericUpDown4;
            //MessageBox.Show($"Залишилось {numericUpDown1.Value - numericUpDown1.Value}років");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal y = numericUpDown1.Value;
            decimal y2 = numericUpDown2.Value;            
            MessageBox.Show($" {numericUpDown1.Value} рок {numericUpDown2.Value} місяць {numericUpDown3.Value} день " +
                $"- {numericUpDown4.Value} рок {numericUpDown5.Value} місяць {numericUpDown6.Value} день" +
                $"");
                

        }
    }
}