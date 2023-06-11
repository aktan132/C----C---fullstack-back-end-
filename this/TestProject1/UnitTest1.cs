namespace TestProject1
   
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void circle30()
        {
            int R = 30;
            double result =  Math.PI * Math.Pow(R, 2);

            double result1 = @this.Class1.circle(30);

            Assert.AreEqual(result, result1);
        }
        [Test]
        public void triangle()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            double p = 6;
            double s = 6;
            double result = @this.Class1.triangle(4, 5, 3);
            Assert.AreEqual(s, result);
        }

    }
}