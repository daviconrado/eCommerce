namespace E_commerce.Helper
{
	public class GeraCodigo
	{
		public int GeradorCodigo()
		{
			Random random = new Random();
			int codigo = random.Next(100000, 1000000);
			return codigo;
		}
	}
}
