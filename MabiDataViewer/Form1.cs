﻿using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace MabiDataViewer
{
    public partial class Form1 : Form
    {
        private DataTable dataTable_itemDB, dataTable_ItemString;
        private DataSet dataSet_ItemDB = new DataSet(), dataSet_ItemString = new DataSet();
        private ItemDB _itemDB;

        public Form1()
        {
            InitializeComponent();
            radioButton_SerachID.CheckedChanged += (sender, e) =>
            {
                radioButton_SearchName.Checked = radioButton_SerachID.Checked ? false : radioButton_SearchName.Checked;
            };
            radioButton_SearchName.CheckedChanged += (sender, e) =>
            {
                radioButton_SerachID.Checked = radioButton_SearchName.Checked ? false : radioButton_SerachID.Checked;
            };
            _itemDB = new ItemDB(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                //將ItemString資料存入dataSet_ItemString
                dataSet_ItemString.Tables.Add(_itemDB.GetItemStringName(this.dataTable_ItemString));
                //將ItemDB資料存入dataSet_ItemDB
                dataSet_ItemDB.Tables.Add(_itemDB.GetItemDB(dataTable_itemDB, dataSet_ItemString));

                dataGridView1.DataSource = dataSet_ItemDB.Tables[0];
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            stopwatch.Stop();
            label1.Text = $"ItemDB 讀取耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }
        private void dataGridView_donate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 确保用户点击的是行而不是表头
            {
                
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                DataGridView dt = sender as DataGridView;
                textBox_ItemCategory.Text = dt.Rows[row].Cells[1].Value.ToString();
                textBox_ItemXML.Text = dt.Rows[row].Cells[2].Value.ToString();
                textBox_ItemDesc.Text = dt.Rows[row].Cells[5].Value.ToString();
                label_ItemID.Text = "道具編號: " + dt.Rows[row].Cells[0].Value.ToString();
                label_ItemName.Text = "道具名稱: " + dt.Rows[row].Cells[4].Value.ToString();
                label_Bundle.Text = "最大堆疊: " + dt.Rows[row].Cells[6].Value.ToString();
                groupBox_checkbox.Text = "Action Flag: " + dt.Rows[row].Cells[9].Value.ToString();
                //Update_checkbox(dt, row, col);
                pictureBox1.Image = _itemDB.GetItemPicture(dt.Rows[row].Cells[0].Value.ToString());
                _itemDB.GetActionFlag(dt, row);
            }
        }
        private bool Update_checkbox(DataGridView dt, int row, int col)
        {
            //預設所有Checkbox為不勾選
            foreach (Control control in groupBox_checkbox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
            switch (dt.Rows[row].Cells[9].Value.ToString())
            {
                case "0":
                    foreach (Control control in groupBox_checkbox.Controls)
                    {
                        if (control is CheckBox checkBox)
                        {
                            checkBox.Checked = true;
                        }
                    }
                    checkBox_DropLock.Checked = false; checkBox_BankCharacter.Checked = false; checkBox_Destroy.Checked = false;
                    break;
                case "1":
                    checkBox_DropLock.Checked = true; checkBox_Mail.Checked = true;
                    break;
                case "2":
                    break;
                case "3":
                    checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;
                case "4":
                    checkBox_Trade.Checked = true; checkBox_DropFree.Checked = true;
                    break;
                case "5":
                    checkBox_DropLock.Checked = true; checkBox_BankCharacter.Checked = true;
                    break;
                case "6":
                case "7":
                case "8":
                    break;
                case "9":
                    checkBox_DropLock.Checked = true;
                    break;
                case "10":
                    checkBox_Destroy.Checked = true; checkBox_BankCharacter.Checked = true;
                    break;
                case "12":
                    checkBox_Destroy.Checked = true; checkBox_BankAccount.Checked = true; checkBox_Pet.Checked = true;
                    break;
                case "13":
                    checkBox_BankCharacter.Checked = true;
                    break;
                case "14":
                    checkBox_TradeLimit.Checked = true; checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;
                case "16":
                    checkBox_DropLock.Checked = true;
                    break;
                case "17":
                    checkBox_DropLock.Checked = true; checkBox_BankAccount.Checked = true;
                    break;

            }
            //例外處理
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("destroyable"))
            {
                checkBox_Destroy.Checked = true;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dropable"))
            {
                checkBox_DropFree.Checked = false;
                checkBox_DropLock.Checked = false;
            }
            if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_mailbox"))
            {
                checkBox_Mail.Checked = false;
            }
            if (dt.Rows[row].Cells[12].Value.ToString().Contains("true"))
            {
                checkBox_dyeable.Checked = true;
                if (dt.Rows[row].Cells[1].Value.ToString().Contains("not_dyeable"))
                {
                    checkBox_dyeable.Checked = false;
                }
            }
            return true;
        }

        private void button_ItemSelect_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                if (!string.IsNullOrEmpty(textBox_ItemSerach.Text))
                {
                    dataGridView1.DataSource = _itemDB.GetItemFilteredSerach(textBox_ItemSerach.Text, dataSet_ItemDB, radioButton_SerachID);
                }
            }
            catch(Exception ex)
            {
                label1.Text = $"ItemDB 搜尋耗時 : ";
                MessageBox.Show("查無結果");
            }
            stopwatch.Stop();
            label1.Text = $"ItemDB 搜尋耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";
        }
        private void button_ItemReset_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            dataGridView1.DataSource = dataSet_ItemDB.Tables[0];
            stopwatch.Stop();
            label1.Text = $"ItemDB 重置耗時 : {stopwatch.Elapsed.TotalMilliseconds / 1000} 秒";

        }
    }
}
