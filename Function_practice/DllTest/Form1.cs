using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;

namespace DllTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var item in Process.GetProcesses())
            {
                if (item.ProcessName == "EXCEL")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                // excelApp = new Excel.Application();
                var excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook book = null;
                Excel.Worksheet sheet = null;
                Excel.Range range = null;


                try
                {
                    // book = excelApp.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);//開啟舊檔案
                    book = excelApp.Workbooks.Open(textBox1.Text);
                    // sheet = (Excel.Worksheet)book.Sheets[worksheet];
                    book.Password = textBox3.Text;
                    book.SaveAs(textBox4.Text);

                }
                catch (Exception ex)
                {
             //       DMMLog(ex.Message);
                }
                finally
                {
                    book.Close();
                    book = null;
                    excelApp.Quit();
                    excelApp = null;

                    foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcesses())
                    {
                        if (proc.ProcessName == "EXCEL")
                        {
                            proc.Kill();
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("請關閉excel在進行此動作");
             //   DMMLog("請關閉excel在進行此動作");
            }

            //String a ="C:\\Users\\Kevin.huang\\Desktop\\新人文件\\Outlook密碼變更方式.pdf";
            //String b = "C:\\Users\\Kevin.huang\\Desktop\\新人文件\\";

            //if (!Directory.Exists(b))
            //{
            //    Console.WriteLine("Cannot find directory '{0}'", b);
            //    return;
            //}
            //try
            //{
            //    string[] filenames = Directory.GetFiles(b);
            //    using (ZipOutputStream s = new ZipOutputStream(File.Create(a)))
            //    {
            //        s.SetLevel(9); // 壓縮級別 0-9
            //        s.Password = "123"; //Zip壓縮文件密碼
            //        byte[] buffer = new byte[4096]; //緩沖區大小
            //        foreach (string file in filenames)
            //        {
            //            ZipEntry entry = new ZipEntry(Path.GetFileName(file));
            //            entry.DateTime = DateTime.Now;
            //            s.PutNextEntry(entry);
            //            using (FileStream fs = File.OpenRead(file))
            //            {
            //                int sourceBytes;
            //                do
            //                {
            //                    sourceBytes = fs.Read(buffer, 0, buffer.Length);
            //                    s.Write(buffer, 0, sourceBytes);
            //                } while (sourceBytes > 0);
            //            }
            //        }
            //        s.Finish();
            //        s.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception during processing {0}", ex);
            //}




        }

        private void button_7z_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Program Files\7-zip\7z.exe";
            process.StartInfo.Arguments = @"e " + zipInput.Text + " -o" + zipOutput.Text + " -y";
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            //計算excel col

            int a = 0;
            string path =textBox7.Text ; // get excel path 
            //int num = Convert.ToInt16(textBox8.Text);
            string num = textBox8.Text; // get sheet name 

            Excel.Application app = new Excel.Application();
            object omissing = System.Reflection.Missing.Value;
            Excel.Workbook workbook = app.Workbooks.Open(path, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing, omissing);
            //Excel.Sheets sheets = workbook.Worksheets;//读取Excel表格的标签页
            //Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(num);//選擇第幾張頁面
            Excel.Worksheet sheets =new Excel.Worksheet() ;
            sheets = workbook.Worksheets[num];
            a= sheets.UsedRange.Rows.Count;
            String aa = a.ToString();
            Console.WriteLine(aa);

            listBox1.Items.Add(aa);
            // alert(a.ToString);
            workbook.Close(); 
 

        }
    }
}
