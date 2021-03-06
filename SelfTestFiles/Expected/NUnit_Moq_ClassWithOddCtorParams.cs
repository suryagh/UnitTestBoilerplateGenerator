using Moq;
using NUnit.Framework;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestFixture]
	public class ClassWithOddCtorParamsTests
	{
		private MockRepository mockRepository;



		[SetUp]
		public void SetUp()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);


		}

		[TearDown]
		public void TearDown()
		{
			this.mockRepository.VerifyAll();
		}

		[Test]
		public void TestMethod1()
		{
			// Arrange


			// Act
			ClassWithOddCtorParams classWithOddCtorParams = this.CreateClassWithOddCtorParams();


			// Assert

		}

		private ClassWithOddCtorParams CreateClassWithOddCtorParams()
		{
			return new ClassWithOddCtorParams(
				TODO,
				TODO);
		}
	}
}
