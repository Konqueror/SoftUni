package addingAngles;

import java.util.Scanner;

public class AddingAngles {
	
	public static void main(String[] args) 
	{

		Scanner input = new Scanner(System.in);
		
		Boolean hasResult = false;
		Integer n = Integer.parseInt(input.nextLine());
		Integer[] numbers = new Integer[n];
		
		// fill numbers array
		for (Integer i=0; i < n; i++)
		{
			numbers[i] = Integer.parseInt(input.next());
		}
		
		input.close();
		
		// check all combinations of 3 numbers
		for (Integer i=0; i < n; i++)
			for (Integer j=i+1; j < n; j++)
				for (Integer k=j+1; k < n; k++)
				{
					if ( ( (numbers[i]+numbers[j]+numbers[k]) % 360) == 0)
					{
						if (!hasResult) hasResult = true;
						
						System.out.println(numbers[i] + " + " + numbers[j] + " + " + numbers[k] + " = " + (numbers[i]+numbers[j]+numbers[k]) + " degrees");
					}
				}
		
		if (!hasResult) System.out.println("No");
	}
}