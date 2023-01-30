using System;
/*
public class WeightSort {
	
	//H S C D
	//AH AS 2D 3H 10K
	public static bool poker(string karty)
	{
		string[] cards = karty.Split(' ');
		List<string> numbers = new List<string>();
		List<string> sorted_numbers = new List<string>();
		List<string> suits = new List<string>();
		foreach (string card in cards)
		{
			if (card.Length == 2 )
			{
				char n = card[0];
				char s = card[1];
				numbers.Add(n.ToString());
				suits.Add(s.ToString());
			}
			else
			{
				string n = card[0] + card[1].ToString();
				char s = card[2];
				numbers.Add(n);
				suits.Add(s.ToString());
			}
		}

		if (suits[0] == suits[1] && suits[1] == suits[2] && suits[2] == suits[3] && suits[3] == suits[4])
		{
			bool cisla = true;
			int index = 0;
			// A 2 3 4 5 6 7 8 9 10 J Q K A
			foreach (string num in numbers)
			{
				if (num == "A")
				{
					numbers[index] = "1";
				}
				if (num == "J")
				{
					numbers[index] = "11";
				}
				if (num == "Q")
				{
					numbers[index] = "12";
				}
				if (num == "K")
				{
					numbers[index] = "13";
				}
				index++;
			}
			List<int> nums = numbers.Select(int.Parse).ToList();
			nums.Sort();
			if (nums[4] == nums[3]-1 && nums[3] == nums[2]-1 && nums[2] == nums[1]-1 && nums[1] == nums[0]-1 || nums[4] == nums[3]-1 && nums[3] == nums[2]-1 && nums[2] == nums[1]-1 && nums[0] == 1)
			{
				return true;
			}
		}
	}
}	
*/
string karty = "10D JD QD KD AD";
string[] cards = karty.Split(' ');
List<string> numbers = new List<string>();
List<string> suits = new List<string>();
foreach (string card in cards)
{
if (card.Length == 2 )
{
	char n = card[0];
	char s = card[1];
	numbers.Add(n.ToString());
	suits.Add(s.ToString());
}
else
{
	string n = card[0] + card[1].ToString();
	char s = card[2];
	numbers.Add(n);
	suits.Add(s.ToString());
}
}

if (suits[0] == suits[1] && suits[1] == suits[2] && suits[2] == suits[3] && suits[3] == suits[4])
{
	bool cisla = true;
	int index = 0;
	// A 2 3 4 5 6 7 8 9 10 J Q K A
	foreach (string num in numbers)
	{
		if (num == "A")
		{
			numbers[index] = "1";
		}
		if (num == "J")
		{
			numbers[index] = "11";
		}
		if (num == "Q")
		{
			numbers[index] = "12";
		}
		if (num == "K")
		{
			numbers[index] = "13";
		}
		index++;
	}
	List<int> nums = numbers.Select(int.Parse).ToList();
	nums.Sort();
	if (nums[4] == nums[3]+1 && nums[3] == nums[2]+1 && nums[2] == nums[1]+1 && nums[1] == nums[0]+1 || nums[4] == nums[3]+1 && nums[3] == nums[2]+1 && nums[2] == nums[1]+1 && nums[0] == 1)
	{
		Console.WriteLine("Jebej");
	}
	else
	{
		Console.WriteLine("Nejebej");
	}
}
else
{
	Console.WriteLine("Nejebej");
}

Console.ReadLine();
