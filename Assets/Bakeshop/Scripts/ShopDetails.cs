using UnityEngine;
using System.Collections;

public class ShopDetails : MonoBehaviour {
	public static string[,] name = new string[12,5];
	public static string[,] details = new string[12,5];

	void Start () {
		setWallpaper ();
		setFloor ();
		setWindow ();
		setLandscape ();
		setPortrait ();
		setFloorLamp ();
		setDrawer ();
		setSideTable ();
		setFrontTable ();
		setKitchenTable ();
		setShelf ();
		setGasRange ();
	}

	public void setWallpaper() {
		name 	[0, 0] = "Spring Vibes";
		details [0, 0] = "Always feel the spring vibes blooming in the room with this flower designed wallpaper!";

		name 	[0, 1] = "Modern";
		details [0, 1] = "This is the most popular and our best-seller for a modern interior look.";

		name 	[0, 2] = "Artistic";
		details [0, 2] = "With a very intricate design, this wallpaper is very noticeable that every visitor you have will stare at it for a moment.";

		name 	[0, 3] = "Elegant";
		details [0, 3] = "The black and white combination produces an elegant look that will suit most room interiors!";

		name 	[0, 4] = "Royalty";
		details [0, 4] = "Turn your room into your own version of the royal palace and live like a royalty!";
	}

	public void setFloor() {
		name 	[1, 0] = "Cork";
		details [1, 0] = "Cork is comfortable underfoot and a natural insulator which can help lowering your energy bills.";
		
		name 	[1, 1] = "Laminate";
		details [1, 1] = "Laminate floors give the hardwood looks at a cheaper price.";
		
		name 	[1, 2] = "Vinyl";
		details [1, 2] = "Vinyl’s durability, cheap cost and low maintenance makes it a popular choice among buyers.";
		
		name 	[1, 3] = "Tiles";
		details [1, 3] = "The elegant and cutting edge designs of tiles will surely add beauty to your place.";
		
		name 	[1, 4] = "Concrete";
		details [1, 4] = "Stylish and durable choice for indoor floors and it can be finished in various ways.";
	}

	public void setWindow() {
		name 	[2, 0] = "Double-hung";
		details [2, 0] = "This type opens by raising or lowering the lower or upper half. The frames are made from vinyl, the least expensive material.";
		
		name 	[2, 1] = "Fixed";
		details [2, 1] = "Made from fiberglass, fixed windows can’t be opened. Its function is limited to allowing light only.";
		
		name 	[2, 2] = "Casement";
		details [2, 2] = "A vertical window that opens outward. Made from tried and tested material, the wood.";
		
		name 	[2, 3] = "Chinese style";
		details [2, 3] = "A Chinese themed window. It gives the traditional Chinese vibes in every building.";
		
		name 	[2, 4] = "Slider";
		details [2, 4] = "Two windows that slide side-to-side. It is made from aluminum which is known for being maintenance -free.";
	}

	public void setLandscape() {
		name 	[3, 0] = "“Guilty Pleasure”";
		details [3, 0] = "Dig in with your favorite guilty pleasures with this artwork painted by a local artist in town.";
		
		name 	[3, 1] = "“Breakfast”";
		details [3, 1] = "Make hungry customers crave for a nice breakfast meal with this masterpiece from a renowned artist in Parisse.";
		
		name 	[3, 2] = "“Closing Time”";
		details [3, 2] = "More than an empty place, the artist’s emotion was perfectly translated in this work of art. Can you feel it?";
		
		name 	[3, 3] = "“Afternoon Walk”";
		details [3, 3] = "Revitalize yourself with this award-winning artwork depicting a serene afternoon.";
		
		name 	[3, 4] = "“The Alley”";
		details [3, 4] = "Once famed for being the liveliest alley in town, the painter captured it perfectly before it was bombed during the war.";
	}

	public void setPortrait() {
		name 	[4, 0] = "“A Day in Parisse”";
		details [4, 0] = "Painted by a tourist during his stay in Parisse, the artist was very fascinated by the town’s landscape.";
		
		name 	[4, 1] = "“Rotting Lane”";
		details [4, 1] = "It is said that this piece of art was created by a dying artist waiting for his time, thus the title of the artwork.";
		
		name 	[4, 2] = "“Memories”";
		details [4, 2] = "The painters’ precious memories were embedded in this image. It is his final work, which makes it special.";
		
		name 	[4, 3] = "“Festival Night”";
		details [4, 3] = "Parisse is lively even at nights, like there is always a festival going on. A local tourist created this artwork.";
		
		name 	[4, 4] = "“Zen”";
		details [4, 4] = "A mysterious painting that is said to bring peace among those who see it. The painter is still unknown up to this day.";
	}

	public void setFloorLamp() {
		name 	[5, 0] = "Basic";
		details [5, 0] = "Basic looking and very affordable lamp.";
		
		name 	[5, 1] = "Low-energy";
		details [5, 1] = "Save yourself from high energy consumption with this efficient, low-cost lamp!";
		
		name 	[5, 2] = "Traditional";
		details [5, 2] = "Vintage and classy. This is the most popular choice and our current best-seller.";
		
		name 	[5, 3] = "Oriental";
		details [5, 3] = "Give your room an Asian look with this unique lamp. It was made from organic materials like straw and bamboo piece.";
		
		name 	[5, 4] = "Modern";
		details [5, 4] = "Best suited for modern styled rooms, this model is very elegant and most wanted among our list.";
	}

	public void setDrawer () {
		name 	[6, 0] = "Atara Maple Basic";
		details [6, 0] = "Best known for its cheap and affordable price, the Atara Maple Basic is simple yet sturdy addition to your kitchen.";
		
		name 	[6, 1] = "Mont Blanc Classic";
		details [6, 1] = "With its deep and large shelves, you can store pretty much everything in this kitchen cabinet!";
		
		name 	[6, 2] = "Sumera Birch Standard";
		details [6, 2] = "This popular model features a large cabinet at the center and two panels at both sides with adjustable shelves.";
		
		name 	[6, 3] = "SB Standard V2";
		details [6, 3] = "The Sumera Birch’ v2 with doors. Your valuables are safe because the doors are lockable!";
		
		name 	[6, 4] = "Carlson Premium";
		details [6, 4] = "The gliders of this best-selling model were made stronger to hold heavy items because we care for your valuables too!";
	}

	public void setSideTable () {
		name 	[7, 0] = "Hardwood Brown";
		details [7, 0] = "Made from the cheapest hardwood, this is a popular choice among buyers.";
		
		name 	[7, 1] = "Cyan Hue";
		details [7, 1] = "Polished side table with spacious panels for keeping stuff. Made from lightwood material.";
		
		name 	[7, 2] = "Ash Gray";
		details [7, 2] = "Best for space-constricted rooms because of its dimensions. It has two drawers and mini-shelf. ";
		
		name 	[7, 3] = "Classic Red";
		details [7, 3] = "This traditional, classic looking is a limited edition design originating from the eastern part of the world.";
		
		name 	[7, 4] = "Granite Black";
		details [7, 4] = "Famed for its durability, this is actually made from marble so it has a smooth texture but is really heavy.";
	}

	public void setFrontTable () {
		name 	[8, 0] = "Sumera Basic";
		details [8, 0] = "A basic wooden table with an intricate lining design in the center. Pretty sturdy.";
		
		name 	[8, 1] = "Mont Blanc Finest";
		details [8, 1] = "The most popular choice because of its fine details and cheap price.";
		
		name 	[8, 2] = "Bjanara Creations";
		details [8, 2] = "Stunning craft. This well-made table was exported from a well-known furniture making country!";
		
		name 	[8, 3] = "Fusion";
		details [8, 3] = "Stylish and classy. The legs and frame support are made from wood while the top is 100% marble.";
		
		name 	[8, 4] = "Kingsmond PRO";
		details [8, 4] = "The most expensive from the line. Laminated at the top is a very elegant design from the most famous designer in town!";
	}

	public void setKitchenTable () {
		name 	[9, 0] = "Mont Blanc Regular";
		details [9, 0] = "Simple looking and cheap. Great for a minimalist room interior.";
		
		name 	[9, 1] = "Carlson Adamant Series";
		details [9, 1] = "Its key feature is its top-notch durability that can easily best the others!";
		
		name 	[9, 2] = "Kraken Collection";
		details [9, 2] = "This model is famed for its extendable feature which can seat 16 heads at a time.";
		
		name 	[9, 3] = "Atara Creations";
		details [9, 3] = "Popular among men, the dark color boasts of elegance and style of this model.";
		
		name 	[9, 4] = "Kingsmond Gold";
		details [9, 4] = "Quality at its finest! The texture is so well-polished that you can see your reflection in the surface!";
	}

	public void setShelf () {
		name 	[10, 0] = "The Classic";
		details [10, 0] = "Simple and cheap. Do not let its appearance fool you; it’s actually made from light timber material.";
		
		name 	[10, 1] = "El Toro";
		details [10, 1] = "Its striking look makes it a popular choice among men. It is named after its maker, the infamous El Toro.";
		
		name 	[10, 2] = "Majestic Curves";
		details [10, 2] = "The vintage yet majestic look of the shelf will definitely add elegance to your place.";
		
		name 	[10, 3] = "Deep Sea King";
		details [10, 3] = "With the shiny purple pearl at the top, the Deep Sea King gives an under-the-sea vibes to every room it graces.";
		
		name 	[10, 4] = "Dark Steel";
		details [10, 4] = "The design makes the unit look like it is made from wood but it is actually made from steel. It’s very sturdy and heavy.";
	}

	public void setGasRange () {
		name 	[11, 0] = "GR3000";
		details [11, 0] = "Cooking was made easier with advanced burners with a stylish design. Very affordable and low-maintenance.";
		
		name 	[11, 1] = "Zampool Platinum Edition";
		details [11, 1] = "The Zampool Platinum Edition is proud to present the first ever multilayer oven for all your baking needs!";
		
		name 	[11, 2] = "ZR Stainless Steel Series";
		details [11, 2] = "Made from very heat resistant steel. You will never burn your hands again!";
		
		name 	[11, 3] = "Flamie-yo Modern Design";
		details [11, 3] = "Features triple burners specially designed for fast and efficient cooks. Save time and serve hungry customers fast!";
		
		name 	[11, 4] = "Supra Jet-Black Collection ";
		details [11, 4] = "Futuristic gas range with digital oven and burner controls. We serve only the best for you!";
	}
}
