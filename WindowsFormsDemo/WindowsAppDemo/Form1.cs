namespace WindowsAppDemo
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int amt = int.Parse(txtTotalFees.Text);
            if (cb.Checked == true)
            {
                count += 1;
                amt = amt + Convert.ToInt32(cb.Tag);
            }
            else
            {
                count -= 1;
                amt = amt - Convert.ToInt32(cb.Tag);
            }
            txtTotalFees.Text = amt.ToString();
            txtAmtInWords.Text = "Rs." + NumberToWord(Convert.ToInt32(txtTotalFees.Text));
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            int amt = int.Parse(txtTotalFees.Text);
            if (rb.Checked)
            {
                amt += Convert.ToInt32(rb.Tag) * count;
            }
            else
            {
                amt -= Convert.ToInt32(rb.Tag) * count;
            }
            txtTotalFees.Text = amt.ToString();
            txtAmtInWords.Text = "Rs." + NumberToWord(Convert.ToInt32(txtTotalFees.Text));
        }
        private static string NumberToWord(int num)
        {
            if (num == 0)
                return "Zero";
            if (num < 0)
                return "Not Supported";
            var words = "";
            string[] strOnes = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirtee", "Forteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] strTens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            int crore = 0, lakhs = 0, thousands = 0, hundreds = 0, tens = 0, singles = 0;
            crore = num / 10000000;num = num - crore * 10000000;
            lakhs = num / 100000; num = num - lakhs * 100000;
            thousands = num / 1000; num = num - thousands * 1000;
            hundreds = num / 100; num = num -hundreds * 100;
            if(num>19)
            {
                tens = num / 10;
                num = num - tens * 10;
            }
            singles = num;
            if(crore>0)
            {
                if (crore > 19)
                    words += NumberToWord(crore) + "Crores ";
                else
                    words += strOnes[crore - 1] + " Crore";
            }
            if (lakhs> 0)
            {
                if (lakhs > 19)
                    words += NumberToWord(lakhs) + "Lakhs ";
                else
                    words += strOnes[lakhs - 1] + " Lakh ";
            }
            if (thousands > 0)
            {
                if (thousands > 19)
                    words += NumberToWord(thousands) + "Thousands ";
                else
                    words += strOnes[thousands - 1] + " Thousand ";
            }
            if (hundreds > 0)
                words += strOnes[hundreds - 1] + " Hundred ";
            if (tens > 0)
                words += strOnes[tens - 1] + " ";
            if (singles > 0)
                words += strOnes[singles - 1] + " ";
            return words;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbTrack.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rd = ctrl as RadioButton;
                    rd.Checked = false;
                }
            }
            foreach (Control ctrl in gbCourses.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chk = ctrl as CheckBox;
                    chk.Checked = false;
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    txt.Clear();
                }
            }
            txtTotalFees.Text = "0";
            rdoNormal.Checked = true;
            txtName.Focus();
        }
    }
}
