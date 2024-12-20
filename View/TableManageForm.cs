﻿using DEUProject_CSharp_OutbackPOS.Controller;
using DEUProject_CSharp_OutbackPOS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using DEUProject_CSharp_OutbackPOS.CustomControl;

namespace DEUProject_CSharp_OutbackPOS.View
{
    public partial class TableManageForm : Form
    {
        private readonly TableController tableController;
        private PosMainForm refreshingForm;
        private CustomTablePanel selectedTablePanel;
        private Point movingOffset;

        public TableManageForm(PosMainForm refreshingForm)
        {
            InitializeComponent();
            this.refreshingForm = refreshingForm;
            tableController = new TableController(tableLayoutPanel);
            LoadTables();
        }

        private void LoadTables()
        {
            tableController.LoadTables(panel =>
            {   // 이벤트 연결
                panel.MouseDown += TablePanel_MouseDown;
                panel.MouseMove += TablePanel_MouseMove;
                panel.MouseClick += TablePanel_MouseClick;
                // 패널 추가
                tableLayoutPanel.Controls.Add(panel);
            });
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            // 새 테이블 추가
            CustomTablePanel panel = tableController.CreateTablePanel(
                "테이블 - " + (tableLayoutPanel.Controls.Count + 1),
                new Point(tableLayoutPanel.Width / 2, tableLayoutPanel.Height / 2),
                new Size(200, 200),
                Color.Black, // 기본 테두리 색상
                3          // 기본 테두리 두께
            );

            // 이벤트 연결
            panel.MouseDown += TablePanel_MouseDown;
            panel.MouseMove += TablePanel_MouseMove;
            panel.MouseClick += TablePanel_MouseClick;

            // 패널 추가
            tableLayoutPanel.Controls.Add(panel);
        }

        private void btnTableLayoutSave_Click(object sender, EventArgs e)
        {
            // 테이블 저장
            tableController.SaveTablesLayout();

            DialogResult result = MessageBox.Show(
                "테이블 저장에 성공했습니다! 테이블 관리창을 닫으시겠습니까?",
                "테이블 관리창 종료",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                refreshingForm.LoadTables();
                this.Close();
            }
            refreshingForm.LoadTables();
        }

        private void btnTableRemove_Click(object sender, EventArgs e)
        {
            if (selectedTablePanel != null)
            {
                tableController.RemoveTable(selectedTablePanel);
            }
        }

        private void btnTableBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && selectedTablePanel != null)
            {
                // 선택한 컬러 적용
                selectedTablePanel.BorderColor = colorDialog1.Color;
                selectedTablePanel.Invalidate();
            }
        }

        private void TablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            selectedTablePanel = (CustomTablePanel)sender;
            movingOffset = new Point(e.X, e.Y);
        }

        private void TablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedTablePanel != null)
            {
                // 마우스 현재 위치에서 오프셋만큼 뺀 위치로 패널 이동
                selectedTablePanel.Left = e.X + selectedTablePanel.Left - movingOffset.X;
                selectedTablePanel.Top = e.Y + selectedTablePanel.Top - movingOffset.Y;
            }
        }

        private void TablePanel_MouseClick(object sender, MouseEventArgs e)
        {
            selectedTablePanel = (CustomTablePanel)sender;
            if (selectedTablePanel.Tag is Table table)
            {
                txtBoxTableName.Text = table.Name;
            }
            else
            {
                txtBoxTableName.Text = selectedTablePanel.Name;
            }
        }

        private void txtBoxTableName_TextChanged_1(object sender, EventArgs e)
        {
            if (selectedTablePanel != null)
            {
                if (selectedTablePanel.Tag is Table table)
                {
                    // 테이블 데이터 업데이트
                    table.Name = txtBoxTableName.Text;
                    tableController.UpdateTable(table);

                    // 패널의 자식 컨트롤 중 Label 검색
                    foreach (Control control in selectedTablePanel.Controls)
                    {
                        if (control is Label label)
                        {
                            label.Text = txtBoxTableName.Text; // 레이블 텍스트 업데이트
                            break; // 첫 번째 Label만 처리하고 종료
                        }
                    }
                }
                else
                {
                    // selectedTablePanel.Tag가 Table이 아닌 경우
                    selectedTablePanel.Name = txtBoxTableName.Text;

                    // 패널의 자식 컨트롤 중 Label 검색
                    foreach (Control control in selectedTablePanel.Controls)
                    {
                        if (control is Label label)
                        {
                            label.Text = txtBoxTableName.Text; // 레이블 텍스트 업데이트
                            break; // 첫 번째 Label만 처리하고 종료
                        }
                    }
                }

                selectedTablePanel.Invalidate(); // 패널 다시 그리기
            }
        }
    }
}