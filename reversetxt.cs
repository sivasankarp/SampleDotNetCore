using System;
					
public class Program
{
	public static void Main()
	{
		string input = "hello world";
		string result = ReverseAlternate(RemoveWhiteSpace(input));
		
		Console.WriteLine("Output--" + result);
	}
	
	static string RemoveWhiteSpace(string input){
		return input.Replace(" ","");
	}
	
	static string ReverseAlternate(string input){
		char[] reverseArray = input.ToCharArray();
		Array.Reverse(reverseArray);
		for (int i=0; i< reverseArray.Length; i++)
		{
			if(i% 2 == 0){
				reverseArray[i] = char.ToUpper(reverseArray[i]);
			}
			else{
				reverseArray[i] = char.ToLower(reverseArray[i]);
			}
		}
		return new string(reverseArray);
	}
}
