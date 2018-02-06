using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartRandomAlphanumericGenerator;

namespace Test
{
    [TestClass]
    public class SRAGeneratorTest
    {
        private int _size = 6;

        [TestMethod]
        public void Test_SRAGenerator_Generate_Length_Bigger()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();

            if (sRAGenerator.Generate(_size).Length > _size)
            {
                Assert.Fail("O gerador está gerando sequencias maiores do que as desejadas.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Length_Smaller()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();

            if (sRAGenerator.Generate(_size).Length < _size)
            {
                Assert.Fail("O gerador está gerando sequencias menores do que as desejadas.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Repeat()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();
            string first = sRAGenerator.Generate(_size);
            string second = sRAGenerator.Generate(_size);

            if (first == second)
            {
                Assert.Fail("O gerador está gerando sequencias iguais.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Just_Numbers()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();
            sRAGenerator.UseLowercaseLetters = false;
            sRAGenerator.UseUppercaseLetters = false;
            sRAGenerator.UseSymbols = false;
            sRAGenerator.UseNumbers = true;

            var s = sRAGenerator.Generate(sRAGenerator.Numbers.Length).ToList();
            var r = sRAGenerator.Numbers.ToList();

            if (s.Except(r).ToList().Count > 0)
            {
                Assert.Fail("O gerador está gerando sequencias com caracteres diferentes dos pedidos.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Just_LowercaseLetters()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();
            sRAGenerator.UseLowercaseLetters = true;
            sRAGenerator.UseUppercaseLetters = false;
            sRAGenerator.UseSymbols = false;
            sRAGenerator.UseNumbers = false;

            var s = sRAGenerator.Generate(sRAGenerator.Numbers.Length).ToList();
            var r = sRAGenerator.LowercaseLetters.ToList();

            if (s.Except(r).ToList().Count > 0)
            {
                Assert.Fail("O gerador está gerando sequencias com caracteres diferentes dos pedidos.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Just_UppercaseLetters()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();
            sRAGenerator.UseLowercaseLetters = false;
            sRAGenerator.UseUppercaseLetters = true;
            sRAGenerator.UseSymbols = false;
            sRAGenerator.UseNumbers = false;

            var s = sRAGenerator.Generate(sRAGenerator.Numbers.Length).ToList();
            var r = sRAGenerator.UppercaseLetters.ToList();

            if (s.Except(r).ToList().Count > 0)
            {
                Assert.Fail("O gerador está gerando sequencias com caracteres diferentes dos pedidos.");
            }
        }

        [TestMethod]
        public void Test_SRAGenerator_Generate_Just_Symbols()
        {
            SRAGenerator sRAGenerator = new SRAGenerator();
            sRAGenerator.UseLowercaseLetters = false;
            sRAGenerator.UseUppercaseLetters = false;
            sRAGenerator.UseSymbols = true;
            sRAGenerator.UseNumbers = false;

            var s = sRAGenerator.Generate(sRAGenerator.Numbers.Length).ToList();
            var r = sRAGenerator.Symbols.ToList();

            if (s.Except(r).ToList().Count > 0)
            {
                Assert.Fail("O gerador está gerando sequencias com caracteres diferentes dos pedidos.");
            }
        }
    }
}
