using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;

namespace BSWebhookSender
{
    partial class BSForm1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSForm1));
            this.WebhookListbox = new System.Windows.Forms.ListBox();
            this.WebhookTB = new System.Windows.Forms.TextBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LOADWebhookBTN = new System.Windows.Forms.Button();
            this.PluusWebhookBTN = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.TimeListBox = new System.Windows.Forms.ListBox();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.lbNt = new System.Windows.Forms.Label();
            this.SenderTB = new System.Windows.Forms.TextBox();
            this.PromotionBTN = new System.Windows.Forms.Button();
            this.RemoveTimeBTN = new System.Windows.Forms.Button();
            this.ClearTimeBTN = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timePath = new System.Windows.Forms.TextBox();
            this.btntimePath = new System.Windows.Forms.Button();
            this.savetimeBTN = new System.Windows.Forms.Button();
            this.loadtimeBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ContenTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listTime = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebhookListbox
            // 
            this.WebhookListbox.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebhookListbox.ForeColor = System.Drawing.Color.Black;
            this.WebhookListbox.FormattingEnabled = true;
            this.WebhookListbox.ItemHeight = 12;
            this.WebhookListbox.Location = new System.Drawing.Point(6, 80);
            this.WebhookListbox.Name = "WebhookListbox";
            this.WebhookListbox.Size = new System.Drawing.Size(360, 196);
            this.WebhookListbox.TabIndex = 1;
            // 
            // WebhookTB
            // 
            this.WebhookTB.BackColor = System.Drawing.SystemColors.Window;
            this.WebhookTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebhookTB.ForeColor = System.Drawing.Color.DarkGray;
            this.WebhookTB.Location = new System.Drawing.Point(5, 282);
            this.WebhookTB.Multiline = true;
            this.WebhookTB.Name = "WebhookTB";
            this.WebhookTB.Size = new System.Drawing.Size(361, 18);
            this.WebhookTB.TabIndex = 2;
            this.WebhookTB.Text = "웹훅링크";
            this.WebhookTB.Enter += new System.EventHandler(this.WebhookTB_Enter);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveBTN.Location = new System.Drawing.Point(372, 80);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(74, 83);
            this.SaveBTN.TabIndex = 3;
            this.SaveBTN.Text = "저장";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "웹훅 리스트";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LOADWebhookBTN
            // 
            this.LOADWebhookBTN.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LOADWebhookBTN.Location = new System.Drawing.Point(372, 169);
            this.LOADWebhookBTN.Name = "LOADWebhookBTN";
            this.LOADWebhookBTN.Size = new System.Drawing.Size(74, 107);
            this.LOADWebhookBTN.TabIndex = 7;
            this.LOADWebhookBTN.Text = "불러오기";
            this.LOADWebhookBTN.UseVisualStyleBackColor = true;
            this.LOADWebhookBTN.Click += new System.EventHandler(this.LOADWebhookBTN_Click);
            // 
            // PluusWebhookBTN
            // 
            this.PluusWebhookBTN.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PluusWebhookBTN.Location = new System.Drawing.Point(372, 282);
            this.PluusWebhookBTN.Name = "PluusWebhookBTN";
            this.PluusWebhookBTN.Size = new System.Drawing.Size(74, 18);
            this.PluusWebhookBTN.TabIndex = 8;
            this.PluusWebhookBTN.Text = "추가";
            this.PluusWebhookBTN.UseVisualStyleBackColor = true;
            this.PluusWebhookBTN.Click += new System.EventHandler(this.PluusWebhookBTN_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Delay
            // 
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // TimeListBox
            // 
            this.TimeListBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeListBox.ForeColor = System.Drawing.Color.Black;
            this.TimeListBox.FormattingEnabled = true;
            this.TimeListBox.ItemHeight = 12;
            this.TimeListBox.Items.AddRange(new object[] {
            "오후 1:30:00"});
            this.TimeListBox.Location = new System.Drawing.Point(6, 379);
            this.TimeListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeListBox.Name = "TimeListBox";
            this.TimeListBox.Size = new System.Drawing.Size(360, 196);
            this.TimeListBox.TabIndex = 9;
            // 
            // tbxTime
            // 
            this.tbxTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxTime.Location = new System.Drawing.Point(6, 580);
            this.tbxTime.Multiline = true;
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(360, 18);
            this.tbxTime.TabIndex = 10;
            this.tbxTime.Text = "오후 1:30:00";
            this.tbxTime.Enter += new System.EventHandler(this.tbxTime_Enter);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTime.Location = new System.Drawing.Point(372, 580);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(74, 18);
            this.btnTime.TabIndex = 11;
            this.btnTime.Text = "추가";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // lbNt
            // 
            this.lbNt.AutoSize = true;
            this.lbNt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNt.Location = new System.Drawing.Point(4, 365);
            this.lbNt.Name = "lbNt";
            this.lbNt.Size = new System.Drawing.Size(34, 12);
            this.lbNt.TabIndex = 12;
            this.lbNt.Text = "Time";
            this.lbNt.UseMnemonic = false;
            // 
            // SenderTB
            // 
            this.SenderTB.BackColor = System.Drawing.SystemColors.Window;
            this.SenderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SenderTB.ForeColor = System.Drawing.Color.DarkGray;
            this.SenderTB.Location = new System.Drawing.Point(6, 604);
            this.SenderTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SenderTB.Name = "SenderTB";
            this.SenderTB.Size = new System.Drawing.Size(360, 21);
            this.SenderTB.TabIndex = 13;
            this.SenderTB.Text = "LC COMMUNITY";
            this.SenderTB.Enter += new System.EventHandler(this.SenderTB_Enter);
            // 
            // PromotionBTN
            // 
            this.PromotionBTN.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PromotionBTN.ForeColor = System.Drawing.Color.Black;
            this.PromotionBTN.Location = new System.Drawing.Point(372, 604);
            this.PromotionBTN.Name = "PromotionBTN";
            this.PromotionBTN.Size = new System.Drawing.Size(74, 148);
            this.PromotionBTN.TabIndex = 14;
            this.PromotionBTN.Text = "전송";
            this.PromotionBTN.UseVisualStyleBackColor = true;
            this.PromotionBTN.Click += new System.EventHandler(this.PromotionBTN_Click);
            // 
            // RemoveTimeBTN
            // 
            this.RemoveTimeBTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RemoveTimeBTN.Location = new System.Drawing.Point(372, 511);
            this.RemoveTimeBTN.Name = "RemoveTimeBTN";
            this.RemoveTimeBTN.Size = new System.Drawing.Size(74, 64);
            this.RemoveTimeBTN.TabIndex = 17;
            this.RemoveTimeBTN.Text = "선택\r\n삭제\r\n";
            this.RemoveTimeBTN.UseVisualStyleBackColor = true;
            this.RemoveTimeBTN.Click += new System.EventHandler(this.RemoveTimeBTN_Click);
            // 
            // ClearTimeBTN
            // 
            this.ClearTimeBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearTimeBTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearTimeBTN.Location = new System.Drawing.Point(372, 467);
            this.ClearTimeBTN.Name = "ClearTimeBTN";
            this.ClearTimeBTN.Size = new System.Drawing.Size(74, 38);
            this.ClearTimeBTN.TabIndex = 19;
            this.ClearTimeBTN.Text = "초기화";
            this.ClearTimeBTN.UseVisualStyleBackColor = true;
            this.ClearTimeBTN.Click += new System.EventHandler(this.ClearTimeBTN_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath.Location = new System.Drawing.Point(6, 35);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(360, 21);
            this.txtPath.TabIndex = 22;
            this.txtPath.Text = "G:\\디스코드 서버\\웹훅.txt";
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPath.Location = new System.Drawing.Point(372, 32);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(74, 28);
            this.btnPath.TabIndex = 23;
            this.btnPath.Text = "검색";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "웹훅 불러오기 경로지정";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // timePath
            // 
            this.timePath.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timePath.Location = new System.Drawing.Point(5, 335);
            this.timePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePath.Name = "timePath";
            this.timePath.Size = new System.Drawing.Size(361, 21);
            this.timePath.TabIndex = 27;
            // 
            // btntimePath
            // 
            this.btntimePath.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btntimePath.Location = new System.Drawing.Point(372, 336);
            this.btntimePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimePath.Name = "btntimePath";
            this.btntimePath.Size = new System.Drawing.Size(74, 21);
            this.btntimePath.TabIndex = 28;
            this.btntimePath.Text = "검색";
            this.btntimePath.UseVisualStyleBackColor = true;
            this.btntimePath.Click += new System.EventHandler(this.btntimePath_Click);
            // 
            // savetimeBTN
            // 
            this.savetimeBTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.savetimeBTN.Location = new System.Drawing.Point(372, 423);
            this.savetimeBTN.Name = "savetimeBTN";
            this.savetimeBTN.Size = new System.Drawing.Size(74, 38);
            this.savetimeBTN.TabIndex = 29;
            this.savetimeBTN.Text = "저장";
            this.savetimeBTN.UseVisualStyleBackColor = true;
            this.savetimeBTN.Click += new System.EventHandler(this.savetimeBTN_Click);
            // 
            // loadtimeBTN
            // 
            this.loadtimeBTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadtimeBTN.Location = new System.Drawing.Point(372, 379);
            this.loadtimeBTN.Name = "loadtimeBTN";
            this.loadtimeBTN.Size = new System.Drawing.Size(74, 38);
            this.loadtimeBTN.TabIndex = 30;
            this.loadtimeBTN.Text = "불러오기";
            this.loadtimeBTN.UseVisualStyleBackColor = true;
            this.loadtimeBTN.Click += new System.EventHandler(this.loadtimeBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(4, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "시간 불러오기 경로지정";
            // 
            // ContenTB
            // 
            this.ContenTB.Location = new System.Drawing.Point(5, 629);
            this.ContenTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContenTB.Name = "ContenTB";
            this.ContenTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.ContenTB.Size = new System.Drawing.Size(361, 124);
            this.ContenTB.TabIndex = 32;
            this.ContenTB.Text = resources.GetString("ContenTB.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveTimeBTN);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.PromotionBTN);
            this.groupBox1.Controls.Add(this.SenderTB);
            this.groupBox1.Controls.Add(this.TimeListBox);
            this.groupBox1.Controls.Add(this.ContenTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.tbxTime);
            this.groupBox1.Controls.Add(this.loadtimeBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTime);
            this.groupBox1.Controls.Add(this.WebhookListbox);
            this.groupBox1.Controls.Add(this.savetimeBTN);
            this.groupBox1.Controls.Add(this.LOADWebhookBTN);
            this.groupBox1.Controls.Add(this.lbNt);
            this.groupBox1.Controls.Add(this.SaveBTN);
            this.groupBox1.Controls.Add(this.btntimePath);
            this.groupBox1.Controls.Add(this.PluusWebhookBTN);
            this.groupBox1.Controls.Add(this.ClearTimeBTN);
            this.groupBox1.Controls.Add(this.WebhookTB);
            this.groupBox1.Controls.Add(this.timePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 759);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "자동배너기 - 일반";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.listTime);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(478, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(453, 365);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "자동배너기 - 하프커뮤니티";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(372, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 149);
            this.button3.TabIndex = 42;
            this.button3.Text = "전송";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(6, 208);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 21);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "LC COMMUNITY";
            // 
            // listTime
            // 
            this.listTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listTime.ForeColor = System.Drawing.Color.Black;
            this.listTime.FormattingEnabled = true;
            this.listTime.ItemHeight = 12;
            this.listTime.Items.AddRange(new object[] {
            "오전 1:00:00",
            "오전 2:00:00",
            "오전 9:00:00",
            "오전 10:00:00",
            "오전 11:00:00",
            "오후 1:00:00",
            "오후 2:00:00",
            "오후 4:00:00",
            "오후 6:00:00",
            "오후 8:00:00",
            "오후 10:00:00",
            "오후 11:00:00"});
            this.listTime.Location = new System.Drawing.Point(6, 32);
            this.listTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTime.Name = "listTime";
            this.listTime.Size = new System.Drawing.Size(360, 148);
            this.listTime.TabIndex = 38;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 233);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(360, 124);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(6, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 18);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "오후 1:30:00";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(372, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 18);
            this.button5.TabIndex = 40;
            this.button5.Text = "추가";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(6, 18);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(34, 12);
            this.lbTime.TabIndex = 33;
            this.lbTime.Text = "Time";
            this.lbTime.UseMnemonic = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(478, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 387);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "상태메세지 변경기";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(372, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 148);
            this.button1.TabIndex = 43;
            this.button1.Text = "선택\r\n삭제\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 21);
            this.textBox2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "로그인";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 54;
            this.label4.Text = "토큰";
            this.label4.UseMnemonic = false;
            // 
            // BSForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 845);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BSForm1";
            this.Padding = new System.Windows.Forms.Padding(18, 48, 18, 16);
            this.Text = "디스코드 관리툴 (LC 맞춤형)";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox WebhookListbox;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button LOADWebhookBTN;
        private System.Windows.Forms.Button PluusWebhookBTN;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.ListBox TimeListBox;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label lbNt;
        private System.Windows.Forms.TextBox SenderTB;
        private System.Windows.Forms.Button PromotionBTN;
        private bool oneSend = true;
        private List<string> Urls = new List<string>();
        private System.Windows.Forms.Button RemoveTimeBTN;
        private System.Windows.Forms.Button ClearTimeBTN;
        private System.Windows.Forms.TextBox WebhookTB;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox timePath;
        private System.Windows.Forms.Button btntimePath;
        private System.Windows.Forms.Button savetimeBTN;
        private System.Windows.Forms.Button loadtimeBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ContenTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listTime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

