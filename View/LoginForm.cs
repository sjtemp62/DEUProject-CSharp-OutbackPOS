﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEUProject_CSharp_OutbackPOS.Model;
using DEUProject_CSharp_OutbackPOS;
using System.Reflection.Emit;
using DEUProject_CSharp_OutbackPOS.Controller;

namespace DEUProject_CSharp_OutbackPOS.View
{
    public partial class LoginForm : Form
    {
        AuthController authSystem = new AuthController();

        public LoginForm()
        {
            InitializeComponent();
        }

        //로그인 버튼 누를 시 컨트롤러 전달
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User loggedInUser = authSystem.Login(txtBoxId.Text, txtBoxPW.Text);
            if (loggedInUser != null)
            {
                PosMainForm pos = new PosMainForm(loggedInUser);
                this.Hide();
                pos.FormClosed += (s, args) => this.Close();
                pos.Show();
            }
            else
            {
                txtLoginResult.Text = "로그인 실패!";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
