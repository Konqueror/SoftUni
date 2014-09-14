package randomHandsOf5Cards;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int hands = input.nextInt();
		Random pullRandom = new Random();

		String[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
		String[] suits = { "♣", "♦", "♥", "♠" };

		ArrayList<String> deck = new ArrayList<String>();
		for (int f = 0; f < 13; f++) {
			for (int s = 0; s < 4; s++) {
				deck.add(faces[f] + suits[s]);
			}
		}

		ArrayList<String> handOfRandom = new ArrayList<>();
		for (int i = 0; i < hands; i++) {
			for (int card = 0; card < 5; card++) {
				int index = pullRandom.nextInt(deck.size());
				String randCard = deck.get(index);
				handOfRandom.add(randCard);
				deck.remove(index);
			}
		}
		
		for (int c = 0; c < handOfRandom.size(); c++) {
			System.out.print(handOfRandom.get(c) + " ");
			if ((c + 1) % 5 == 0) {
				System.out.println(handOfRandom.get(c) + " ");
			}
		}
	}
}
