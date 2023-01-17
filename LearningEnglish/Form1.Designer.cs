namespace LearningEnglish
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
            this.textBox_UATranslate = new System.Windows.Forms.TextBox();
            this.btn_Audit_Word = new System.Windows.Forms.Button();
            this.label_Return = new System.Windows.Forms.Label();
            this.textBox_ENWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lerningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWordToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_InsertToDB = new System.Windows.Forms.Button();
            this.textBox_AddTranslateUA = new System.Windows.Forms.TextBox();
            this.textBox_AddWordEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_StartLerning = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_UATranslate
            // 
            this.textBox_UATranslate.Location = new System.Drawing.Point(528, 156);
            this.textBox_UATranslate.Name = "textBox_UATranslate";
            this.textBox_UATranslate.Size = new System.Drawing.Size(150, 23);
            this.textBox_UATranslate.TabIndex = 3;
            // 
            // btn_Audit_Word
            // 
            this.btn_Audit_Word.Location = new System.Drawing.Point(528, 339);
            this.btn_Audit_Word.Name = "btn_Audit_Word";
            this.btn_Audit_Word.Size = new System.Drawing.Size(150, 30);
            this.btn_Audit_Word.TabIndex = 0;
            this.btn_Audit_Word.Text = "Audit translate";
            this.btn_Audit_Word.UseVisualStyleBackColor = true;
            this.btn_Audit_Word.Click += new System.EventHandler(this.btn_Audit_Word_Click);
            // 
            // label_Return
            // 
            this.label_Return.AutoSize = true;
            this.label_Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Return.Location = new System.Drawing.Point(528, 71);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(0, 21);
            this.label_Return.TabIndex = 5;
            // 
            // textBox_ENWord
            // 
            this.textBox_ENWord.Location = new System.Drawing.Point(79, 156);
            this.textBox_ENWord.Name = "textBox_ENWord";
            this.textBox_ENWord.Size = new System.Drawing.Size(150, 23);
            this.textBox_ENWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "English word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Translate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lerningToolStripMenuItem,
            this.addNewWordToDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lerningToolStripMenuItem
            // 
            this.lerningToolStripMenuItem.Name = "lerningToolStripMenuItem";
            this.lerningToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lerningToolStripMenuItem.Text = "Lerning";
            // 
            // addNewWordToDBToolStripMenuItem
            // 
            this.addNewWordToDBToolStripMenuItem.Name = "addNewWordToDBToolStripMenuItem";
            this.addNewWordToDBToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.addNewWordToDBToolStripMenuItem.Text = "Add new word to DB";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 424);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_StartLerning);
            this.tabPage1.Controls.Add(this.label_Return);
            this.tabPage1.Controls.Add(this.btn_Audit_Word);
            this.tabPage1.Controls.Add(this.textBox_UATranslate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_ENWord);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lerning";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_InsertToDB);
            this.tabPage2.Controls.Add(this.textBox_AddTranslateUA);
            this.tabPage2.Controls.Add(this.textBox_AddWordEN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add new word to DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_InsertToDB
            // 
            this.button_InsertToDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_InsertToDB.Location = new System.Drawing.Point(100, 150);
            this.button_InsertToDB.Name = "button_InsertToDB";
            this.button_InsertToDB.Size = new System.Drawing.Size(100, 30);
            this.button_InsertToDB.TabIndex = 4;
            this.button_InsertToDB.Text = "Insert";
            this.button_InsertToDB.UseVisualStyleBackColor = true;
            this.button_InsertToDB.Click += new System.EventHandler(this.button_InsertToDB_Click);
            // 
            // textBox_AddTranslateUA
            // 
            this.textBox_AddTranslateUA.Location = new System.Drawing.Point(174, 72);
            this.textBox_AddTranslateUA.Name = "textBox_AddTranslateUA";
            this.textBox_AddTranslateUA.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddTranslateUA.TabIndex = 3;
            // 
            // textBox_AddWordEN
            // 
            this.textBox_AddWordEN.Location = new System.Drawing.Point(30, 72);
            this.textBox_AddWordEN.Name = "textBox_AddWordEN";
            this.textBox_AddWordEN.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddWordEN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ukraine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "English";
            // 
            // btn_StartLerning
            // 
            this.btn_StartLerning.Location = new System.Drawing.Point(79, 339);
            this.btn_StartLerning.Name = "btn_StartLerning";
            this.btn_StartLerning.Size = new System.Drawing.Size(150, 30);
            this.btn_StartLerning.TabIndex = 6;
            this.btn_StartLerning.Text = "Start";
            this.btn_StartLerning.UseVisualStyleBackColor = true;
            this.btn_StartLerning.Click += new System.EventHandler(this.btn_StartLerning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LerningEnglish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_UATranslate;
        private Button btn_Audit_Word;
        private Label label_Return;
        private TextBox textBox_ENWord;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lerningToolStripMenuItem;
        private ToolStripMenuItem addNewWordToDBToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_InsertToDB;
        private TextBox textBox_AddTranslateUA;
        private TextBox textBox_AddWordEN;
        private Label label4;
        private Label label3;
        private Button btn_StartLerning;
    }
}