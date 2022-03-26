﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;
using System.Collections.Generic;

//using MetroFramework.Forms;
//MetroForm

namespace BSWebhookSender
{
    public partial class BSForm1 : MetroFramework.Forms.MetroForm 
    {
        public BSForm1()
        {
            InitializeComponent();
            tmr.Start();
        }

        //웹훅 추가 버튼
        private void PluusWebhookBTN_Click(object sender, EventArgs e)
        { 
            if (WebhookTB.Text == null)
            {
                MessageBox.Show("웹훅을 입력해주세요!");
                return;
            }
            Urls.Add(WebhookTB.Text);
            WebhookListbox.Items.Clear();
            foreach (string item in Urls)
            {
                WebhookListbox.Items.Add(item);
            }
            WebhookTB.Clear();
        }

        //시간표시
        private void tmr_Tick(object sender, EventArgs e)
        {
            string text = DateTime.Now.ToString().Split(new char[]
            {
                ' '
            })[1] + " " + DateTime.Now.ToString().Split(new char[]
            {
                ' '
            })[2];
            lbNt.Text = text;
            lbTime.Text = text;
            for (int i = 0; i < listTime.Items.Count; i++)
            {
                if (listTime.Items[i].ToString() == text)
                {
                    PromotionBTN_Click(sender, e);
                    tmr.Enabled = false;
                    return;
                }
            }
            for (int i = 0; i < TimeListBox.Items.Count; i++)
            {
                if (TimeListBox.Items[i].ToString() == text)
                {
                    PromotionBTN_Click(sender, e);
                    tmr.Enabled = false;
                    return;
                }
            }
        }

        //시간 추가 버튼
        private void btnTime_Click(object sender, EventArgs e)
        {
            if (tbxTime.Text.Length != 0)
            {
                TimeListBox.Items.Add(tbxTime.Text);
            }
            tbxTime.Clear();
        }

        //딜레이
        private void Delay_Tick(object sender, EventArgs e)
        {
            oneSend = true;
            tmr.Enabled = true;
            Delay.Enabled = false;
        }

        //전송 버튼
        private void PromotionBTN_Click(object sender, EventArgs e)
        {
            if (oneSend)
            {
                Functions.Promotion(Urls, ContenTB.Text, SenderTB.Text);
                oneSend = false;
                Delay.Enabled = true;
            }
        }

        //웹훅 작성란 기존 회색 텍스트 사라지기
        private void WebhookTB_Enter(object sender, EventArgs e)
        {
            if (WebhookTB.Text == "웹훅링크")
                WebhookTB.Text = null;
            WebhookTB.ForeColor = Color.Black;
        }

        //시간 작성란 기존 회색 텍스트 사라지기
        private void tbxTime_Enter(object sender, EventArgs e)
        {
            if (tbxTime.Text == "예) 오후 4:20:31")
                tbxTime.Text = null;
            tbxTime.ForeColor = Color.Black;
        }

        //웹훅이름 작성란 기존 회색 텍스트 사라지기
        private void SenderTB_Enter(object sender, EventArgs e)
        {
            if (SenderTB.Text == "웹훅 이름")
                SenderTB.Text = null;
            SenderTB.ForeColor = Color.Black;
         }

        private readonly object 봉순4888;

        //웹훅 리스트 선택 삭제
        private void RemoveItemBTN_Click(object sender, EventArgs e)
        {
            WebhookListbox.Items.Remove(WebhookListbox.SelectedItem);
        }

        //시간 리스트 선택 삭제
        private void RemoveTimeBTN_Click(object sender, EventArgs e)
        {
            TimeListBox.Items.Remove(TimeListBox.SelectedItem);
        }

        //웹훅 리스트 초기화
        private void ClearWebhookBTN_Click(object sender, EventArgs e)
        {
            WebhookListbox.Items.Clear();
        }

        //시간 리스트 초기화
        private void ClearTimeBTN_Click(object sender, EventArgs e)
        {
            TimeListBox.Items.Clear();
        }

        //웹훅 리스트 저장
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i < WebhookListbox.Items.Count; i++)
                {
                    writer.WriteLine((string)WebhookListbox.Items[i]);
                }

                writer.Close();
            }

            dlg.Dispose();
        }

        //경로지정
        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if(op.ShowDialog()==DialogResult.OK)
                {
                    txtPath.Text = op.FileName;
                }
            }
            catch { }
        }

        //불러오기
        private void LOADWebhookBTN_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(txtPath.Text.Trim());

                    foreach (string item in lines)
                    {
                        WebhookListbox.Items.Add(item);
                        Urls.Add(item);
                    }
                }
                catch { }
            }
            catch { }
        }

        //시간저장
        private void savetimeBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg2 = new SaveFileDialog();

            if (dlg2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg2.FileName);

                for (int i = 0; i < TimeListBox.Items.Count; i++)
                {
                    writer.WriteLine((string)TimeListBox.Items[i]);
                }

                writer.Close();
            }
        }

        private void btntimePath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op2 = new OpenFileDialog();
                if (op2.ShowDialog() == DialogResult.OK)
                {
                    timePath.Text = op2.FileName;
                }
            }
            catch { }
        }

        //시간불러오기
        private void loadtimeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(timePath.Text.Trim());

                    foreach (string item in lines)
                    {
                        TimeListBox.Items.Add(item);
                    }
                }
                catch { }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listTime.Items.Remove(listTime.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbxTime.Text.Length != 0)
            {
                TimeListBox.Items.Add(tbxTime.Text);
            }
            tbxTime.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oneSend)
            {
                Functions.SendWebhook("https://discord.com/api/webhooks/798122581404155906/EjvL0F-LN9hgnvHrxQTxcAtOHqz7j1S9joryd80xNvmIReFrlmLWux7OYLJKV2op8BXH", richTextBox1.Text, textBox1.Text);
                oneSend = false;
                Delay.Enabled = true;
            }
        }
    }
}

