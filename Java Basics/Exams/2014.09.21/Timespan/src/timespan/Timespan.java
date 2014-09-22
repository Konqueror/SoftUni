package timespan;

import java.util.Scanner;

public class Timespan
{
	
	public static void main(String[] args) 
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String start = input.nextLine();
		String end = input.nextLine();
		
		String[] startData = start.split(":");
		String[] endData = end.split(":");
		
		int startH = Integer.parseInt(startData[0]);
		int startM = Integer.parseInt(startData[1]);
		int startS = Integer.parseInt(startData[2]);
		
		int endH = Integer.parseInt(endData[0]);
		int endM = Integer.parseInt(endData[1]);
		int endS = Integer.parseInt(endData[2]);
		
		int durationH = 0, durationM = 0, durationS = 0;
		
		String duration = "";
		
		durationH = startH - endH;
		
		if (startM >= endM)
		{
			durationM = startM - endM;
		} 
		else 
		{
			durationM = 60 - (endM - startM);
			durationH = durationH -1;
		}
		
		if (startS >= endS)
		{
			durationS = startS - endS;

		}
		else
		{
			durationS = 60 - (endS - startS);
			durationM = durationM - 1;
		}
		
		duration = durationH + ":";
		
		if (durationM < 10)
		{
			duration = duration + "0" + durationM + ":";
		} else {
			duration = duration + durationM + ":";
		}
		
		if (durationS < 10)
		{
			duration = duration + "0" + durationS;
		} else {
			duration = duration + durationS;
		}

		
		System.out.println(duration);
		
		
	}
	
}