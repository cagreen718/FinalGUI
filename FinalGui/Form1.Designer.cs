namespace FinalGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ValuetxtBx = new TextBox();
            listBox1 = new ListBox();
            btnConvert = new Button();
            txtResult = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            txtSavedEntries = new TextBox();
            btnClearList = new Button();
            btnSaveFile = new Button();
            radioBtnInchestoM = new RadioButton();
            radioButton2 = new RadioButton();
            Convert = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 325);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(340, 36);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "Converter App 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(314, 110);
            label2.Name = "label2";
            label2.Size = new Size(170, 50);
            label2.TabIndex = 2;
            label2.Text = "Enter a value and \r\nchoose conversion";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ValuetxtBx
            // 
            ValuetxtBx.BackColor = Color.FromArgb(0, 0, 192);
            ValuetxtBx.ForeColor = SystemColors.InactiveBorder;
            ValuetxtBx.Location = new Point(510, 121);
            ValuetxtBx.Name = "ValuetxtBx";
            ValuetxtBx.Size = new Size(238, 31);
            ValuetxtBx.TabIndex = 4;
            ValuetxtBx.TextChanged += ValuetxtBx_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(22, 367);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 529);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvert.Location = new Point(340, 532);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(207, 34);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ActiveCaption;
            txtResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtResult.Location = new Point(350, 617);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(377, 31);
            txtResult.TabIndex = 7;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(357, 722);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(238, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Results";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(357, 790);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(238, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Results";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button3_Click;
            // 
            // txtSavedEntries
            // 
            txtSavedEntries.BackColor = SystemColors.ActiveCaption;
            txtSavedEntries.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSavedEntries.Location = new Point(350, 924);
            txtSavedEntries.Name = "txtSavedEntries";
            txtSavedEntries.Size = new Size(377, 31);
            txtSavedEntries.TabIndex = 10;
            txtSavedEntries.TextChanged += txtSavedEntries_TextChanged;
            // 
            // btnClearList
            // 
            btnClearList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearList.Location = new Point(22, 962);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(112, 34);
            btnClearList.TabIndex = 11;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveFile.Location = new Point(158, 962);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(123, 34);
            btnSaveFile.TabIndex = 12;
            btnSaveFile.Text = "Save to File";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // radioBtnInchestoM
            // 
            radioBtnInchestoM.AutoSize = true;
            radioBtnInchestoM.BackColor = Color.FromArgb(0, 0, 192);
            radioBtnInchestoM.ForeColor = SystemColors.ButtonHighlight;
            radioBtnInchestoM.Location = new Point(415, 327);
            radioBtnInchestoM.Name = "radioBtnInchestoM";
            radioBtnInchestoM.Size = new Size(174, 29);
            radioBtnInchestoM.TabIndex = 13;
            radioBtnInchestoM.TabStop = true;
            radioBtnInchestoM.Text = "Inchest to Meters";
            radioBtnInchestoM.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(0, 0, 192);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(418, 391);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(168, 29);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Meters to Inches";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Convert
            // 
            Convert.BackColor = Color.Blue;
            Convert.Location = new Point(329, 237);
            Convert.Name = "Convert";
            Convert.Size = new Size(518, 253);
            Convert.TabIndex = 3;
            Convert.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1032, 1062);
            Controls.Add(radioButton2);
            Controls.Add(radioBtnInchestoM);
            Controls.Add(btnSaveFile);
            Controls.Add(btnClearList);
            Controls.Add(txtSavedEntries);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtResult);
            Controls.Add(btnConvert);
            Controls.Add(listBox1);
            Controls.Add(ValuetxtBx);
            Controls.Add(Convert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Building Plans Conversion 2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private TextBox ValuetxtBx;
        private ListBox listBox1;
        private Button btnConvert;
        private TextBox txtResult;
        private Button btnSave;
        private Button btnClear;
        private TextBox txtSavedEntries;
        private Button btnClearList;
        private Button btnSaveFile;
        private RadioButton radioBtnInchestoM;
        private RadioButton radioButton2;
        private ListView Convert;
    }
}
