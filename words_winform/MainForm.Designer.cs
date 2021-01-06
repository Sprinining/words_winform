namespace words_winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_updateWordList = new System.Windows.Forms.Button();
            this.btn_randomword = new System.Windows.Forms.Button();
            this.wordlistView = new System.Windows.Forms.ListView();
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.comboBox_kind = new System.Windows.Forms.ComboBox();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.lb_randomchinese = new System.Windows.Forms.Label();
            this.comboBox_randomunit = new System.Windows.Forms.ComboBox();
            this.textBox_inputword = new System.Windows.Forms.TextBox();
            this.lb_trueorfalse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_updateWordList
            // 
            this.btn_updateWordList.Location = new System.Drawing.Point(512, 167);
            this.btn_updateWordList.Name = "btn_updateWordList";
            this.btn_updateWordList.Size = new System.Drawing.Size(140, 40);
            this.btn_updateWordList.TabIndex = 0;
            this.btn_updateWordList.Text = "刷新单词";
            this.btn_updateWordList.UseVisualStyleBackColor = true;
            this.btn_updateWordList.Click += new System.EventHandler(this.btn_updateWordList_Click);
            // 
            // btn_randomword
            // 
            this.btn_randomword.Location = new System.Drawing.Point(512, 12);
            this.btn_randomword.Name = "btn_randomword";
            this.btn_randomword.Size = new System.Drawing.Size(140, 40);
            this.btn_randomword.TabIndex = 1;
            this.btn_randomword.Text = "随机抽词";
            this.btn_randomword.UseVisualStyleBackColor = true;
            this.btn_randomword.Click += new System.EventHandler(this.btn_randomword_Click);
            // 
            // wordlistView
            // 
            this.wordlistView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wordlistView.HideSelection = false;
            this.wordlistView.Location = new System.Drawing.Point(0, 256);
            this.wordlistView.Name = "wordlistView";
            this.wordlistView.Size = new System.Drawing.Size(678, 488);
            this.wordlistView.TabIndex = 2;
            this.wordlistView.UseCompatibleStateImageBehavior = false;
            this.wordlistView.SelectedIndexChanged += new System.EventHandler(this.wordlistView_SelectedIndexChanged);
            // 
            // comboBox_order
            // 
            this.comboBox_order.FormattingEnabled = true;
            this.comboBox_order.Location = new System.Drawing.Point(12, 175);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(121, 26);
            this.comboBox_order.TabIndex = 3;
            // 
            // comboBox_kind
            // 
            this.comboBox_kind.FormattingEnabled = true;
            this.comboBox_kind.Location = new System.Drawing.Point(175, 175);
            this.comboBox_kind.Name = "comboBox_kind";
            this.comboBox_kind.Size = new System.Drawing.Size(121, 26);
            this.comboBox_kind.TabIndex = 4;
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Location = new System.Drawing.Point(330, 175);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(121, 26);
            this.comboBox_unit.TabIndex = 5;
            // 
            // lb_randomchinese
            // 
            this.lb_randomchinese.Location = new System.Drawing.Point(12, 64);
            this.lb_randomchinese.Name = "lb_randomchinese";
            this.lb_randomchinese.Size = new System.Drawing.Size(640, 23);
            this.lb_randomchinese.TabIndex = 6;
            this.lb_randomchinese.Text = "中文：";
            // 
            // comboBox_randomunit
            // 
            this.comboBox_randomunit.FormattingEnabled = true;
            this.comboBox_randomunit.Location = new System.Drawing.Point(12, 20);
            this.comboBox_randomunit.Name = "comboBox_randomunit";
            this.comboBox_randomunit.Size = new System.Drawing.Size(121, 26);
            this.comboBox_randomunit.TabIndex = 7;
            // 
            // textBox_inputword
            // 
            this.textBox_inputword.Location = new System.Drawing.Point(12, 101);
            this.textBox_inputword.Name = "textBox_inputword";
            this.textBox_inputword.Size = new System.Drawing.Size(226, 28);
            this.textBox_inputword.TabIndex = 8;
            this.textBox_inputword.TextChanged += new System.EventHandler(this.textBox_inputword_TextChanged);
            // 
            // lb_trueorfalse
            // 
            this.lb_trueorfalse.Font = new System.Drawing.Font("宋体", 15F);
            this.lb_trueorfalse.Location = new System.Drawing.Point(238, 87);
            this.lb_trueorfalse.Name = "lb_trueorfalse";
            this.lb_trueorfalse.Size = new System.Drawing.Size(58, 55);
            this.lb_trueorfalse.TabIndex = 9;
            this.lb_trueorfalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 744);
            this.Controls.Add(this.lb_trueorfalse);
            this.Controls.Add(this.textBox_inputword);
            this.Controls.Add(this.comboBox_randomunit);
            this.Controls.Add(this.lb_randomchinese);
            this.Controls.Add(this.comboBox_unit);
            this.Controls.Add(this.comboBox_kind);
            this.Controls.Add(this.comboBox_order);
            this.Controls.Add(this.wordlistView);
            this.Controls.Add(this.btn_randomword);
            this.Controls.Add(this.btn_updateWordList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "今天不学习，明天变垃圾";
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updateWordList;
        private System.Windows.Forms.Button btn_randomword;
        private System.Windows.Forms.ListView wordlistView;
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.ComboBox comboBox_kind;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Label lb_randomchinese;
        private System.Windows.Forms.ComboBox comboBox_randomunit;
        private System.Windows.Forms.TextBox textBox_inputword;
        private System.Windows.Forms.Label lb_trueorfalse;
    }
}