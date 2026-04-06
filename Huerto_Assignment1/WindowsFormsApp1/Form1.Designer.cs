namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prelim = new System.Windows.Forms.GroupBox();
            this.txtPrelimClass = new System.Windows.Forms.TextBox();
            this.txtPrelimLab = new System.Windows.Forms.TextBox();
            this.txtPrelimQuiz = new System.Windows.Forms.TextBox();
            this.txtPrelimExam = new System.Windows.Forms.TextBox();
            this.txtPrelimResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Midterm = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMidtermResult = new System.Windows.Forms.TextBox();
            this.txtMidtermQuiz = new System.Windows.Forms.TextBox();
            this.txtMidtermExam = new System.Windows.Forms.TextBox();
            this.txtMidtermLab = new System.Windows.Forms.TextBox();
            this.txtMidtermClass = new System.Windows.Forms.TextBox();
            this.Finals = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFinalsResult = new System.Windows.Forms.TextBox();
            this.txtFinalsQuiz = new System.Windows.Forms.TextBox();
            this.txtFinalsExam = new System.Windows.Forms.TextBox();
            this.txtFinalsLab = new System.Windows.Forms.TextBox();
            this.txtFinalsClass = new System.Windows.Forms.TextBox();
            this.txtPrelimGrade = new System.Windows.Forms.TextBox();
            this.txtMidtermGrade = new System.Windows.Forms.TextBox();
            this.txtFinalsGrade = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFinalsProject = new System.Windows.Forms.TextBox();
            this.Prelim.SuspendLayout();
            this.Midterm.SuspendLayout();
            this.Finals.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prelim
            // 
            this.Prelim.Controls.Add(this.label5);
            this.Prelim.Controls.Add(this.label4);
            this.Prelim.Controls.Add(this.label3);
            this.Prelim.Controls.Add(this.label2);
            this.Prelim.Controls.Add(this.label1);
            this.Prelim.Controls.Add(this.txtPrelimResult);
            this.Prelim.Controls.Add(this.txtPrelimQuiz);
            this.Prelim.Controls.Add(this.txtPrelimExam);
            this.Prelim.Controls.Add(this.txtPrelimLab);
            this.Prelim.Controls.Add(this.txtPrelimClass);
            this.Prelim.Location = new System.Drawing.Point(27, 24);
            this.Prelim.Name = "Prelim";
            this.Prelim.Size = new System.Drawing.Size(445, 193);
            this.Prelim.TabIndex = 0;
            this.Prelim.TabStop = false;
            this.Prelim.Text = "Prelim";
            this.Prelim.Enter += new System.EventHandler(this.Prelim_Enter);
            // 
            // txtPrelimClass
            // 
            this.txtPrelimClass.Location = new System.Drawing.Point(6, 29);
            this.txtPrelimClass.Name = "txtPrelimClass";
            this.txtPrelimClass.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimClass.TabIndex = 2;
            // 
            // txtPrelimLab
            // 
            this.txtPrelimLab.Location = new System.Drawing.Point(6, 66);
            this.txtPrelimLab.Name = "txtPrelimLab";
            this.txtPrelimLab.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimLab.TabIndex = 3;
            // 
            // txtPrelimQuiz
            // 
            this.txtPrelimQuiz.Location = new System.Drawing.Point(6, 106);
            this.txtPrelimQuiz.Name = "txtPrelimQuiz";
            this.txtPrelimQuiz.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimQuiz.TabIndex = 5;
            // 
            // txtPrelimExam
            // 
            this.txtPrelimExam.Location = new System.Drawing.Point(6, 147);
            this.txtPrelimExam.Name = "txtPrelimExam";
            this.txtPrelimExam.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimExam.TabIndex = 4;
            this.txtPrelimExam.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPrelimResult
            // 
            this.txtPrelimResult.Location = new System.Drawing.Point(261, 29);
            this.txtPrelimResult.Name = "txtPrelimResult";
            this.txtPrelimResult.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimResult.TabIndex = 6;
            this.txtPrelimResult.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Class Performance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Laboratory Exercise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quizzes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Exam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Result";
            // 
            // Midterm
            // 
            this.Midterm.Controls.Add(this.label6);
            this.Midterm.Controls.Add(this.label7);
            this.Midterm.Controls.Add(this.label8);
            this.Midterm.Controls.Add(this.label9);
            this.Midterm.Controls.Add(this.label10);
            this.Midterm.Controls.Add(this.txtMidtermResult);
            this.Midterm.Controls.Add(this.txtMidtermQuiz);
            this.Midterm.Controls.Add(this.txtMidtermExam);
            this.Midterm.Controls.Add(this.txtMidtermLab);
            this.Midterm.Controls.Add(this.txtMidtermClass);
            this.Midterm.Location = new System.Drawing.Point(507, 24);
            this.Midterm.Name = "Midterm";
            this.Midterm.Size = new System.Drawing.Size(445, 193);
            this.Midterm.TabIndex = 12;
            this.Midterm.TabStop = false;
            this.Midterm.Text = "Midterm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Exam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quizzes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Laboratory Exercise";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Class Performance";
            // 
            // txtMidtermResult
            // 
            this.txtMidtermResult.Location = new System.Drawing.Point(261, 29);
            this.txtMidtermResult.Name = "txtMidtermResult";
            this.txtMidtermResult.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermResult.TabIndex = 6;
            // 
            // txtMidtermQuiz
            // 
            this.txtMidtermQuiz.Location = new System.Drawing.Point(6, 106);
            this.txtMidtermQuiz.Name = "txtMidtermQuiz";
            this.txtMidtermQuiz.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermQuiz.TabIndex = 5;
            // 
            // txtMidtermExam
            // 
            this.txtMidtermExam.Location = new System.Drawing.Point(6, 147);
            this.txtMidtermExam.Name = "txtMidtermExam";
            this.txtMidtermExam.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermExam.TabIndex = 4;
            // 
            // txtMidtermLab
            // 
            this.txtMidtermLab.Location = new System.Drawing.Point(6, 66);
            this.txtMidtermLab.Name = "txtMidtermLab";
            this.txtMidtermLab.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermLab.TabIndex = 3;
            // 
            // txtMidtermClass
            // 
            this.txtMidtermClass.Location = new System.Drawing.Point(6, 29);
            this.txtMidtermClass.Name = "txtMidtermClass";
            this.txtMidtermClass.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermClass.TabIndex = 2;
            // 
            // Finals
            // 
            this.Finals.Controls.Add(this.label20);
            this.Finals.Controls.Add(this.txtFinalsProject);
            this.Finals.Controls.Add(this.label11);
            this.Finals.Controls.Add(this.label12);
            this.Finals.Controls.Add(this.label13);
            this.Finals.Controls.Add(this.label14);
            this.Finals.Controls.Add(this.label15);
            this.Finals.Controls.Add(this.txtFinalsResult);
            this.Finals.Controls.Add(this.txtFinalsQuiz);
            this.Finals.Controls.Add(this.txtFinalsExam);
            this.Finals.Controls.Add(this.txtFinalsLab);
            this.Finals.Controls.Add(this.txtFinalsClass);
            this.Finals.Location = new System.Drawing.Point(27, 248);
            this.Finals.Name = "Finals";
            this.Finals.Size = new System.Drawing.Size(445, 227);
            this.Finals.TabIndex = 13;
            this.Finals.TabStop = false;
            this.Finals.Text = "Finals";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Result";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Exam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Quizzes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Laboratory Exercise";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Class Performance";
            // 
            // txtFinalsResult
            // 
            this.txtFinalsResult.Location = new System.Drawing.Point(261, 29);
            this.txtFinalsResult.Name = "txtFinalsResult";
            this.txtFinalsResult.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsResult.TabIndex = 6;
            this.txtFinalsResult.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtFinalsQuiz
            // 
            this.txtFinalsQuiz.Location = new System.Drawing.Point(6, 106);
            this.txtFinalsQuiz.Name = "txtFinalsQuiz";
            this.txtFinalsQuiz.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsQuiz.TabIndex = 5;
            // 
            // txtFinalsExam
            // 
            this.txtFinalsExam.Location = new System.Drawing.Point(6, 188);
            this.txtFinalsExam.Name = "txtFinalsExam";
            this.txtFinalsExam.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsExam.TabIndex = 4;
            // 
            // txtFinalsLab
            // 
            this.txtFinalsLab.Location = new System.Drawing.Point(6, 66);
            this.txtFinalsLab.Name = "txtFinalsLab";
            this.txtFinalsLab.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsLab.TabIndex = 3;
            // 
            // txtFinalsClass
            // 
            this.txtFinalsClass.Location = new System.Drawing.Point(6, 29);
            this.txtFinalsClass.Name = "txtFinalsClass";
            this.txtFinalsClass.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsClass.TabIndex = 2;
            // 
            // txtPrelimGrade
            // 
            this.txtPrelimGrade.Location = new System.Drawing.Point(123, 22);
            this.txtPrelimGrade.Name = "txtPrelimGrade";
            this.txtPrelimGrade.Size = new System.Drawing.Size(172, 20);
            this.txtPrelimGrade.TabIndex = 12;
            // 
            // txtMidtermGrade
            // 
            this.txtMidtermGrade.Location = new System.Drawing.Point(123, 59);
            this.txtMidtermGrade.Name = "txtMidtermGrade";
            this.txtMidtermGrade.Size = new System.Drawing.Size(172, 20);
            this.txtMidtermGrade.TabIndex = 14;
            // 
            // txtFinalsGrade
            // 
            this.txtFinalsGrade.Location = new System.Drawing.Point(123, 99);
            this.txtFinalsGrade.Name = "txtFinalsGrade";
            this.txtFinalsGrade.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsGrade.TabIndex = 15;
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(123, 140);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(172, 20);
            this.txtFinalGrade.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Prelim Grade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Midterm Grade";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Finals Grade";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Final Grade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtFinalGrade);
            this.groupBox1.Controls.Add(this.txtFinalsGrade);
            this.groupBox1.Controls.Add(this.txtMidtermGrade);
            this.groupBox1.Controls.Add(this.txtPrelimGrade);
            this.groupBox1.Location = new System.Drawing.Point(507, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 186);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(336, 35);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 20;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(336, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Project";
            // 
            // txtFinalsProject
            // 
            this.txtFinalsProject.Location = new System.Drawing.Point(6, 147);
            this.txtFinalsProject.Name = "txtFinalsProject";
            this.txtFinalsProject.Size = new System.Drawing.Size(172, 20);
            this.txtFinalsProject.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Finals);
            this.Controls.Add(this.Midterm);
            this.Controls.Add(this.Prelim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Prelim.ResumeLayout(false);
            this.Prelim.PerformLayout();
            this.Midterm.ResumeLayout(false);
            this.Midterm.PerformLayout();
            this.Finals.ResumeLayout(false);
            this.Finals.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Prelim;
        private System.Windows.Forms.TextBox txtPrelimLab;
        private System.Windows.Forms.TextBox txtPrelimClass;
        private System.Windows.Forms.TextBox txtPrelimQuiz;
        private System.Windows.Forms.TextBox txtPrelimExam;
        private System.Windows.Forms.TextBox txtPrelimResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Midterm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMidtermResult;
        private System.Windows.Forms.TextBox txtMidtermQuiz;
        private System.Windows.Forms.TextBox txtMidtermExam;
        private System.Windows.Forms.TextBox txtMidtermLab;
        private System.Windows.Forms.TextBox txtMidtermClass;
        private System.Windows.Forms.GroupBox Finals;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFinalsResult;
        private System.Windows.Forms.TextBox txtFinalsQuiz;
        private System.Windows.Forms.TextBox txtFinalsExam;
        private System.Windows.Forms.TextBox txtFinalsLab;
        private System.Windows.Forms.TextBox txtFinalsClass;
        private System.Windows.Forms.TextBox txtPrelimGrade;
        private System.Windows.Forms.TextBox txtMidtermGrade;
        private System.Windows.Forms.TextBox txtFinalsGrade;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFinalsProject;
    }
}

