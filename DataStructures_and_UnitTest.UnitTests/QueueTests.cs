using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_UnitTest.UnitTests
{
    [TestFixture]
    class QueueTests
    {
        private Queue<string> _Q;

        [SetUp]
        public void Setup()
        {
            _Q = new Queue<string>();
        }

        [Test]
        public void push_ValidArgument_AddArgumentToTheQueue()
        {
            _Q.push("a");
            Assert.That(_Q.empty(), Is.False);
            Assert.That(_Q.front(), Is.EqualTo("a"));
        }

        [Test]
        public void pop_EmptyQueue_ThrowInvalidOperationException()
        {
            Assert.That(() => _Q.pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void pop_QueueContainsOnlyOneElement_RemoveTheFrontElementAndQueueIsEmpty()
        {
            _Q.push("a");
            _Q.pop();
            var result = _Q.empty();
            Assert.That(result, Is.True);
        }

        [Test]
        public void pop_QueueContainsMoreThanOneElement_RemoveTheFrontElement()
        {
            _Q.push("a");
            _Q.push("b");

            var Prev_front = _Q.front();
            _Q.pop();
            var Cur_front = _Q.front();
            Assert.That(Prev_front != Cur_front);
        }

        [Test]
        public void front_EmptyQueue_ThrowInvalidOperationException()
        {
            Assert.That(() => _Q.front(), Throws.InvalidOperationException);
        }

        [Test]
        public void front_QueueNotEmpty_ReturnFrontElementOfQueue()
        {
            _Q.push("a");
            _Q.push("b");
            var Front = _Q.front();
            Assert.That(Front, Is.EqualTo("a"));
        }

        [Test]
        public void rear_EmptyQueue_ThrowInvalidOperationException()
        {
            Assert.That(() => _Q.rear(), Throws.InvalidOperationException);
        }

        [Test]
        public void rear_QueueNotEmpty_ReturnFrontElementOfQueue()
        {
            _Q.push("a");
            _Q.push("b");
            var Rear = _Q.rear();
            Assert.That(Rear, Is.EqualTo("b"));
        }

        [Test]
        public void empty_EmptyQueue_ReturnTrue()
        {
            var IsEmpty = _Q.empty();
            Assert.That(IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void empty_QueueNotEmpty_ReturnFalse()
        {
            _Q.push("a");
            var IsEmpty = _Q.empty();
            Assert.That(IsEmpty, Is.EqualTo(false));
        }

    }
}
