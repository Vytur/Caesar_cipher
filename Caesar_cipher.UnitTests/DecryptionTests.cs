using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caesar_cipher.UnitTests
{
    [TestClass]
    public class DecryptionTests
    {
        [TestMethod]
        public void Decryption_WithOneWord_CorrectEncryption()
        {
            string PlainText = "effe";
            int key = 4;
            string expected = "abba";
            var actual = Program.Decryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Decryption_WithManyWords_CorrectEncryptionWithSpaces()
        {
            string PlainText = "kllk sc k wecsm lkxn";
            int key = 10;
            string expected = "abba is a music band";
            var actual = Program.Decryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Decryption_WithBigKey_CorrectEncryption()
        {
            string PlainText = "ghhg luxskj ot 1972";
            int key = 1410;
            string expected = "abba formed in 1972";
            var actual = Program.Decryption(PlainText, key);
            Assert.AreEqual(expected, actual);
        }
    }
}
