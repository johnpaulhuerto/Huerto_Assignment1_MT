using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Prelim_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double ComputeAverage(string input)
                {
                    string[] parts = input.Split(',');
                    double totalScore = 0;

                    for (int i = 0; i < parts.Length; i++)
                    {
                        string[] values = parts[i].Trim().Split('/');

                        if (values.Length != 2)
                            throw new FormatException();

                        double score = double.Parse(values[0]);
                        double total = double.Parse(values[1]);

                        if (score > total)
                            throw new Exception("Score cannot be greater than total.");

                        if (score < 0 || total < 0)
                            throw new Exception("Negative values are not allowed.");

                        if (total == 0)
                            throw new DivideByZeroException();

                        double percentage = (score / total) * 60 + 40;
                        totalScore += percentage;
                    }

                    return totalScore / parts.Length;
                }

                
                double prelimClass = ComputeAverage(txtPrelimClass.Text);
                double prelimLab = ComputeAverage(txtPrelimLab.Text);
                double prelimQuiz = ComputeAverage(txtPrelimQuiz.Text);
                double prelimExam = ComputeAverage(txtPrelimExam.Text);

                double prelim =
                    (prelimClass * 0.10) +
                    (prelimLab * 0.10) +
                    (prelimQuiz * 0.20) +
                    (prelimExam * 0.60);

                txtPrelimResult.Text = prelim.ToString("F2");
                txtPrelimGrade.Text = prelim.ToString("F2");

                
                double midtermClass = ComputeAverage(txtMidtermClass.Text);
                double midtermLab = ComputeAverage(txtMidtermLab.Text);
                double midtermQuiz = ComputeAverage(txtMidtermQuiz.Text);
                double midtermExam = ComputeAverage(txtMidtermExam.Text);

                double midterm =
                    (midtermClass * 0.10) +
                    (midtermLab * 0.10) +
                    (midtermQuiz * 0.20) +
                    (midtermExam * 0.60);

                txtMidtermResult.Text = midterm.ToString("F2");
                txtMidtermGrade.Text = midterm.ToString("F2");

                
                double finalsClass = ComputeAverage(txtFinalsClass.Text);
                double finalsLab = ComputeAverage(txtFinalsLab.Text);
                double finalsQuiz = ComputeAverage(txtFinalsQuiz.Text);
                double finalsProject = ComputeAverage(txtFinalsProject.Text);
                double finalsExam = ComputeAverage(txtFinalsExam.Text);

                double finals =
                    (finalsClass * 0.05) +
                    (finalsLab * 0.10) +
                    (finalsQuiz * 0.20) +
                    (finalsProject * 0.25) +
                    (finalsExam * 0.40);

                txtFinalsResult.Text = finals.ToString("F2");
                txtFinalsGrade.Text = finals.ToString("F2");

               
                double finalGrade =
                    (prelim * 0.33) +
                    (midterm * 0.33) +
                    (finals * 0.33);

                txtFinalGrade.Text = finalGrade.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid score/total values.\nExample: 85/100, 90/100");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Total score cannot be zero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrelimClass.Clear();
            txtPrelimLab.Clear();
            txtPrelimQuiz.Clear();
            txtPrelimExam.Clear();
            txtPrelimResult.Clear();

            txtMidtermClass.Clear();
            txtMidtermLab.Clear();
            txtMidtermQuiz.Clear();
            txtMidtermExam.Clear();
            txtMidtermResult.Clear();

            txtFinalsClass.Clear();
            txtFinalsLab.Clear();
            txtFinalsQuiz.Clear();
            txtFinalsProject.Clear();
            txtFinalsExam.Clear();
            txtFinalsResult.Clear();

            txtPrelimGrade.Clear();
            txtMidtermGrade.Clear();
            txtFinalsGrade.Clear();
            txtFinalGrade.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
