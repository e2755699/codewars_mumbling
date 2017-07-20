using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codewars_mumbling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_a_shouldReturn_A()
        {
            AccumShouldBe("A", "a");
        }

        [TestMethod]
        public void Input_ab_shouldReturn_A_dash_Bb()
        {
            AccumShouldBe("A-Bb", "ab");
        }

        private static void AccumShouldBe(string expected, string input)
        {
            var sut = new Mumbling();
            var actual = sut.Accum(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InputIsEmpty_shouldReturnEmpty()
        {
            AccumShouldBe("", "");
        }

        [TestMethod]
        public void InputIsAB_shouldReturn_A_dash_Bb()
        {
            AccumShouldBe("A-Bb", "AB");
        }

        [TestMethod]
        public void InputIsABC_shouldReturn_A_dash_Bb_dash_Ccc()
        {
            AccumShouldBe("A-Bb-Ccc", "ABC");
        }


        [TestMethod]
      public void InputIs_shouldReturn()
      {
          AccumShouldBe("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu", "ZpglnRxqenU");
      }
    }
}
