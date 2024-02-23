﻿using System.Drawing;

namespace MabiDataViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_ItemSelect = new System.Windows.Forms.GroupBox();
            this.button_ItemReset = new System.Windows.Forms.Button();
            this.button_ItemSelect = new System.Windows.Forms.Button();
            this.radioButton_SearchName = new System.Windows.Forms.RadioButton();
            this.radioButton_SerachID = new System.Windows.Forms.RadioButton();
            this.label_ItemKeyword = new System.Windows.Forms.Label();
            this.textBox_ItemSerach = new System.Windows.Forms.TextBox();
            this.label_Bundle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_XML = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_checkbox = new System.Windows.Forms.GroupBox();
            this.checkBox_Mail = new System.Windows.Forms.CheckBox();
            this.checkBox_dyeable = new System.Windows.Forms.CheckBox();
            this.checkBox_TradeLimit = new System.Windows.Forms.CheckBox();
            this.checkBox_Trade = new System.Windows.Forms.CheckBox();
            this.checkBox_BankCharacter = new System.Windows.Forms.CheckBox();
            this.checkBox_DropFree = new System.Windows.Forms.CheckBox();
            this.checkBox_Pet = new System.Windows.Forms.CheckBox();
            this.checkBox_BankAccount = new System.Windows.Forms.CheckBox();
            this.checkBox_DropLock = new System.Windows.Forms.CheckBox();
            this.checkBox_Destroy = new System.Windows.Forms.CheckBox();
            this.textBox_ItemDesc = new System.Windows.Forms.TextBox();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.textBox_ItemCategory = new System.Windows.Forms.TextBox();
            this.label_ItemID = new System.Windows.Forms.Label();
            this.textBox_ItemXML = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SerachTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_ItemSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_checkbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 914);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_donate_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1454, 940);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_ItemSelect);
            this.tabPage1.Controls.Add(this.label_Bundle);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label_XML);
            this.tabPage1.Controls.Add(this.label_Category);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox_checkbox);
            this.tabPage1.Controls.Add(this.textBox_ItemDesc);
            this.tabPage1.Controls.Add(this.label_ItemName);
            this.tabPage1.Controls.Add(this.textBox_ItemCategory);
            this.tabPage1.Controls.Add(this.label_ItemID);
            this.tabPage1.Controls.Add(this.textBox_ItemXML);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1446, 914);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ItemDB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_ItemSelect
            // 
            this.groupBox_ItemSelect.Controls.Add(this.button_ItemReset);
            this.groupBox_ItemSelect.Controls.Add(this.button_ItemSelect);
            this.groupBox_ItemSelect.Controls.Add(this.radioButton_SearchName);
            this.groupBox_ItemSelect.Controls.Add(this.radioButton_SerachID);
            this.groupBox_ItemSelect.Controls.Add(this.label_ItemKeyword);
            this.groupBox_ItemSelect.Controls.Add(this.textBox_ItemSerach);
            this.groupBox_ItemSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_ItemSelect.Location = new System.Drawing.Point(1066, 3);
            this.groupBox_ItemSelect.Name = "groupBox_ItemSelect";
            this.groupBox_ItemSelect.Size = new System.Drawing.Size(375, 85);
            this.groupBox_ItemSelect.TabIndex = 29;
            this.groupBox_ItemSelect.TabStop = false;
            this.groupBox_ItemSelect.Text = "搜尋道具";
            // 
            // button_ItemReset
            // 
            this.button_ItemReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ItemReset.Location = new System.Drawing.Point(282, 19);
            this.button_ItemReset.Name = "button_ItemReset";
            this.button_ItemReset.Size = new System.Drawing.Size(82, 31);
            this.button_ItemReset.TabIndex = 33;
            this.button_ItemReset.Text = "重置結果";
            this.button_ItemReset.UseVisualStyleBackColor = true;
            this.button_ItemReset.Click += new System.EventHandler(this.button_ItemReset_Click);
            // 
            // button_ItemSelect
            // 
            this.button_ItemSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ItemSelect.Location = new System.Drawing.Point(194, 19);
            this.button_ItemSelect.Name = "button_ItemSelect";
            this.button_ItemSelect.Size = new System.Drawing.Size(82, 31);
            this.button_ItemSelect.TabIndex = 30;
            this.button_ItemSelect.Text = "開始搜尋";
            this.button_ItemSelect.UseVisualStyleBackColor = true;
            this.button_ItemSelect.Click += new System.EventHandler(this.button_ItemSelect_Click);
            // 
            // radioButton_SearchName
            // 
            this.radioButton_SearchName.AutoSize = true;
            this.radioButton_SearchName.Location = new System.Drawing.Point(248, 54);
            this.radioButton_SearchName.Name = "radioButton_SearchName";
            this.radioButton_SearchName.Size = new System.Drawing.Size(124, 25);
            this.radioButton_SearchName.TabIndex = 32;
            this.radioButton_SearchName.Text = "道具名稱搜尋";
            this.radioButton_SearchName.UseVisualStyleBackColor = true;
            // 
            // radioButton_SerachID
            // 
            this.radioButton_SerachID.AutoSize = true;
            this.radioButton_SerachID.Checked = true;
            this.radioButton_SerachID.Location = new System.Drawing.Point(10, 54);
            this.radioButton_SerachID.Name = "radioButton_SerachID";
            this.radioButton_SerachID.Size = new System.Drawing.Size(109, 25);
            this.radioButton_SerachID.TabIndex = 31;
            this.radioButton_SerachID.TabStop = true;
            this.radioButton_SerachID.Text = "道具ID搜尋";
            this.radioButton_SerachID.UseVisualStyleBackColor = true;
            // 
            // label_ItemKeyword
            // 
            this.label_ItemKeyword.AutoSize = true;
            this.label_ItemKeyword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemKeyword.Location = new System.Drawing.Point(6, 25);
            this.label_ItemKeyword.Name = "label_ItemKeyword";
            this.label_ItemKeyword.Size = new System.Drawing.Size(58, 21);
            this.label_ItemKeyword.TabIndex = 30;
            this.label_ItemKeyword.Text = "關鍵字";
            // 
            // textBox_ItemSerach
            // 
            this.textBox_ItemSerach.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemSerach.Location = new System.Drawing.Point(64, 20);
            this.textBox_ItemSerach.Name = "textBox_ItemSerach";
            this.textBox_ItemSerach.Size = new System.Drawing.Size(122, 29);
            this.textBox_ItemSerach.TabIndex = 30;
            this.SerachTip.SetToolTip(this.textBox_ItemSerach, "輸入道具編號或名稱");
            // 
            // label_Bundle
            // 
            this.label_Bundle.AutoSize = true;
            this.label_Bundle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Bundle.Location = new System.Drawing.Point(1062, 235);
            this.label_Bundle.Name = "label_Bundle";
            this.label_Bundle.Size = new System.Drawing.Size(78, 21);
            this.label_Bundle.TabIndex = 28;
            this.label_Bundle.Text = "最大堆疊:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1164, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label_XML
            // 
            this.label_XML.AutoSize = true;
            this.label_XML.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_XML.Location = new System.Drawing.Point(1066, 758);
            this.label_XML.Name = "label_XML";
            this.label_XML.Size = new System.Drawing.Size(37, 27);
            this.label_XML.TabIndex = 26;
            this.label_XML.Text = "Xml";
            this.label_XML.UseCompatibleTextRendering = true;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Category.Location = new System.Drawing.Point(1062, 651);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(80, 21);
            this.label_Category.TabIndex = 25;
            this.label_Category.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1062, 892);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "ItemDB 讀取耗時:";
            // 
            // groupBox_checkbox
            // 
            this.groupBox_checkbox.Controls.Add(this.checkBox_Mail);
            this.groupBox_checkbox.Controls.Add(this.checkBox_dyeable);
            this.groupBox_checkbox.Controls.Add(this.checkBox_TradeLimit);
            this.groupBox_checkbox.Controls.Add(this.checkBox_Trade);
            this.groupBox_checkbox.Controls.Add(this.checkBox_BankCharacter);
            this.groupBox_checkbox.Controls.Add(this.checkBox_DropFree);
            this.groupBox_checkbox.Controls.Add(this.checkBox_Pet);
            this.groupBox_checkbox.Controls.Add(this.checkBox_BankAccount);
            this.groupBox_checkbox.Controls.Add(this.checkBox_DropLock);
            this.groupBox_checkbox.Controls.Add(this.checkBox_Destroy);
            this.groupBox_checkbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_checkbox.Location = new System.Drawing.Point(1066, 264);
            this.groupBox_checkbox.Name = "groupBox_checkbox";
            this.groupBox_checkbox.Size = new System.Drawing.Size(375, 152);
            this.groupBox_checkbox.TabIndex = 23;
            this.groupBox_checkbox.TabStop = false;
            this.groupBox_checkbox.Text = "Action Flag: ";
            // 
            // checkBox_Mail
            // 
            this.checkBox_Mail.AutoSize = true;
            this.checkBox_Mail.Enabled = false;
            this.checkBox_Mail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Mail.Location = new System.Drawing.Point(220, 123);
            this.checkBox_Mail.Name = "checkBox_Mail";
            this.checkBox_Mail.Size = new System.Drawing.Size(61, 25);
            this.checkBox_Mail.TabIndex = 25;
            this.checkBox_Mail.Text = "郵寄";
            this.checkBox_Mail.UseVisualStyleBackColor = true;
            // 
            // checkBox_dyeable
            // 
            this.checkBox_dyeable.AutoSize = true;
            this.checkBox_dyeable.Enabled = false;
            this.checkBox_dyeable.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dyeable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_dyeable.Location = new System.Drawing.Point(5, 123);
            this.checkBox_dyeable.Name = "checkBox_dyeable";
            this.checkBox_dyeable.Size = new System.Drawing.Size(61, 25);
            this.checkBox_dyeable.TabIndex = 24;
            this.checkBox_dyeable.Text = "染色";
            this.checkBox_dyeable.UseVisualStyleBackColor = true;
            // 
            // checkBox_TradeLimit
            // 
            this.checkBox_TradeLimit.AutoSize = true;
            this.checkBox_TradeLimit.Enabled = false;
            this.checkBox_TradeLimit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_TradeLimit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_TradeLimit.Location = new System.Drawing.Point(220, 23);
            this.checkBox_TradeLimit.Name = "checkBox_TradeLimit";
            this.checkBox_TradeLimit.Size = new System.Drawing.Size(131, 25);
            this.checkBox_TradeLimit.TabIndex = 23;
            this.checkBox_TradeLimit.Text = "玩家交易(1次)";
            this.checkBox_TradeLimit.UseVisualStyleBackColor = true;
            // 
            // checkBox_Trade
            // 
            this.checkBox_Trade.AutoSize = true;
            this.checkBox_Trade.Enabled = false;
            this.checkBox_Trade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Trade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Trade.Location = new System.Drawing.Point(5, 23);
            this.checkBox_Trade.Name = "checkBox_Trade";
            this.checkBox_Trade.Size = new System.Drawing.Size(93, 25);
            this.checkBox_Trade.TabIndex = 14;
            this.checkBox_Trade.Text = "玩家交易";
            this.checkBox_Trade.UseVisualStyleBackColor = true;
            // 
            // checkBox_BankCharacter
            // 
            this.checkBox_BankCharacter.AutoSize = true;
            this.checkBox_BankCharacter.Enabled = false;
            this.checkBox_BankCharacter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BankCharacter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_BankCharacter.Location = new System.Drawing.Point(220, 73);
            this.checkBox_BankCharacter.Name = "checkBox_BankCharacter";
            this.checkBox_BankCharacter.Size = new System.Drawing.Size(137, 25);
            this.checkBox_BankCharacter.TabIndex = 21;
            this.checkBox_BankCharacter.Text = "銀行(角色綁定)";
            this.checkBox_BankCharacter.UseVisualStyleBackColor = true;
            // 
            // checkBox_DropFree
            // 
            this.checkBox_DropFree.AutoSize = true;
            this.checkBox_DropFree.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DropFree.Enabled = false;
            this.checkBox_DropFree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DropFree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_DropFree.Location = new System.Drawing.Point(5, 48);
            this.checkBox_DropFree.Name = "checkBox_DropFree";
            this.checkBox_DropFree.Size = new System.Drawing.Size(153, 25);
            this.checkBox_DropFree.TabIndex = 16;
            this.checkBox_DropFree.Text = "丟棄(可自由撿取)";
            this.checkBox_DropFree.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pet
            // 
            this.checkBox_Pet.AutoSize = true;
            this.checkBox_Pet.Enabled = false;
            this.checkBox_Pet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Pet.Location = new System.Drawing.Point(5, 98);
            this.checkBox_Pet.Name = "checkBox_Pet";
            this.checkBox_Pet.Size = new System.Drawing.Size(93, 25);
            this.checkBox_Pet.TabIndex = 22;
            this.checkBox_Pet.Text = "存放寵物";
            this.checkBox_Pet.UseVisualStyleBackColor = true;
            // 
            // checkBox_BankAccount
            // 
            this.checkBox_BankAccount.AutoSize = true;
            this.checkBox_BankAccount.Enabled = false;
            this.checkBox_BankAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BankAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_BankAccount.Location = new System.Drawing.Point(220, 48);
            this.checkBox_BankAccount.Name = "checkBox_BankAccount";
            this.checkBox_BankAccount.Size = new System.Drawing.Size(137, 25);
            this.checkBox_BankAccount.TabIndex = 20;
            this.checkBox_BankAccount.Text = "銀行(帳號共享)";
            this.checkBox_BankAccount.UseVisualStyleBackColor = true;
            // 
            // checkBox_DropLock
            // 
            this.checkBox_DropLock.AutoSize = true;
            this.checkBox_DropLock.Enabled = false;
            this.checkBox_DropLock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DropLock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_DropLock.Location = new System.Drawing.Point(5, 73);
            this.checkBox_DropLock.Name = "checkBox_DropLock";
            this.checkBox_DropLock.Size = new System.Drawing.Size(153, 25);
            this.checkBox_DropLock.TabIndex = 19;
            this.checkBox_DropLock.Text = "丟棄(保留所有權)";
            this.checkBox_DropLock.UseVisualStyleBackColor = true;
            // 
            // checkBox_Destroy
            // 
            this.checkBox_Destroy.AutoSize = true;
            this.checkBox_Destroy.Enabled = false;
            this.checkBox_Destroy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Destroy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_Destroy.Location = new System.Drawing.Point(220, 98);
            this.checkBox_Destroy.Name = "checkBox_Destroy";
            this.checkBox_Destroy.Size = new System.Drawing.Size(61, 25);
            this.checkBox_Destroy.TabIndex = 15;
            this.checkBox_Destroy.Text = "銷毀";
            this.checkBox_Destroy.UseVisualStyleBackColor = true;
            // 
            // textBox_ItemDesc
            // 
            this.textBox_ItemDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemDesc.Location = new System.Drawing.Point(1066, 160);
            this.textBox_ItemDesc.Multiline = true;
            this.textBox_ItemDesc.Name = "textBox_ItemDesc";
            this.textBox_ItemDesc.ReadOnly = true;
            this.textBox_ItemDesc.Size = new System.Drawing.Size(375, 65);
            this.textBox_ItemDesc.TabIndex = 12;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemName.Location = new System.Drawing.Point(1062, 127);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(78, 21);
            this.label_ItemName.TabIndex = 6;
            this.label_ItemName.Text = "道具名稱:";
            // 
            // textBox_ItemCategory
            // 
            this.textBox_ItemCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemCategory.Location = new System.Drawing.Point(1066, 675);
            this.textBox_ItemCategory.Multiline = true;
            this.textBox_ItemCategory.Name = "textBox_ItemCategory";
            this.textBox_ItemCategory.ReadOnly = true;
            this.textBox_ItemCategory.Size = new System.Drawing.Size(375, 65);
            this.textBox_ItemCategory.TabIndex = 5;
            // 
            // label_ItemID
            // 
            this.label_ItemID.AutoSize = true;
            this.label_ItemID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ItemID.Location = new System.Drawing.Point(1062, 95);
            this.label_ItemID.Name = "label_ItemID";
            this.label_ItemID.Size = new System.Drawing.Size(78, 21);
            this.label_ItemID.TabIndex = 4;
            this.label_ItemID.Text = "道具編號:";
            // 
            // textBox_ItemXML
            // 
            this.textBox_ItemXML.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ItemXML.Location = new System.Drawing.Point(1066, 785);
            this.textBox_ItemXML.Multiline = true;
            this.textBox_ItemXML.Name = "textBox_ItemXML";
            this.textBox_ItemXML.ReadOnly = true;
            this.textBox_ItemXML.Size = new System.Drawing.Size(375, 104);
            this.textBox_ItemXML.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1446, 914);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OptionSet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 945);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MabiDataViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_ItemSelect.ResumeLayout(false);
            this.groupBox_ItemSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_checkbox.ResumeLayout(false);
            this.groupBox_checkbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_ItemXML;
        private System.Windows.Forms.Label label_ItemID;
        private System.Windows.Forms.TextBox textBox_ItemCategory;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.ToolTip SerachTip;
        private System.Windows.Forms.TextBox textBox_ItemDesc;
        public System.Windows.Forms.CheckBox checkBox_Trade;
        public System.Windows.Forms.CheckBox checkBox_BankCharacter;
        public System.Windows.Forms.CheckBox checkBox_Pet;
        public System.Windows.Forms.CheckBox checkBox_DropLock;
        public System.Windows.Forms.CheckBox checkBox_Destroy;
        public System.Windows.Forms.CheckBox checkBox_BankAccount;
        public System.Windows.Forms.CheckBox checkBox_DropFree;
        public System.Windows.Forms.GroupBox groupBox_checkbox;
        public System.Windows.Forms.CheckBox checkBox_TradeLimit;
        public System.Windows.Forms.CheckBox checkBox_Mail;
        public System.Windows.Forms.CheckBox checkBox_dyeable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_XML;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Bundle;
        private System.Windows.Forms.GroupBox groupBox_ItemSelect;
        private System.Windows.Forms.Label label_ItemKeyword;
        private System.Windows.Forms.TextBox textBox_ItemSerach;
        private System.Windows.Forms.RadioButton radioButton_SearchName;
        private System.Windows.Forms.RadioButton radioButton_SerachID;
        private System.Windows.Forms.Button button_ItemReset;
        private System.Windows.Forms.Button button_ItemSelect;
        private System.Data.DataSet dataSet1;
    }
}

