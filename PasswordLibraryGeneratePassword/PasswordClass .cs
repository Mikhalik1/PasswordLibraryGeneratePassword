using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibraryGeneratePassword
{
    public class PasswordClass
    {
        /// <summary>
        /// Метод генерации пароля
        /// </summary>
        /// <returns>
        /// Возврашает пароль
        /// </returns>
        public string GeneratePassword()
        {
            string letter = "abcdefghijklmnopqrstuvwxyz";
            string upletter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string number = "1234567890";
            string simbol = "?!.,#$%&*@()<>;:";
            Random rnd = new Random();
            string password = "";
            int choise;

            int kol  = rnd.Next(8,15);
            for (int i = 0; i < kol; i++)
            {
                choise = rnd.Next(1,5);

                switch (choise)
                {
                    case 1: 

                        int let = rnd.Next(1,letter.Length);
                        password += letter[let]; 
                        break;
                    case 2:

                        int up = rnd.Next(1, upletter.Length);
                        password += upletter[up];
                        break;

                    case 3:

                        int num = rnd.Next(1, number.Length);
                        password += number[num];
                        break;

                    case 4:

                        int sim = rnd.Next(1, simbol.Length);
                        password += simbol[sim];
                        break;
                }
            }  
            return password;

        }

        /// <summary>
        /// Входным значение является строка, полученная в с помощью метода GeneratePassword 
        /// </summary>
        /// <param name="password"></param>
        /// <returns>
        /// True - если строка удовлетворяет условиям: 
        /// строка имеет правильную длину; 
        /// содержать цифры; 
        /// содержит латинские буквы в нижнем регистре; 
        /// содержит латинские буквы в верхнем регистре; 
        /// содержит латинские буквы в верхнем регистре; 
        /// содержит спец.символы; 
        /// не содержит кириллические символы; 
        /// </returns>
        /// <exception cref="Exception">не верный пароль</exception>
        public bool CheckPassword(string password)
        {

            string regex = @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\?|!|\.|,|#|\$|%|&|\*|@|\(|\)|\<|\>\;\:]).{8,15}$)"; //регулярное выражение
            if (!string.IsNullOrEmpty(password)) //проверка того, что строка не пуста
            {
                if (Regex.Match(password, "[а-яА-Я]").Success) //проверка на наличие кирилицы в пароле, выдаёт ошибку
                {
                    throw new Exception("Кириллические символы запрещены при вводе пароля");
                }
                if (Regex.Match(password,regex, RegexOptions.IgnoreCase).Success)//сравнение пароля с  регулярным выражением
                {
                    return true;
                }
                throw new Exception("некоректный пароль");
            }
            else
            {
                throw new Exception("ведена пустота");
            }
            
        }


    }
}
