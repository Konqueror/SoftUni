package generate3LetterWords;

import java.util.Scanner;

public class Generate3LetterWords {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		char[] chars = input.next().toCharArray();

		for (int f = 0; f < chars.length; f++) {
			String firstChar = Character.toString(chars[f]);
			for (int s = 0; s < chars.length; s++) {
				String secondChar = Character.toString(chars[s]);
				for (int t = 0; t < chars.length; t++) {
					String thirdChar = Character.toString(chars[t]);
					System.out.print(firstChar + secondChar + thirdChar + " ");
				}
			}
		}
	}
}
