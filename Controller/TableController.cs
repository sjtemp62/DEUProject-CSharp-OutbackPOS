﻿using DEUProject_CSharp_OutbackPOS.CustomControl;
using DEUProject_CSharp_OutbackPOS.Data;
using DEUProject_CSharp_OutbackPOS.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEUProject_CSharp_OutbackPOS.Controller
{
    public class TableController
    {
        private readonly TableRepository tableRepository;
        private readonly OrderRepository orderRepository;
        private readonly DoubleBufferedPanel tableLayoutPanel;

        public TableController()
        {
            tableRepository = new TableRepository();
            orderRepository = new OrderRepository(); // OrderRepository 추가
            tableLayoutPanel = new DoubleBufferedPanel();
        }

        public TableController(TableRepository repository, DoubleBufferedPanel layoutPanel)
        {
            tableRepository = repository;
            orderRepository = new OrderRepository(); // OrderRepository 추가
            tableLayoutPanel = layoutPanel;
        }

        // 테이블 패널 생성
        public CustomTablePanel CreateTablePanel(string name, Point location, Size size, Color borderColor, int borderThickness)
        {
            CustomTablePanel tablePanel = new CustomTablePanel
            {
                Name = name,
                Location = location,
                Size = size,
                BorderColor = borderColor,
                BorderThickness = borderThickness,
                BackColor = Color.White
            };

            // 레이블 추가
            Label tableNameLabel = new Label
            {
                Text = name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent, // 투명 배경 설정
                Font = new Font("맑은 고딕", 12, FontStyle.Bold), // 폰트 설정
            };

            // 레이블 이벤트 연결
            tableNameLabel.MouseDown += (sender, e) => tablePanel.HandleMouseDown(e);
            tableNameLabel.MouseMove += (sender, e) => tablePanel.HandleMouseMove(e);
            tableNameLabel.MouseUp += (sender, e) => tablePanel.HandleMouseUp(e);

            // 레이블 패널에 추가
            tablePanel.Controls.Add(tableNameLabel);

            return tablePanel;
        }

        // 테이블 데이터 저장
        public void SaveTables()
        {
            tableRepository.ClearAllTables();
            foreach (CustomTablePanel panel in tableLayoutPanel.Controls)
            {
                Table table = new Table(panel.Name, panel.Location.X, panel.Location.Y, panel.Width, panel.Height, panel.BorderColor);
                tableRepository.AddTable(table);
            }
        }

        public void LoadTables(Action<CustomTablePanel> addPanelAction)
        {
            List<Table> tables = tableRepository.GetAllTables();

            foreach (Table table in tables)
            {
                // 패널 생성
                CustomTablePanel panel = CreateTablePanel(
                    table.Name,
                    new Point(table.X, table.Y),
                    new Size(table.Width, table.Height),
                    table.GetBorderColor(),
                    3
                );

                panel.Tag = table;

                // 미결제 주문 정보 가져오기
                var unpaidOrders = orderRepository.GetUnpaidOrdersByTableId(table.Id);

                if (unpaidOrders.Any())
                {
                    // 미결제 주문 데이터를 가공하여 레이블 텍스트로 변환
                    StringBuilder labelText = new StringBuilder();
                    foreach (var order in unpaidOrders)
                    {
                        foreach (var orderItem in order.outbackOrderItem)
                        {
                            labelText.AppendLine($"{orderItem.MenuName} x {orderItem.Quantity}");
                        }
                    }

                    // 레이블 텍스트 업데이트
                    panel.Controls[0].Text = labelText.ToString();
                }
                else
                {
                    panel.Controls[0].Text = table.Name; // 기본 테이블 이름 표시
                }

                addPanelAction(panel);
            }
        }

        // 테이블 삭제
        public void RemoveTable(CustomTablePanel panel)
        {
            tableLayoutPanel.Controls.Remove(panel);
        }

        public void UpdateTable(Table table)
        {
            tableRepository.UpdateTable(table);
        }
    }
}
