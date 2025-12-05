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
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(23);
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

		[Test]
		public void MindenJegybolEgy10()
		{
			dolgozat.PontFelvesz(23);
			dolgozat.PontFelvesz(52);
			dolgozat.PontFelvesz(67);
			dolgozat.PontFelvesz(75);
			dolgozat.PontFelvesz(94);
			Assert.That(dolgozat.Bukas, Is.EqualTo(1));
			Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
			Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
			Assert.That(dolgozat.Jo, Is.EqualTo(1));
			Assert.That(dolgozat.Jeles, Is.EqualTo(1));
		}

		[Test]
		public void ElegsegesHatarErtekek11()
		{
			dolgozat.PontFelvesz(49);
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(60);
			dolgozat.PontFelvesz(61);
			Assert.That(dolgozat.Elegseges, Is.EqualTo(2));
		}

		[Test]
		public void KozepesHatarErtekek12()
		{
			dolgozat.PontFelvesz(60);
			dolgozat.PontFelvesz(61);
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(71);
			Assert.That(dolgozat.Kozepes, Is.EqualTo(2));
		}

		[Test]
		public void JoHatarErtekek13()
		{
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(71);
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(81);
			Assert.That(dolgozat.Jo, Is.EqualTo(2));
		}

		[Test]
		public void JelesHatarErtekek14()
		{
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(81);
			dolgozat.PontFelvesz(100);
			Assert.That(dolgozat.Jeles, Is.EqualTo(2));
		}

		[Test]
		public void MindenJegybolSenkiSemIrtaMeg15()
		{
			Assert.Throws<ArgumentException>(() =>{dolgozat.Bukas();});
			Assert.Throws<ArgumentException>(() => { dolgozat.Elegseges(); });
			Assert.Throws<ArgumentException>(() => { dolgozat.Kozepes(); });
			Assert.Throws<ArgumentException>(() => { dolgozat.Jo(); });
			Assert.Throws<ArgumentException>(() => { dolgozat.Jeles(); });
		}

		[Test]
		public void SenkiNemGyanus16()
		{
			dolgozat.PontFelvesz(56);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(84);
			dolgozat.PontFelvesz(97);
			Assert.That(dolgozat.Gyanus(2), Is.EqualTo(false));
		}

		[Test]
		public void ValakiGyanus17()
		{
			dolgozat.PontFelvesz(56);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(84);
			dolgozat.PontFelvesz(97);
			Assert.That(dolgozat.Gyanus(1), Is.EqualTo(true));
		}
	}
}
