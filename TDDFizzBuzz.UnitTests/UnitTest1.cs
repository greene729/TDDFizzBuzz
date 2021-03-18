using NUnit.Framework;
using TDDFizzBuzz;

namespace UnitTests
{
    public class Tests
    {
        private FizzBuzz _fizzBuzz;
        
        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Play_IntOneReturnsOneAsString()
        {
            var input = 1;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Play_IntTwoReturnsTwoAsString()
        {
            var input = 2;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Play_IntThreeReturnsStringFizz()
        {
            var input = 3;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Play_IntFiveReturnsStringBuzz()
        {
            var input = 5;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Play_IntSixReturnsStringFizz()
        {
            var input = 6;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Play_IntTenReturnsStringBuzz()
        {
            var input = 10;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Play_IntFifteenReturnsStringFizzBuzz()
        {
            var input = 15;
            var result = _fizzBuzz.Play(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}