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
            MessageBox.Show("�Թ�յ�͹�Ѻ", "��������ͺ������ǹ���");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //���� "�ӹǳ BMI"
            //Input �Ѻ��� textBox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1  double height = Convert.ToDouble(txtHeight.Text);
            //1  double weight = Convert.ToDouble(txtWeight.Text); 
            //2  double height = 0;
            //2  if (double.TryParse(txtHeight.Text,out height)==false)
            //2  {
            //2    MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2    return;   //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2   }
            //2   double weight = 0;
            //2   if (double.TryParse(txtWeight.Text, out weight) == false)
            //2   {
            //2    MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2    return;   //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2   }


            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))   //���¡�� Method Ẻ�׹����� True/False
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //Process �ӹǳ��� BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);                        //���¡��method BMI
            //Output �ż� ⴹ�Ӥ�� BMI ����º�Ѻ����ҵðҹ
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;  //�Ѵ�Դ���
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
        private double BMI(double h, double w)   //�ӹǳ��� bmi �觤������� 2 ��� ��͹��˹ѡ�����ǹ�٧
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2)
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)  //��Ǩ�ͺ����������� Double �������
        {
            double w = 0;
            double h = 0;
            if((double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return false;
            }
            return true;
        }
    }
}
