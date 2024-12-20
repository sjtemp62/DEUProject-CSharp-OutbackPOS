﻿namespace DEUProject_CSharp_OutbackPOS.View
{
    partial class PosMainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserInform = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTableManage = new System.Windows.Forms.Button();
            this.btnReceiptManage = new System.Windows.Forms.Button();
            this.btnMenuManage = new System.Windows.Forms.Button();
            this.tableLayoutMenuPanel = new DEUProject_CSharp_OutbackPOS.CustomControl.DoubleBufferedPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.55212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.44788F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutMenuPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.786364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.21364F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUserInform, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(277, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1620, 79);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(437, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "판매관리 - 주문관리(영업)";
            // 
            // txtUserInform
            // 
            this.txtUserInform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUserInform.AutoSize = true;
            this.txtUserInform.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserInform.ForeColor = System.Drawing.Color.White;
            this.txtUserInform.Location = new System.Drawing.Point(1418, 2);
            this.txtUserInform.Margin = new System.Windows.Forms.Padding(4, 0, 71, 0);
            this.txtUserInform.Name = "txtUserInform";
            this.txtUserInform.Size = new System.Drawing.Size(131, 75);
            this.txtUserInform.TabIndex = 1;
            this.txtUserInform.Text = "사용자 ID: -\r\n사용자 이름 : -\r\n직책 : -";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(275, 79);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "지점정보\r\n서면점\r\n";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnTableManage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuManage, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnReceiptManage, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 81);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(275, 942);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnTableManage
            // 
            this.btnTableManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTableManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnTableManage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTableManage.ForeColor = System.Drawing.Color.Black;
            this.btnTableManage.Location = new System.Drawing.Point(37, 43);
            this.btnTableManage.Margin = new System.Windows.Forms.Padding(0);
            this.btnTableManage.Name = "btnTableManage";
            this.btnTableManage.Size = new System.Drawing.Size(200, 150);
            this.btnTableManage.TabIndex = 4;
            this.btnTableManage.Text = "테이블 관리";
            this.btnTableManage.UseVisualStyleBackColor = false;
            this.btnTableManage.Click += new System.EventHandler(this.btnTableManage_Click);
            // 
            // btnReceiptManage
            // 
            this.btnReceiptManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceiptManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnReceiptManage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReceiptManage.ForeColor = System.Drawing.Color.Black;
            this.btnReceiptManage.Location = new System.Drawing.Point(37, 511);
            this.btnReceiptManage.Margin = new System.Windows.Forms.Padding(0);
            this.btnReceiptManage.Name = "btnReceiptManage";
            this.btnReceiptManage.Size = new System.Drawing.Size(200, 150);
            this.btnReceiptManage.TabIndex = 7;
            this.btnReceiptManage.Text = "영수증 관리";
            this.btnReceiptManage.UseVisualStyleBackColor = false;
            this.btnReceiptManage.Click += new System.EventHandler(this.btnReceiptManage_Click);
            // 
            // btnMenuManage
            // 
            this.btnMenuManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnMenuManage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenuManage.ForeColor = System.Drawing.Color.Black;
            this.btnMenuManage.Location = new System.Drawing.Point(37, 277);
            this.btnMenuManage.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuManage.Name = "btnMenuManage";
            this.btnMenuManage.Size = new System.Drawing.Size(200, 150);
            this.btnMenuManage.TabIndex = 5;
            this.btnMenuManage.Text = "메뉴(재고) 관리";
            this.btnMenuManage.UseVisualStyleBackColor = false;
            this.btnMenuManage.Click += new System.EventHandler(this.btnMenuManage_Click);
            // 
            // tableLayoutMenuPanel
            // 
            this.tableLayoutMenuPanel.BackgroundImage = global::DEUProject_CSharp_OutbackPOS.Properties.Resources._2145;
            this.tableLayoutMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMenuPanel.Location = new System.Drawing.Point(277, 81);
            this.tableLayoutMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMenuPanel.Name = "tableLayoutMenuPanel";
            this.tableLayoutMenuPanel.Size = new System.Drawing.Size(1620, 942);
            this.tableLayoutMenuPanel.TabIndex = 7;
            // 
            // PosMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PosMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "아웃백스테이크하우스 POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtUserInform;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnTableManage;
        private System.Windows.Forms.Button btnReceiptManage;
        private System.Windows.Forms.Button btnMenuManage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControl.DoubleBufferedPanel tableLayoutMenuPanel;
    }
}