package daysBetweenTwoDates;

import java.util.Scanner;
import org.joda.time.DateTime;
import org.joda.time.Days;

public class DaysBetweenTwoDates {

	public static void main(String[] args) {

		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String fDate = input.next();
		String sDate = input.next();
		String[] firstDate = fDate.split("-");
		String[] secondDate = sDate.split("-");

		DateTime first = new DateTime(
				Integer.parseInt(firstDate[2]),// Years
				Integer.parseInt(firstDate[1]),// Months
				Integer.parseInt(firstDate[0]),// Days
				0, 0);// Minutes & Seconds
		DateTime second = new DateTime(
				Integer.parseInt(secondDate[2]),
				Integer.parseInt(secondDate[1]),
				Integer.parseInt(secondDate[0]), 
				0, 0);
		long days = Days.daysBetween(first, second).getDays();
		System.out.println(days);
	}
}
