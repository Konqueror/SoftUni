package countAllWords;

import java.util.Scanner;

public class CountAllWords {
	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String[] splittedText = text.split("\\W+");
		
		System.out.println(splittedText.length);
	
	}
}