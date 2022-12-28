using NUnit.Framework;
namespace DataStructures_and_UnitTest.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        private Stack<string> _Stk;

        [SetUp]
        public void Setup()
        {
            _Stk = new Stack<string>();
        }

        [Test]
        public void push_ValidArgument_AddObjectToTheStack()
        {

            _Stk.push("abc");

            Assert.That(_Stk.empty(), Is.EqualTo(false));
            Assert.That(_Stk.top(), Is.EqualTo("abc"));
        }
        [Test]
        public void top_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => _Stk.top(), Throws.InvalidOperationException);
        }
        [Test]
        public void pop_EmptyStack_ThrowInvalidOperationException()
        {

            Assert.That(() => _Stk.pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void pop_StackNotEmpty_RemoveTopElementFromStack()
        {

            _Stk.push("A");
            var Top = _Stk.top();
            _Stk.pop();

            Assert.That(Top != null);
        }

        [Test]
        public void empty_StackNotEmpty_ReturnFalse()
        {
            _Stk.push("a");
            var result = _Stk.empty();
            Assert.That(result, Is.False);
        }

        [Test]
        public void empty_EmptyStack_ReturnTrue()
        {
            var result = _Stk.empty();
            Assert.That(result, Is.True);
        }
    }
}
