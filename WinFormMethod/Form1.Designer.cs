namespace WinFormMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtAge = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            lblResult = new Label();
            btnBMI = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(218, 38);
            label1.Name = "label1";
            label1.Size = new Size(392, 66);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 272);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "น้ำหนัก (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 237);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "ส่วนสูง (cm)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(190, 237);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(190, 272);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(190, 186);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 186);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 5;
            label4.Text = "อายุ";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 142);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "ชื่อ-นามสกุล";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PaleTurquoise;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 20F);
            lblResult.Location = new Point(190, 327);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(498, 149);
            lblResult.TabIndex = 9;
            lblResult.Text = "......";
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.Orange;
            btnBMI.Font = new Font("Segoe UI", 10F);
            btnBMI.Location = new Point(683, 142);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(189, 78);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Location = new Point(683, 247);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(189, 52);
            btnClear.TabIndex = 6;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1018, 504);
            Controls.Add(btnClear);
            Controls.Add(btnBMI);
            Controls.Add(lblResult);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "โปรแกรมคำนวณค่า BMI (เรื่อง method/function)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private Label lblResult;
        private Button btnBMI;
        private Button btnClear;
    }
}
