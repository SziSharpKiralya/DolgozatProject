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
		public void MegengedettPontszam03()
		{
			dolgozat.PontFelvesz(23);
			Assert.That(dolgozat.pontok[0], Is.EqualTo(23));
		}

		[Test]
		public void SenkiNemIrtaMeg04()
		{
			Assert.Throws<ArgumentException>(
				() =>
				{
					dolgozat.MindenkiMegirta();
				}
			);
		}

		[Test]
		public void ValakiNemIrtaMeg05()
		{
			dolgozat.PontFelvesz(23);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(76);
			Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
		}

		[Test]
		public void MindenkiMegirta06()
		{
			dolgozat.PontFelvesz(23);
			dolgozat.PontFelvesz(52);
			dolgozat.PontFelvesz(76);
			Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(true));
		}

		[Test]
		public void EgyTanuloBukott07()
		{
			dolgozat.PontFelvesz(23);
			dolgozat.PontFelvesz(52);
			dolgozat.PontFelvesz(76);
			Assert.That(dolgozat.Bukas, Is.EqualTo(1));
		}

		[Test]
		public void KettoTanuloBukott08()
		{
			dolgozat.PontFelvesz(23);
			dolgozat.PontFelvesz(46);
			dolgozat.PontFelvesz(76);
			Assert.That(dolgozat.Bukas, Is.EqualTo(2));
		}

		[Test]
		public void SenkiSemBukott09()
		{
			dolgozat.PontFelvesz(51);
			dolgozat.PontFelvesz(52);
			dolgozat.PontFelvesz(76);
			Assert.That(dolgozat.Bukas, Is.EqualTo(0));
		}
	}
}
