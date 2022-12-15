using OOO_Aromatny_Mir.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Aromatny_Mir
{
    public partial class FormAuthorization : Form
    {
        private String rigthCaptchaText;
        private int secondsOfBlock;
        public FormAuthorization()
        {
            InitializeComponent();
            Helper.ModelDB = new Entities.ModelDB();
            try
            {
                Helper.ModelDB.Database.Connection.Open();
                MessageBox.Show("Успешное подключение к БД",
                    "Статус соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException exception)
            {
                MessageBox.Show($"Не удалось подключиться к БД. Сообщение:\n{exception.Message}",
                    "Статус соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetCaptcha()
        {
            rigthCaptchaText = GenerateCaptcha(4);
            DrawCaptcha(rigthCaptchaText);
        }

        private string GenerateCaptcha(int size)
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string generated = "";
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int gettedSymbols = random.Next(0, symbols.Length - 1);
                generated += symbols[gettedSymbols];
            }
            return generated;
        }

        private void DrawCaptcha(string captcha)
        {
            int fontSize = 18;
            int placeX = 0;
            Random random = new Random();
            Bitmap captchaPlace = new Bitmap(PictureBoxCaptcha.Width, PictureBoxCaptcha.Height);
            Graphics captchaDraw = Graphics.FromImage(captchaPlace);
            captchaDraw.Clear(Color.White);
            captchaDraw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Font captchaFont = new Font("Georgia", fontSize);
            for (int i = 0; i < captcha.Length; i++)
            {
                placeX = random.Next(placeX + fontSize / 2, placeX + fontSize * 2);
                int placeY = random.Next(0, captchaPlace.Height - fontSize * 2);
                captchaDraw.DrawString(captcha[i].ToString(), captchaFont, Brushes.Black, placeX, placeY);
                captchaDraw.DrawLine(Pens.Black, placeX, placeY, random.Next(placeX, captchaPlace.Width), random.Next(placeY, captchaPlace.Height));
            }
            captchaDraw.Flush();
            PictureBoxCaptcha.Image = captchaPlace;
        }

        private void ButtonAuthExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (rigthCaptchaText != null && rigthCaptchaText != TextBoxCaptcha.Text)
            {
                ButtonLogin.Enabled = false;
                ButtonGuestLogin.Enabled = false;
                TimerCaptha.Start();
                MessageBox.Show("Повторите попытку через 10 секунд", "Ввод капчи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль для авторизации",
                    "Неуспешная авторизация",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetCaptcha();
                return;
            }
            Helper.CurrentUser = Helper.ModelDB.User.Where(u => 
            u.UserLogin == login && u.UserPassword == password).FirstOrDefault();
            if (Helper.CurrentUser is null)
            {
                MessageBox.Show("Пользователь не найден",
                    "Неуспешная авторизация",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetCaptcha();
                return;
            }
            var userRole = Helper.ModelDB.Role.Where(r =>
            r.RoleID == Helper.CurrentUser.UserRole).FirstOrDefault();
            Helper.SetRole(userRole.RoleName);
            ToCatalogue();
        }

        private void ToCatalogue()
        {
            FormCatalogue formCatalogue = new FormCatalogue();
            this.Hide();
            formCatalogue.ShowDialog();
            TextBoxLogin.Text = "";
            TextBoxPassword.Text = "";
            this.Show();
        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Helper.ModelDB.Database.Connection.Close();
                MessageBox.Show("Успешное отключение от БД",
                    "Статус соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException exception)
            {
                MessageBox.Show($"Не удалось отключиться от БД. Сообщение:\n{exception.Message}",
                    "Статус соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void ButtonGuestLogin_Click(object sender, EventArgs e)
        {
            if (rigthCaptchaText != null && rigthCaptchaText != TextBoxCaptcha.Text)
            {
                ButtonLogin.Enabled = false;
                ButtonGuestLogin.Enabled = false;
                TimerCaptha.Start();
                MessageBox.Show("Повторите попытку через 10 секунд", "Ввод капчи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Helper.CurrentUser = null;
            ToCatalogue();
        }

        private void TimerCaptha_Tick(object sender, EventArgs e)
        {
            
            secondsOfBlock++;
            if (secondsOfBlock == 10)
            {
                ButtonLogin.Enabled = true;
                ButtonGuestLogin.Enabled = true;
                secondsOfBlock = 0;
                SetCaptcha();
                MessageBox.Show("Повторите ввод капчи", "Ввод капчи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimerCaptha.Stop();

            }
        }
    }
}
