using System.IO;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.LinkLabel;
using System;

namespace scaMarketPlays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HidePanels(false);
        }

        private void HidePanels(bool enabled)
        {
            userLogin.Visible = enabled;
            userLogin.Enabled = enabled;
            userPassword.Visible = enabled;
            userPassword.Enabled = enabled;
            loginSaleman.Visible = enabled;
            loginSaleman.Enabled = enabled;
            passwordSaleman.Visible = enabled;
            passwordSaleman.Enabled = enabled;
            login.Visible = enabled;
            password.Visible = enabled;
        }

        private void SelectHide(bool enabled)
        {
            userLogin.Visible = enabled;
            userLogin.Enabled = enabled;
            userPassword.Visible = enabled;
            userPassword.Enabled = enabled;
            loginSaleman.Visible = !enabled;
            loginSaleman.Enabled = !enabled;
            passwordSaleman.Visible = !enabled;
            passwordSaleman.Enabled = !enabled;
        }

        private void userSelect_CheckedChanged(object sender, System.EventArgs e)
        {
            login.Visible = true;
            password.Visible = true;
            SelectHide(true);
        }

        private void selectSaleman_CheckedChanged(object sender, System.EventArgs e)
        {
            login.Visible = true;
            password.Visible = true;
            SelectHide(false);
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            if (selectSaleman.Checked)
            {
                if (passwordSaleman.Text != "" && loginSaleman.Text != "")
                {
                    string[] fileText = File.ReadAllLines("Saleman Data.txt");
                    int index = Array.FindIndex(fileText, str => str.Contains(loginSaleman.Text));

                    if (index != -1)
                    {
                        string stroke = File.ReadAllLines("Saleman Data.txt")[index];
                        string[] info = stroke.Split(':');

                        if (passwordSaleman.Text == info[1])
                        {
                            MessageBox.Show("Авторизация прошла успешно");
                        } else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Продавец не найдет");
                    }
                }else
                {
                    MessageBox.Show("Обнаружены пустые поля");
                }
            }
            else
            {
                if (userLogin.Text != "" && userPassword.Text != "")
                {
                    string[] fileText = File.ReadAllLines("User Data.txt");
                    int index = Array.FindIndex(fileText, str => str.Contains(userLogin.Text));

                    if (index != -1)
                    {
                        string stroke = File.ReadAllLines("User Data.txt")[index];
                        string[] info = stroke.Split(':');

                        if (userPassword.Text == info[1])
                        {
                            MessageBox.Show("Авторизация прошла успешно");
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Покупатель не найдет");
                    }
                }
                else
                {
                    MessageBox.Show("Обнаружены пустые поля");
                }
            }
        }

        private void registrationButton_Click(object sender, System.EventArgs e)
        {
            if (selectSaleman.Checked)
            {
                if (passwordSaleman.Text != "" && loginSaleman.Text != "")
                {
                    string[] fileText = File.ReadAllLines("Saleman Data.txt");
                    int index = Array.FindIndex(fileText, str => str.Contains(loginSaleman.Text));

                    if (index == -1)
                    {
                        using (StreamWriter wr = File.AppendText("Saleman Data.txt"))
                        {
                            wr.WriteLine($"{loginSaleman.Text}:{passwordSaleman.Text}");
                        }

                        MessageBox.Show("Регистрация успешна");
                    }
                    else
                    {
                        MessageBox.Show("Продавец уже существует");
                    }
                }
            }
            else
            {
                if (userLogin.Text != "" && userPassword.Text != "")
                {
                    string[] fileText = File.ReadAllLines("User Data.txt");
                    int index = Array.FindIndex(fileText, str => str.Contains(userLogin.Text));

                    if (index == -1)
                    {
                        using (StreamWriter wr = File.AppendText("Saleman Data.txt"))
                        {
                            wr.WriteLine($"{loginSaleman.Text}:{passwordSaleman.Text}");
                        }

                        MessageBox.Show("Регистрация успешна");
                    }
                    else
                    {
                        MessageBox.Show("Продавец уже существует");
                    }
                }
            }
        }
    }
}
