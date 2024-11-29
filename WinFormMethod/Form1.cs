namespace WinFormMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่ม "คำนวณ BMI"
            //Input รับค่า textBox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1  double height = Convert.ToDouble(txtHeight.Text);
            //1  double weight = Convert.ToDouble(txtWeight.Text); 
            //2  double height = 0;
            //2  if (double.TryParse(txtHeight.Text,out height)==false)
            //2  {
            //2    MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return;   //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2   }
            //2   double weight = 0;
            //2   if (double.TryParse(txtWeight.Text, out weight) == false)
            //2   {
            //2    MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return;   //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2   }


            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))   //เรียกใช้ Method แบบคืนค่าเป็น True/False
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //Process คำนวณค่า BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);                        //เรียกใช้method BMI
            //Output แปลผล โดนนำค่า BMI มาเทียบกับค่ามาตรฐาน
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;  //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();

        }
        private void InputDataValid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0) //.lrngth 
            {
                name.ForeColor = Color.DeepPink;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DeepPink;
            }
            else
            {
                age.ForeColor = Color.Black;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }
        private double BMI(double h, double w)   //คำนวณค่า bmi ส่งค่าเข้ามา 2 ค่า คือน้ำหนักและส่วนสูง
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2)
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)  //ตรวจสอบข้อมูลว่าเป็น Double หรือไม่
        {
            double w = 0;
            double h = 0;
            if((double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }
    }
}
