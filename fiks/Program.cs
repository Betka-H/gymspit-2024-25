//fiks
/*
50          // total tasks

3 2 8 11    // how many points + speeds
5 8 6       // point 1
2 4 6       // point 2
11 1 6      // point 3

3 1 3 5
2 6 15
- 5 7 15
- 6 3 15

3 1 2 10
14 4 11
20 12 11
24 2 11

3 5 11 14
6 8 3
- 4 9 3
- 7 12 3

3 4 5 14
16 9 12
14 8 12
12 12 12
*/
/* 
void printList(List<int> list)
{
	Console.Write("line: ");
	foreach (int i in list)
	{
		Console.Write(i + ", ");
	}
	Console.WriteLine();
}
void printListInList(List<List<int>> list)
{
	Console.WriteLine("block: ");
	foreach (List<int> l in list)
	{
		printList(l);
	}
	Console.WriteLine();
}
void printTheListOfAllLists(List<List<List<int>>> list)
{
	Console.WriteLine("all: ");
	foreach (List<List<int>> l in list)
	{
		printListInList(l);
	}
	Console.WriteLine();
}
string[] lines = File.ReadAllLines("C:\\Users\\eliza\\Downloads\\input.txt");
List<List<List<int>>> taskList = new List<List<List<int>>>(); // list of lists of integers - every task's lines
List<List<int>> tempList = new List<List<int>>(); // list to which the current task lines are added
for (int i = 1; i < lines.Length; i++) // for every line except the first one
{
	void saveBlock()
	{
		taskList.Add(new List<List<int>>(tempList)); // save the list
		tempList.Clear();
	}

	List<int> numbersOnThisLine = new List<int>();
	foreach (string num in lines[i].Split(" ")) // get all numbers on the line
	{
		numbersOnThisLine.Add(int.Parse(num));
	}

	if (numbersOnThisLine.Count() == 4 && tempList.Count != 0) // when there are 4 numbers, save the list
	{
		saveBlock();
	}
	tempList.Add(numbersOnThisLine);
	if (i == lines.Length - 1) // if its the last one (there are no more 4 lines)
	{
		saveBlock();
	}
}
// printTheListOfAllLists(taskList);
using (StreamWriter writer = new StreamWriter("C:\\Users\\eliza\\Downloads\\output.txt"))
{
	foreach (List<List<int>> block in taskList) // for each block
	{
		List<int> stats = block[0];
		int speedUp = stats[1];
		int speedStraight = stats[2];
		int speedDown = stats[3];

		Console.WriteLine($"su: {speedUp} ss: {speedStraight} sd: {speedDown}");
		float result = 0;

		for (int i = 1; i < block.Count() - 1; i++) // for each line in the block
		{
			List<int> line = block[i];
			int x1 = line[0];
			int y1 = line[1];
			int z1 = line[2];
			Console.Write($"x1: {x1} y1: {y1} z1: {z1}, ");

			List<int> linei1 = block[i + 1];
			int x2 = linei1[0];
			int y2 = linei1[1];
			int z2 = linei1[2];
			Console.WriteLine($"x2: {x2} y2: {y2} z2: {z2}");
			int speed = calcSpeed(z1, z2);
			int calcSpeed(int z1, int z2)
			{
				if (z1 < z2) return speedUp;
				else if (z1 > z2) return speedDown;
				else return speedStraight;
			}
			Console.Write($"speed {speed}, ");

			float distance = MathF.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1))); // ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))
			Console.Write($"distance {distance}, ");

			float time = distance / speed;
			Console.WriteLine($"time {time}");

			result += time;

			// Console.WriteLine();
		}
		Console.WriteLine($"result: {result}");
		writer.WriteLine(result);
	}
	Console.WriteLine();
}
 */

/* 
kompetence posadky = nejnizsi kompetence
kazdy ma pocatecni kompetentnost
kazdy muze mit prime podrizene
kazdy ma prave jednoho primeho nadrizeneho (krome velitele)
rozdelit body, aby byla posadka stabilni (nebo ze to nejde), maximalizovat kompetentnost
vyssi pozice musi byt vice kompetentni

Na druhém řádku se nachází n mezerou oddělených celých čísel ai (0 ≤ ai ≤ 1018, 1 ≤ i ≤ n) –
i-té číslo reprezentuje počáteční kompetentnost i-tého člena posádky.
Na třetím řádku se nachází n mezerou oddělených čísel pi (1 ≤ pi ≤ n, 1 ≤ i ≤ n) – i-té číslo
reprezentuje přímého nadřízeného i-tého člena posádky (nebo pi = −1 pokud je i-tý člen posádky
velitelem posádky).

10 - crews

3 10 - members and skill points
1 0 3
2 -1 1

3 7
0 1 3
-1 1 2

10 53
7 1 5 6 1 2 4 0 2 6
8 6 -1 3 3 7 3 7 6 5

2 1
3 1
-1 1

3 3
2 2 1
2 -1 1

2 2
3 1
-1 1

4 5
0 2 0 2
4 4 2 -1

5 8
2 8 9 7 5
5 3 -1 2 2

6 8
0 2 2 3 4 6
3 6 2 2 6 -1

1 2147483648
1000000000000000000
-1



3
ajajaj
7
2
1
2
1
6
3
1000000002147483648
 */


