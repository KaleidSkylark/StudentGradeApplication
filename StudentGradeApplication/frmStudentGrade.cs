using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Please input your name.");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please input alphabetic characters.");

            }
            else if (txtEnglish.Text == "" && txtMath.Text == "" && txtScience.Text == "" && txtFilipino.Text == "" && txtHistory.Text == "")
            {
                MessageBox.Show("Please input your grades.");
            }

            else
            {
                double English, Math, Science, Filipino, History, Average;
                English = double.Parse(txtEnglish.Text);
                Math = double.Parse(txtMath.Text);
                Science = double.Parse(txtScience.Text);
                Filipino = double.Parse(txtFilipino.Text);
                History = double.Parse(txtHistory.Text);

                Average = (English + Math + Science + Filipino + History) / 5;
                String AverageOutput = (Average >= 75) ? "The student is passed." : "The student is failed.";

                if (English <= 100 && English >= 0 && Math <= 100 && Math >= 0 && Science <= 100 && Science >= 0 && Filipino <= 100 && Filipino >= 0 && History <= 100 && History >= 0)
                {
                    lblOutput.Text = AverageOutput;
                    lblAverage.Text = "The general average of " + name + " is " + Average;
                }
                else
                {
                    MessageBox.Show("Please input correct details.");
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEnglish.Text = "";
            txtMath.Text = "";
            txtScience.Text = "";
            txtFilipino.Text = "";
            txtHistory.Text = "";
            lblOutput.Text = "";
            lblAverage.Text = "";
        }

    }
}