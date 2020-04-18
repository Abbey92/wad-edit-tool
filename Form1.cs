using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wad_edit_tool
{
    public partial class Form1 : Form
    {
        public static string 程序目录 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase; //结尾包含斜杠
        public static string 初始目录 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //桌面
        public static string a = "\"wad cmd tool.exe\"";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }       
        private void Export_all(string File) //导出功能
        {           
            string b = " Export_all ";
            string c = File;
            string cmd = a + b + "\"" + c + "\"";
            string text1 = Class1.Callcmd(cmd);
            textBox1.Text = text1;            
        }
        private void Save_all(string FilePath) //保存功能
        {
            string b = " Save_all ";
            string c = FilePath;
            string cmd = a + b + "\"" + c + "\"";
            string text1 = Class1.Callcmd(cmd);
            textBox1.Text = text1;
        }
        private void Modify_all(string File , string FilePath) //替换功能
        {
            string b = " Modify_all ";
            string c = "\"" + File + "\"" + " " + "\"" + FilePath + "\"";
            string cmd = a + b + c;
            string text1 = Class1.Callcmd(cmd);
            textBox1.Text = text1;
        }
        private void Export_Filter(string File , string Filter) //搜索功能
        {
            string b = " Export_Filter ";
            string c = "\"" + File + "\"" + " " + "\"" + Filter + "\"";
            string cmd = a + b + c;
            string text1 = Class1.Callcmd(cmd);
            textBox1.Text = text1;
        }
        private void Export_Click(object sender, EventArgs e) //导出文件
        {
            if (!File.Exists(程序目录 + "wad cmd tool.exe")) //判断文件在不在
            {
                MessageBox.Show("wad cmd tool.exe , Not in the same directory  不在同一个目录");
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog(); ////文件对话框
            dialog.InitialDirectory = 初始目录; //初始目录设置到桌面
            dialog.Multiselect = false; //不支持多个文件打开
            dialog.Title = "选择文件"; //设置标题
            dialog.Filter = "wad游戏文件(*.wad.client)|*.wad.client|wad大厅文件(*.wad)|*.wad"; //文件过滤器
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;               
                Export_all(filePath);
                //Debug.WriteLine(filePath);                
            }
        }
        private void Save_Click(object sender, EventArgs e) //保存文件
        {
            if (!File.Exists(程序目录 + "wad cmd tool.exe")) 
            {
                MessageBox.Show("wad cmd tool.exe , Not in the same directory  不在同一个目录");
                return;
            }
            CommonOpenFileDialog dialog = new CommonOpenFileDialog(); //新版对话框
            dialog.IsFolderPicker = true;
            dialog.InitialDirectory = 初始目录;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string filePath = dialog.FileName;
                Save_all(filePath);
                //Debug.WriteLine(filePath);
            }
        }
        private void Select1_Click(object sender, EventArgs e) //选择文件1
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = 初始目录;
            dialog.Multiselect = false;
            dialog.Title = "Selected WADFile , 选择wad文件";
            dialog.Filter = "wad游戏文件(*.wad.client)|*.wad.client|wad大厅文件(*.wad)|*.wad";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                textBox2.Text = filePath;
            }
        }
        private void Select2_Click(object sender, EventArgs e) //选择文件2
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = 初始目录;
            dialog.Multiselect = false;
            dialog.Title = "Selected WADFile , 选择wad文件";
            dialog.Filter = "wad游戏文件(*.wad.client)|*.wad.client|wad大厅文件(*.wad)|*.wad";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                textBox3.Text = filePath;
            }
        }
        private void Modify_Click(object sender, EventArgs e) //替换文件
        {
            if (!File.Exists(程序目录 + "wad cmd tool.exe")) 
            {
                MessageBox.Show("wad cmd tool.exe , Not in the same directory  不在同一个目录");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Not Selected WADFile 未选择wad文件");
                return;
            }
            CommonOpenFileDialog dialog = new CommonOpenFileDialog(); 
            dialog.IsFolderPicker = true;
            dialog.InitialDirectory = 初始目录;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string filePath = dialog.FileName;
                Modify_all(textBox2.Text , filePath);               
            }
        }
        private void Filter_Click(object sender, EventArgs e) //搜索文件
        {
            if (!File.Exists(程序目录 + "wad cmd tool.exe"))
            {
                MessageBox.Show("wad cmd tool.exe , Not in the same directory  不在同一个目录");
                return;
            }
            if (textBox3.Text == "" )
            {
                MessageBox.Show("Not Selected WADFile 未选择wad文件");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Text filter is empty , 未输入被搜索的关键字");
                return;
            }
            Export_Filter(textBox3.Text , textBox4.Text);
        }
        private void Save_DragDrop(object sender, DragEventArgs e) //保存文件-拖放
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string extension = System.IO.Path.GetExtension(path);
            if (extension == "" ) //判断后叠名
            {
                Save_all(path);
            }
            else
            {
                MessageBox.Show("not directory , 不是文件目录");
            }
        }
        private void Save_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
            {
                e.Effect = DragDropEffects.All;
            }
            else 
            {
                e.Effect = DragDropEffects.None;
            }                              
        }
        private void Export_DragDrop(object sender, DragEventArgs e) //导出文件-拖放
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string extension = System.IO.Path.GetExtension(path);
            if (extension == ".wad" || extension == ".client") //判断后叠名
            {
                Export_all(path);
            }
            else
            {
                MessageBox.Show("not wad file , 不是wad文件");
            }
        }
        private void Export_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
