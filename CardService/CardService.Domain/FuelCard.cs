namespace CardService.Domain;

public class FuelCard
{
	public int Id { get; }
	public string Number { get; }
	public int DailyLimit { get; }
	public bool IsActive { get; set; }

	public FuelCard(int id, string number, int dailyLimit)
	{
		if (dailyLimit <= 0) throw new ArgumentOutOfRangeException(nameof(dailyLimit));
		
		Id = id;
		Number = number;
		DailyLimit = dailyLimit;
	}
}