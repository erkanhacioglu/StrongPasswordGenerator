using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            // Kullanıcıdan hangi karakter türlerini dahil etmek istediğini alıyoruz
            bool includeUpperCase = cbUpperCase.Checked;
            bool includeLowerCase = cbLowercase.Checked;
            bool includeDigits = cbDigits.Checked;
            bool includeSpecialChars = cbSpecialChars.Checked;

            txtPassword.Text = GenerateStrongPassword(Convert.ToInt32(numPasswordLength.Value), includeUpperCase, includeLowerCase, includeDigits, includeSpecialChars);

        }

        static string GenerateStrongPassword(int length, bool includeUpperCase, bool includeLowerCase, bool includeDigits, bool includeSpecialChars)
        {
            if (length < 4) throw new ArgumentException("Şifre uzunluğu en az 4 karakter olmalıdır.");

            // Karakter kümesini tanımlıyoruz

            string upperCaseChars = includeUpperCase ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "";
            string lowerCaseChars = includeLowerCase ? "abcdefghijklmnopqrstuvwxyz" : "";
            string digits = includeDigits ? "0123456789" : "";
            string specialChars = includeSpecialChars ? "!@#$%^&*()_+[]{}|;:,.<>?" : "";

            // Karakter kümesini birleştiriyoruz
            string allChars = upperCaseChars + lowerCaseChars + digits + specialChars;

            // En az bir karakter türü eklenmiş olmalıdır
            if (string.IsNullOrEmpty(allChars)) throw new ArgumentException("En az bir karakter türü seçilmelidir.");

            // Şifreyi oluşturmaya başlıyoruz
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // Her tür karakterden en az bir tane ekliyoruz
            if (includeUpperCase) password.Append(upperCaseChars[random.Next(upperCaseChars.Length)]);
            if (includeLowerCase) password.Append(lowerCaseChars[random.Next(lowerCaseChars.Length)]);
            if (includeDigits) password.Append(digits[random.Next(digits.Length)]);
            if (includeSpecialChars) password.Append(specialChars[random.Next(specialChars.Length)]);

            // Kalan karakterleri rastgele seçiyoruz
            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Şifreyi karıştırıyoruz
            return new string(password.ToString().OrderBy(c => random.Next()).ToArray());
        }
    }
}
