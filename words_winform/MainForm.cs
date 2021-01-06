using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words_winform
{
    public partial class MainForm : Form
    {
        WordHelper wordHelper = new WordHelper();
        List<Word> wordlist = new List<Word>();//单词列表
        Word randomword = new Word();//随机抽的单词
        public MainForm()
        {
            InitializeComponent();
            InitLabel();
            InitComboBox();

            InitListView(wordlistView);//初始化listview
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            
            //弹出消息框，并获取消息框的返回值
            DialogResult dr = MessageBox.Show("是否打开新窗体？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //如果消息框返回值是Yes，显示新窗体
            if (dr == DialogResult.Yes)
            {
                //创建NewForm窗体实例
                NewForm newForm = new NewForm();
                //打开NewForm窗体
                newForm.Show();
            }
            //如果消息框返回值是No，关闭当前窗体
            else if (dr == DialogResult.No)
            {
                //关闭当前窗体
                this.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void wordlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InitListView(ListView lv)
        {
            //设置属性
            lv.GridLines = true;  //显示网格线
            lv.FullRowSelect = true;  //显示全行
            lv.MultiSelect = false;  //设置只能单选
            lv.View = View.Details;  //设置显示模式为详细
            lv.HoverSelection = true;  //当鼠标停留数秒后自动选择
            lv.Scrollable = true;
            //把列名添加到listview中
            lv.Columns.Add("英文", 150);//列名和宽度
            lv.Columns.Add("中文", 550);

            UpdateListView(wordlistView);
        }

        public void UpdateListView(ListView lv)
        {
            lv.Items.Clear();
            //添加数据
            string str = "";
            if(comboBox_unit.SelectedIndex != 0)
            {
                str = comboBox_unit.SelectedItem.ToString();
                str = str.Substring(4, 1);//截取最后一个字符
            }
            //浅拷贝
            wordlist = wordHelper.Display(comboBox_order.SelectedIndex, comboBox_kind.SelectedIndex, str);

            //显示
            foreach (var w in wordlist)
            {
                ListViewItem item = new ListViewItem();      //先实例化ListViewItem这个类
                switch (comboBox_kind.SelectedIndex)
                {
                    case 0:
                        item.Text = w.English;                             //添加第1列内容
                        item.SubItems.Add(w.Chinese);                      //添加第2列内容(之后的列也是同样的方法)
                        break;
                    case 1:
                        item.Text = w.English;                             
                        item.SubItems.Add("");
                        break;
                    case 2:
                        item.Text = "";                             
                        item.SubItems.Add(w.Chinese);
                        break;
                    case 3:
                        item.Text = "";
                        item.SubItems.Add("");
                        break;
                    default:
                        Console.WriteLine("未知的显示方式！！！");
                        break;
                }
               
                wordlistView.Items.Add(item);
            }

        }

        public void InitComboBox()
        {
            //单词顺序
            comboBox_order.Items.Add("原序");
            comboBox_order.Items.Add("正序");
            comboBox_order.Items.Add("逆序");
            comboBox_order.Items.Add("随机");
            comboBox_order.SelectedIndex = 0;

            //显示形式
            comboBox_kind.Items.Add("中英文");
            comboBox_kind.Items.Add("英文");
            comboBox_kind.Items.Add("中文");
            comboBox_kind.Items.Add("隐藏");
            comboBox_kind.SelectedIndex = 0;

            //单元
            comboBox_unit.Items.Add("全部单元");
            foreach(var l in WordHelper.wordlist.wordUnits)
            {
                comboBox_unit.Items.Add($"unit{l.unit}");
               

            }
            comboBox_unit.SelectedIndex = 0;

            //抽词单元
            comboBox_randomunit.Items.Add("全部单元");
            foreach (var l in WordHelper.wordlist.wordUnits)
            {
                comboBox_randomunit.Items.Add($"unit{l.unit}");


            }
            comboBox_randomunit.SelectedIndex = 0;
        }

        public void InitLabel()
        {
            lb_trueorfalse.BackColor = Color.Transparent;
        }

        private void btn_updateWordList_Click(object sender, EventArgs e)
        {
            UpdateListView(wordlistView);
        }

        //随机抽词
        private void btn_randomword_Click(object sender, EventArgs e)
        {
            string str = "";
            if (comboBox_unit.SelectedIndex != 0)
            {
                str = comboBox_unit.SelectedItem.ToString();
                str = str.Substring(4, 1);//截取最后一个字符
            }
            randomword = wordHelper.RandomWord(str);
            lb_randomchinese.Text = randomword.Chinese;
        }

        private void textBox_inputword_TextChanged(object sender, EventArgs e)
        {
            if(textBox_inputword.Text.Trim() == randomword.English)
            {
                lb_trueorfalse.Text = "✔";
                lb_trueorfalse.ForeColor = Color.Green;
            }
            else
            {
                lb_trueorfalse.Text = "❌";
                lb_trueorfalse.ForeColor = Color.Red;
            }
        }
    }
}
