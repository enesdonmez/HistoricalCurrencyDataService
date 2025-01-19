namespace HistoricalRates
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            txtFromCurreny = new TextBox();
            dataGridView1 = new DataGridView();
            HistoricalRatesServiceClientBindingSource = new BindingSource(components);
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HistoricalRatesServiceClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(636, 12);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 0;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFromCurreny
            // 
            txtFromCurreny.AutoCompleteCustomSource.AddRange(new string[] { "USD", "EUR" });
            txtFromCurreny.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFromCurreny.CharacterCasing = CharacterCasing.Upper;
            txtFromCurreny.Location = new Point(125, 10);
            txtFromCurreny.Name = "txtFromCurreny";
            txtFromCurreny.Size = new Size(143, 27);
            txtFromCurreny.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(758, 350);
            dataGridView1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(470, 10);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "Base curency :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 9);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 8;
            label2.Text = "currency to be converted :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(780, 504);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtFromCurreny);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HİSTORİCAL DATA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HistoricalRatesServiceClientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtFromCurreny;
        private DataGridView dataGridView1;
        private BindingSource HistoricalRatesServiceClientBindingSource;
        private BindingSource historicalRatesServiceClientBindingSource;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
    }
}
