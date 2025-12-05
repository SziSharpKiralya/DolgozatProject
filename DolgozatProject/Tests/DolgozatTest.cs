using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProject.Tests
{
	[TestFixture]
	internal class DolgozatTest
	{
		Dolgozat dolgozat;

		[SetUp]
		public void SetUp()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void LehetetlenPontszam01()
		{
			Assert.Throws<ArgumentException>(
				() =>
				{
					dolgozat.PontFelvesz(-2);
				}
			);
		}

		[Test]
		public void LehetetlenPontszam02()
		{
			Assert.Throws<ArgumentException>(
				() =>
				{
					dolgozat.PontFelvesz(101);
				}
			);
		}

		[Test]
		public void MegengedettPontszam()
		{
			dolgozat.PontFelvesz(23);
			Assert.That(dolgozat.pontok[0], Is.EqualTo(23));
		}
	}
}
