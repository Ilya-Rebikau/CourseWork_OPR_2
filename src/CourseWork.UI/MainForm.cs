using CourseWork.BLL.Interfaces;
using CourseWork.Models;

namespace CourseWork.UI
{
    public partial class MainForm : Form
    {
        private readonly ISolver _solver;
        public MainForm(ISolver solver)
        {
            InitializeComponent();
            _solver = solver;
            openFileDialog.Filter = "Csv файлы(*.csv)|*.csv";
            buttonReadMatrix.Click += ButtonReadMatrixAndCalculate_Click;
        }

        private ResultDataModel GetResult(string fileNameWithPath, int triesCount)
        {
            return _solver.Solve(fileNameWithPath, triesCount);
        }

        private void ButtonReadMatrixAndCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Clear();
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                string fileNameWithPath = openFileDialog.FileName;
                if(!int.TryParse(textBoxTriesCount.Text, out int triesCount))
                {
                    throw new ArgumentException("Неверный ввод количества попыток поиска оптимального пути. " +
                        "Нужно ввести целое число!");
                }

                var result = GetResult(fileNameWithPath, triesCount);
                richTextBoxResult.Text += $"Путь:\n{result.Path.StringPath}\n";
                richTextBoxResult.Text += $"Длина пути: {result.ContourLength}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}