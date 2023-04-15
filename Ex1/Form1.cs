namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.ShowDialog();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.ShowDialog();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }
    }
}