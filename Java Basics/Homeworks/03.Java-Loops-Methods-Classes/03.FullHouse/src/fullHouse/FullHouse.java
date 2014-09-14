package fullHouse;

public class FullHouse {

	public static void main(String[] args) {
		char[] suits = { '\u2666', '\u2663', '\u2665', '\u2660' };
		String[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A"};
		int fullHouses = 0;
		for (int three = 0; three < faces.length; three++) {
			for (int two = 0; two < faces.length; two++) {
				if (three != two){
					for (int firstSuit = 0; firstSuit < suits.length; firstSuit++) {
						for (int secondSuit = firstSuit + 1; secondSuit < suits.length; secondSuit++) {
							for (int thirdSuit = secondSuit + 1; thirdSuit < suits.length; thirdSuit++) {
								for (int fourthSuit = 0; fourthSuit < suits.length; fourthSuit++) {
									for (int fifthSiuth = fourthSuit + 1; fifthSiuth < suits.length; fifthSiuth++) {
										System.out.println(
												faces[three] + suits[firstSuit] + 
												faces[three]+ suits[secondSuit] + 
												faces[three]+ suits[thirdSuit] + 
												faces[two]+ suits[fourthSuit] + 
												faces[two]+ suits[fifthSiuth]);
										fullHouses++;
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.println(fullHouses + " Full houses");
	}
}