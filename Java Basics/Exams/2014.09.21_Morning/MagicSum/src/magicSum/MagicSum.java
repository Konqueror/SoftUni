package magicSum;

import java.util.ArrayList;
import java.util.Scanner;

public class MagicSum
{
	
	public static void main(String[] args) 
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int D = Integer.parseInt(input.nextLine());
		ArrayList<Integer> numbers = new ArrayList<Integer>();
		String tmp = "";
		Boolean flag = false;
		int sum = Integer.MIN_VALUE, upperSum = Integer.MIN_VALUE;
		
		while ( input.hasNext() )
		{
			tmp = input.nextLine();
			
			if (tmp.equals("End") )
			{
				break;
			} else {
				numbers.add(Integer.parseInt(tmp));
			}
			
		}
		
		for (int i=0; i < numbers.size(); i++)
			for (int j=i+1; j < numbers.size(); j++)
				for (int k=j+1; k < numbers.size(); k++)
				{
					sum = numbers.get(i) + numbers.get(j) + numbers.get(k);
					
					if ( (sum % D == 0) && (sum > upperSum) )
					{
							tmp = "("+numbers.get(i)+" + "+numbers.get(j)+" + "+numbers.get(k)+") % "+D+" = 0";
							flag = true; upperSum = sum;
					}
				}
		
		if (!flag) {
			System.out.println("No");
		} else {
			System.out.println(tmp);
		}
		
	}
	
}
	