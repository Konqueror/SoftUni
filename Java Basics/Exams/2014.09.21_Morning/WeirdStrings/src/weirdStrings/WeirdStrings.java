package weirdStrings;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WeirdStrings 
{

	@SuppressWarnings("resource")
	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		String s = input.nextLine();
		String cleanString = "";
		LinkedHashMap<String, Integer> words = new LinkedHashMap<>();
		
		// remove junk
		cleanString = s.replaceAll("[\\/()| ]+","");
		
		Pattern sPattern = Pattern.compile("[a-zA-Z]+");
		Matcher matcher = sPattern.matcher(cleanString);
		
		while (matcher.find()) {
			words.put(matcher.group(),weight(matcher.group()));
		}
		
		String[] wKeys = words.keySet().toArray(new String[words.size()]);
		
		//System.out.println(words.size());
		
		int biggestSum = 0;
		int biggestKey = 0;
		
		for (int i=1; i<wKeys.length; i++)
		{

			if (biggestSum <= (words.get(wKeys[i]) + words.get(wKeys[i-1])) )
			{
				biggestSum = words.get(wKeys[i]) + words.get(wKeys[i-1]);
				biggestKey = i;
			}
		}
		
		System.out.println(wKeys[biggestKey-1]);
		System.out.println(wKeys[biggestKey]);
		
	}
	
	
	private static int weight(String s)
	{
		int n = 0;
		
		for (int i=0; i<s.length(); i++)
		{
			int temp = (int)s.charAt(i);
			
			if(temp<=90 & temp>=65)
			{
				n += (temp-64);
			}
			if (temp<=122 & temp>=97)
			{
				n += (temp-96);
			}
		}
		
		return n;
	}
	
}