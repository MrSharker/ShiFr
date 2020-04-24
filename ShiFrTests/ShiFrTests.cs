using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShiFrTests
{
    [TestClass]
    public class ShiFrTests
    {

        [TestMethod]
        public void Encrypt_hi()
        {
            // arrange
            string s = "Привет";
            string expected = "бычтфы";
            //act
            ShiFr.Encryption c = new ShiFr.Encryption();
            c.keyword = "скорпион";
            string actual = c.Encrypt(s);
            

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Encrypt_BigText()
        {
            // arrange
            string s = "поздравляю, ты получил исходный текст!!! ";
            string expected = "бщцфаирщри, бл ячъбиуъ щбюэсяёш гфуаа!!! ";
            //act
            ShiFr.Encryption c = new ShiFr.Encryption();
            c.keyword = "скорпион";
            string actual = c.Encrypt(s);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Decrypt_hi()
        {
            // arrange
            string s = "бычтфы32V";
            string expected = "привет32v";
            //act
            ShiFr.Encryption c = new ShiFr.Encryption();
            c.keyword = "скорпион";
            string actual = c.Decrypt(s);


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Decrypt_BigText()
        {
            // arrange
            string s = "бщцфаирщри, бл ячъбиуъ щбюэсяёш гфуаа!!! ";
            string expected = "поздравляю, ты получил исходный текст!!! ";
            //act
            ShiFr.Encryption c = new ShiFr.Encryption();
            c.keyword = "скорпион";
            string actual = c.Decrypt(s);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
