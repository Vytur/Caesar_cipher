using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caesar_cipher.UnitTests
{
    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void Encryption_WithOneWord_CorrectEncryption()
        {
            string PlainText = "abba";
            int key = 4;
            string expected = "effe";
            var actual = Program.Encryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Encryption_WithManyWords_CorrectEncryptionWithSpaces()
        {
            string PlainText = "abba is a music band";
            int key = 10;
            string expected = "kllk sc k wecsm lkxn";
            var actual = Program.Encryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Encryption_WithBigKey_CorrectEncryption()
        {
            string PlainText = "abba formed in 1972";
            int key = 1410;
            string expected = "ghhg luxskj ot 1972";
            var actual = Program.Encryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }
    }
}
