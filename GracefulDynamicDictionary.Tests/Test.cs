using System;
using System.Dynamic;
using NUnit.Framework;


namespace GracefulDynamicDictionary.Tests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void TestMissingPropertyCheck()
		{
			dynamic dynamicObj = new DDict();
			bool hasUnassignedProperty = (dynamicObj.SomeProp != null);
			Assert.IsFalse(hasUnassignedProperty);
		}

		[Test]
		public void TestAssignDynamicProp()
		{
			dynamic dynamicObj = new DDict();
			dynamicObj.SomeProp = "A";
			Assert.AreEqual("A", dynamicObj.SomeProp);
		}
	}
}
