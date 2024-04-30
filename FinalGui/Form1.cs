using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalGui
{
    public partial class Form1 : Form
    {
        //source: https://stackoverflow.com/questions/1236402/how-to-set-a-constant-decimal-value 


        float convertMeter = 0.0254F;
        float convertInch = 39.96F;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear results
            txtResult.Clear();
            ValuetxtBx.Clear();

        }

        private void ValuetxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //source:  https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0
            // Input Validation
            if (!float.TryParse(ValuetxtBx.Text, out float decMeasure))
            {
                MessageBox.Show("Invalid input. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ValuetxtBx.Clear();
                ValuetxtBx.Focus();
                return;
            }
            else
            {
                if (radioBtnInchestoM.Checked)
                {
                    float metersToinches = convertMeter * decMeasure;
                    txtResult.Text = ValuetxtBx.Text +" meters is " + metersToinches.ToString();
                    return;
                }
                if (radioButton2.Checked)
                { 
                    float inchesTometers = convertInch * decMeasure;
                    txtResult.Text = ValuetxtBx.Text + " inches is "+ inchesTometers.ToString();
                    return;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //source: https://stackoverflow.com/questions/1969720/c-sharp-textbox-to-listbox
            string[] items = Regex.Split(txtResult.Text, "\r\n");
            listBox1.Items.AddRange(items);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSavedEntries_TextChanged(object sender, EventArgs e)
        {
            //source to save to file: https://stackoverflow.com/questions/20595279/c-sharp-save-all-items-in-a-listbox-to-text-file
            //source for formatting: https://stackoverflow.com/questions/12013792/how-to-get-number-of-items-in-listbox
            const string sPath = "measures.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            

            txtSavedEntries.Text= "Saved "+listBox1.Items.Count.ToString() +" to file measures.txt";
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            //source:  https://stackoverflow.com/questions/6442098/how-to-clear-all-data-in-a-listbox
            listBox1.Items.Clear();
        }
    }
}
