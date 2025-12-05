namespace DolgozatProject
{
    public class Dolgozat
    {
		public List<int> pontok { get; set; }

		public Dolgozat()
		{
			this.pontok = [];
		}

		public void PontFelvesz(int pont)
		{
			if (pont < -1)
			{
				throw new ArgumentException("Ez nem lehet megadott pontszám!");
			}
			else if (pont > 100)
			{
				throw new ArgumentException("Ez meghaladja a maximális megadott pontszámot!");
			}
			else
			{
				this.pontok.Add(pont);
			}
		}

		public bool MindenkiMegirta()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			foreach (var tanulo in pontok)
			{
				if (tanulo == -1)
				{
					return false;
				}
			}

			return true;
		}

		public int Bukas()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int bukottakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (!(tanulo == -1) && tanulo < 50)
				{
					bukottakSzama++;
				}
			}

			return bukottakSzama;
		}

		public int Elegseges()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int szamoltakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (!(tanulo == -1) && tanulo > 49 && tanulo < 61)
				{
					szamoltakSzama++;
				}
			}

			return szamoltakSzama;
		}

		public int Kozepes()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int szamoltakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (!(tanulo == -1) && tanulo > 60 && tanulo < 71)
				{
					szamoltakSzama++;
				}
			}

			return szamoltakSzama;
		}

		public int Jo()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int szamoltakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (!(tanulo == -1) && tanulo > 70 && tanulo < 81)
				{
					szamoltakSzama++;
				}
			}

			return szamoltakSzama;
		}

		public int Jeles()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int szamoltakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (!(tanulo == -1) && tanulo > 80)
				{
					szamoltakSzama++;
				}
			}

			return szamoltakSzama;
		}

		public bool Gyanus(int kivalok)
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			if (Jeles() > kivalok)
			{
				return true;
			}

			return false;
		}

		public bool Ervenytelen()
		{
			if (pontok.Count == 0)
			{
				throw new ArgumentException("Ezt a dolgozatot senki sem írta meg!");
			}

			int hianyzottakSzama = 0;
			foreach (var tanulo in pontok)
			{
				if (tanulo == -1)
				{
					hianyzottakSzama++;
				}
			}

			if (hianyzottakSzama >= pontok.Count / 2)
			{
				return true;
			}

			return false;
		}
	}
}
