using NUnit.Framework;
namespace DataStructures_and_UnitTest.UnitTests
{
    [TestFixture]
    public class StackTests
    {


        [Test]
        public void push_ValidArgument_AddObjectToTheStack()
        {
            //Arrange
            Stack<string> Stk = new Stack<string>();

            //Act
            Stk.push("abc");

            //Assert
            Assert.That(Stk.empty(), Is.EqualTo(false));
            Assert.That(Stk.top(), Is.EqualTo("abc"));
        }
        [Test]
        public void top_EmptyStack_ThrowInvalidOperationException()
        {
            Stack<string> Stk = new Stack<string>();
            Assert.That(() => Stk.top(), Throws.InvalidOperationException);
        }
        [Test]
        public void pop_EmptyStack_ThrowInvalidOperationException()
        {

            Stack<string> Stk = new Stack<string>();
            Assert.That(() => Stk.pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void pop_StackNotEmpty_RemoveTopElementFromStack()
        {
            Stack<string> Stk = new Stack<string>();

            Stk.push("A");
            Stk.push("B");

            Stk.pop();

            Assert.That(Stk.top(), Is.EqualTo("A"));
        }

        [Test]
        public void empty_StackNotEmpty_ReturnFalse()
        {
            Stack<string> Stk = new Stack<string>();
            Stk.push("a");
            var result = Stk.empty();
            Assert.That(result, Is.False);
        }

        [Test]
        public void empty_EmptyStack_ReturnTrue()
        {
            Stack<string> Stk = new Stack<string>();
            var result = Stk.empty();
            Assert.That(result, Is.True);
        }
    }
}