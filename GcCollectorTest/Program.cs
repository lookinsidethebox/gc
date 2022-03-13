public class Program
{
	private static Random random = new Random();
	private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

	public static string RandomString(int length) =>
		new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

	public static void Main()
	{
		var arr = new string[1000];

		for (ulong i = 0; i < ulong.MaxValue; ++i)
		{
			var index = i % (ulong)arr.Length;
			arr[index] = RandomString(85 * 1024);
			arr[index] += "1";
		}
	}
}