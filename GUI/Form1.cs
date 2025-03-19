using KnapsackProblem;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSize.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Invalid number of items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxSeed.Text, out int seed))
            {
                MessageBox.Show("Invalid seed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxMaxWeight.Text, out int maxWeight) || maxWeight <= 0)
            {
                MessageBox.Show("Invalid max weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rand = new(seed);
            List<Knapsack.Item> items = new();
            for (int i = 0; i < size; i++)
            {
                items.Add(new Knapsack.Item(i + 1, rand.Next(1, 11), rand.Next(1, 11)));
            }

            items.Sort();

            Knapsack.Result result = Knapsack.Solver(maxWeight, items);
            textBoxResult.Text = result.ToString();
        }
    }
}
