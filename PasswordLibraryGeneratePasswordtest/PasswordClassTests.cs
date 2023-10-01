using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordLibraryGeneratePassword;
using System;

namespace PasswordLibraryGeneratePasswordtest
{
    [TestClass]
    public class PasswordClassTests
    {
        /// <summary>
        /// проверка на пустоту
        /// </summary>

        [TestMethod]
        public void CheckPassword_empty_returnedexepted()
        {
            //arrange
            string Password = "";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assert
            Assert.ThrowsException<Exception>(actiona);

        }
        /// <summary>
        /// Проверка сгенерированого пароля
        /// </summary>
        [TestMethod]
        public void CheckPassword_GeneratePassword_returnedtrue()
        {
            PasswordClass pc = new PasswordClass();
            string Password = pc.GeneratePassword();
            bool result = pc.CheckPassword(Password);

            Assert.IsTrue(result);

        }

        /// <summary>
        /// проверка пароля без букв в верхнем регистре
        /// </summary>

        [TestMethod]
        public void CheckPassword_notuplatter_returnedexepted()
        {
            //arrange
            string Password = "1dK$";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }
        
        /// <summary>
        /// Проверка на кириллицу
        /// </summary>
        [TestMethod]
        public void CheckPassword_nolatlatter_returnedexepted()
        {
            //arrange
            string Password = "фвывфв";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }


        /// <summary>
        /// Проверка на длинный пароль
        /// </summary>
        [TestMethod]
        public void CheckPassword_LongPaasword_returnedexepted()
        {
            //arrange
            string Password = "123123123123asFFF$*$123";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }


        /// <summary>
        /// проверка пароля в котором буквы только в нижнем регистре
        /// </summary>
        [TestMethod]
        public void CheckPassword_onlylowerletter_returnedexepted()
        {
            //arrange
            string Password = "strokasymb";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }


        /// <summary>
        /// проверка пароля в котором буквы только в верхнем регистре
        /// </summary>
        [TestMethod]
        public void CheckPassword_onlyupletter_returnedexepted()
        {
            //arrange
            string Password = "SDLUTRHHNMH";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }


        /// <summary>
        /// проверка пароля в котором только цифры
        /// </summary>
        [TestMethod]
        public void CheckPassword_onlynumbers_returnedexepted()
        {
            //arrange
            string Password = "12341236401";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assets
            Assert.ThrowsException<Exception>(actiona);

        }



        /// <summary>
        /// проверка пароля в котором только спецсимволы
        /// </summary>
        [TestMethod]
        public void CheckPassword_onlyspecsimvol_returnedexepted()
        {
            //arrange
            string Password = "$$$$$()&*^%@@";
            //act
            PasswordClass pc = new PasswordClass();
            Action actiona = () => pc.CheckPassword(Password);
            //assert
            Assert.ThrowsException<Exception>(actiona);

        }

        /// <summary>
        /// проверка правильного пароля
        /// </summary>
        [TestMethod]
        public void CheckPassword_correctpassword_returnedеtrue()
        {
            //arrange
            string Password = "12HTkk^$@5";
            //act
            PasswordClass pc = new PasswordClass();
            bool result = pc.CheckPassword(Password);
            //assert
            Assert.IsTrue(result);

        }


        /// <summary>
        /// проверка правильного пароля
        /// </summary>
        [TestMethod]
        public void CheckPassword_correctpassword2_returnedеtrue()
        {
            //arrange
            string Password = "abVGH$@5";
            //act
            PasswordClass pc = new PasswordClass();
            bool result = pc.CheckPassword(Password);
            //assert
            Assert.IsTrue(result);

        }



        /// <summary>
        /// проверка правильного пароля
        /// </summary>
        [TestMethod]
        public void CheckPassword_correctpassword3_returnedеtrue()
        {
            //arrange
            string Password = "abVGH$@5abVGH$@";
            //act
            PasswordClass pc = new PasswordClass();
            bool result = pc.CheckPassword(Password);
            //assert
            Assert.IsTrue(result);

        }

    }
}
