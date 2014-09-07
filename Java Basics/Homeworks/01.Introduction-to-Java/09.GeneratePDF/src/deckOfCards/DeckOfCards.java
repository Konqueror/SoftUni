package deckOfCards;

import java.io.*;
import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;

public class DeckOfCards 
{

    public static void main(String[] args) throws IOException, DocumentException 
    {
    	
		String[] cardValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
		String[] cardSuits = { "\u2665","\u2663", "\u2666", "\u2660" }; //♥ ♣ ♦ ♠
		 
		// create pdf document
		Document document = new Document();
		PdfWriter.getInstance(document, new FileOutputStream("Deck-of-Cards.pdf"));
		document.open();
		
		// crate table
		PdfPTable table = new PdfPTable(4);
		table.setWidthPercentage(100);
		table.getDefaultCell().setFixedHeight(50);
		
		// fonts
		BaseFont baseFont = BaseFont.createFont("resources/fonts/FreeSerif.ttf", BaseFont.IDENTITY_H, true);
		Font black = new Font(baseFont, 26f, 0, BaseColor.BLACK);
		Font red = new Font(baseFont, 26f, 0, BaseColor.RED);
		Font color = black;
    	
    	// add all the cards in the table
    	for (int i=0; i<cardSuits.length; i++)
    	{
			// change color
			if (i % 2 == 0)
				color = red;
			else
				color = black;
			
			// add the card
			for (int j=0; j<cardValues.length; j++) 
			{
				table.addCell(new Paragraph(cardValues[j] + " " + cardSuits[i], color));
			}
    		
    	}

 		document.add(table);
 		document.close();
 		
    }

}
