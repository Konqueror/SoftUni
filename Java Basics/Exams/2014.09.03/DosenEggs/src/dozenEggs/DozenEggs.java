package dozenEggs;

import java.util.Scanner;

public class DozenEggs {
	
	public static void main(String[] args) 
	{
		
		Integer dozens=0, eggs=0, tmp=0;
		
		Scanner input = new Scanner(System.in);
		
		// 7 days
		for (Integer i=0; i<7; i++)
		{
			tmp = Integer.parseInt(input.next());
			
			if (input.next().equals("eggs"))
			{
				eggs += tmp;
			} 
			else
			{
				dozens += tmp;
			}
			
			input.nextLine();
		}
		
		input.close(); 
		
		if (eggs >= 12)
		{
			dozens += (Integer)eggs / 12;
			eggs = eggs % 12;
		}
		
		System.out.println(dozens + " dozens + "+eggs+" eggs");
	}
}