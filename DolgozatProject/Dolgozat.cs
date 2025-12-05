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
	}
}
