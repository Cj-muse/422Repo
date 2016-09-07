﻿using NUnit.Framework;
using System;
using CS422;

namespace PCQueueTests
{
	[TestFixture ()]
	public class Test
	{
		private PCQueue _queue;

		[SetUp]
		public void SetUp()
		{
			//Arrange
			_queue = new PCQueue();
		}

		[Test]
		public void Dequeue()
		{
			//Arrange	
			int outvalue = 0;
			_queue.Enqueue(1);
			_queue.Enqueue(2);
			_queue.Enqueue(3);

			//Act
			bool result = _queue.Dequeue(ref outvalue);

			//Assert
			Assert.AreEqual(1, outvalue);
			Assert.IsTrue(result);
		}

		[Test]
		public void FillThenEmptyQueue()
		{
			//Arrange
			int outvalue1 = 0, outvalue2 = 0,  outvalue3 = 0, outvalue4 = 0;
			bool result1, result2, result3, result4;
			_queue.Enqueue(1);
			_queue.Enqueue(2);
			_queue.Enqueue(3);


			//Act
			result1 = _queue.Dequeue(ref outvalue1);
			result2 = _queue.Dequeue(ref outvalue2);
			result3 = _queue.Dequeue(ref outvalue3);
			result4 = _queue.Dequeue(ref outvalue4);

			//Assert
			Assert.IsTrue(result1);
			Assert.IsTrue(result2);
			Assert.IsTrue(result3);
			Assert.IsFalse(result4);
		}
	}
}

