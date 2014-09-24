package nuts;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.Map.Entry;

public class Nuts
{

	@SuppressWarnings("resource")
	public static void main(String[] args)
	{

		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		input.nextLine();

		TreeMap<String, LinkedHashMap<String, Integer>> company = new TreeMap<>();
		LinkedHashMap<String, Integer> currentCompany = new LinkedHashMap<>();

		for (int i = 0; i < n; i++)
		{

			String[] data = input.nextLine().split(" ");

			String companyName = data[0];
			String nutName = data[1];
			Integer amount = Integer.parseInt(data[2].replace("kg", ""));

			// add company if dont exist
			if (!company.containsKey(companyName))
			{
				company.put(companyName, new LinkedHashMap<>());
			}

			currentCompany = company.get(companyName);

			// add nut if dont exist for the company or add amount for it
			if (!currentCompany.containsKey(nutName))
			{
				currentCompany.put(nutName, amount);
				company.put(companyName, currentCompany);
			} else {
				currentCompany.put(nutName, currentCompany.get(nutName) + amount);
				company.put(companyName, currentCompany);
			}

		}

		String[] tempa = (String[]) company.keySet().toArray(new String[company.size()]);
		String output = "";

		for (int i=0; i<tempa.length; i++)
		{
			currentCompany = company.get(tempa[i]);
			String[] nuts = currentCompany.keySet().toArray(new String[currentCompany.size()]);
			output += tempa[i]+": ";

			for (int j=0; j<nuts.length; j++)
			{
				if (j>0)
				{
					output += ", "+nuts[j]+"-"+currentCompany.get(nuts[j])+"kg";
				}
				else
				{
					output += nuts[j]+"-"+currentCompany.get(nuts[j])+"kg";
				}
			}

			output += "\n";

		}

		System.out.println(output);

	}

}