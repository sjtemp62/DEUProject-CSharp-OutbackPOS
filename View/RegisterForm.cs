﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEUProject_CSharp_OutbackPOS.Data;
using DEUProject_CSharp_OutbackPOS.Model;
using DEUProject_CSharp_OutbackPOS.Controller;

namespace DEUProject_CSharp_OutbackPOS.View
{
    public partial class RegisterForm : Form
    {
        AuthController authController = new AuthController();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!txtBoxPW.Text.Equals(txtBoxPWConfirm.Text))
            {
                MessageBox.Show("비밀번호가 같지 않습니다!");
                txtBoxPW.Focus();
                return;
            }

            bool isRegisted = authController.Register(txtBoxId.Text, txtBoxPW.Text, txtBoxUserName.Text, txtBoxPosition.Text);
            if (isRegisted)
            {
                MessageBox.Show("회원가입 성공!");
                this.Close();
            }
            else
            {
                MessageBox.Show("회원가입 실패!");
            }
        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick(); // 버튼 클릭
            }
        }
    }
}
