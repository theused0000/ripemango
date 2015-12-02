/// <summary>
/// Decors db.cs
/// This is the decorative items database, objects and trivias
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DecorsDb : MonoBehaviour 
{
	// Array of decorative items
	public static List<GameObject> decorItems;
	// Title and trivia string variables
	public static string currentInfo;
	public static string currentTitle;
	private int newShop;
	// Use this for initialization
	void Start () {
		// Array List declaration
		decorItems = new List<GameObject>();
		// Loop to get all decorative items and save them in array
		// Can be optimized by one line code such as used in GameStart.cs
		getDecors ();
	}
	public void getDecors()
	{
		for(int x = 0; x < GameManager.allDecors.Length; x++)
		{
			// Add gameobject to array object clues through clue names
			decorItems.Add(GameObject.Find(GameManager.allDecors[x]));
			// Hide decors
			if(PlayerPrefs.GetInt(GameManager.allDecors[x]+""+GameManager.num+Bakeshop.shop) == 0)
			{
				decorItems[x].SetActive(false);
			}
		}
	}
	public static void setDecors()
	{
		for(int x = 0; x < GameManager.allDecors.Length; x++)
		{
			// Hide decors
			if(PlayerPrefs.GetInt(GameManager.allDecors[x]+""+GameManager.num+Bakeshop.shop) == 0)
			{
				decorItems[x].SetActive(false);
			} else {
				decorItems[x].SetActive(true);
			}
		}
	}

	// Database of Trivia and Title
	public static void setTrivia()
	{
		if(DecorHit.currentDecor == "wall_clock") {
			currentTitle = "Ancient Wall Clock";
			currentInfo = "Cuckoo! Cuckoo! A working ancient wall clock that goes cuckoo! Every 6th hour! Wait… shouldn’t it be a cuckoo clock instead?";
		}
		else if(DecorHit.currentDecor == "honey_jar") {
			currentTitle = "Legendary Honey Jar";
			currentInfo = "The jar of honey that the best baker uses for their special honey glazed donuts. Where they come from, remain a mystery until today.";
		}
		else if(DecorHit.currentDecor == "faucet") {
			currentTitle = "Bronze Faucet";
			currentInfo = "Its unique design brings elegance to the workplace. Always check if there is a leak to conserve water!";
		}
		else if(DecorHit.currentDecor == "flower_mug") {
			currentTitle = "Flower Mug";
			currentInfo = "One of the shop’s exclusive items! It may be requested with a fresh bouquet or plastic flowers depending on the occasion!";
		}
		else if(DecorHit.currentDecor == "moneybox") {
			currentTitle = "Money Box";
			currentInfo = "Save funds and keep it secured in a trusted moneybox. Remember the saying: the art is not in making money, but in keeping it.";
		}
		else if(DecorHit.currentDecor == "pastry_cutter") {
			currentTitle = "Pastry Cutter";
			currentInfo = "A handheld kitchen tool used in slicing hard ingredients like butter to incorporate in the dough.";
		}
		else if(DecorHit.currentDecor == "blackboard_sign") {
			currentTitle = "Blackboard Sign";
			currentInfo = "It contains all the daily specials and different information such as free coffee hours!";
		}
		else if(DecorHit.currentDecor == "pastry_brush") {
			currentTitle = "Pastry Brush";
			currentInfo = "It is often used in glazing pastry and baked goods with egg wash or icing.";
		}
		else if(DecorHit.currentDecor == "pear_shaped_pot") {
			currentTitle = "Pear-shaped Pot";
			currentInfo = "An imitation of a popular artwork from a foreign museum, this was actually made into a bread!";
		}
		else if(DecorHit.currentDecor == "beating_bowl") {
			currentTitle = "Bronze Mixing Bowl ";
			currentInfo = "A handy bronze ceramic bowl used to mix ingredients for baking.";
		}
		else if(DecorHit.currentDecor == "tureen") {
			currentTitle = "Tureen";
			currentInfo = "A special bowl for soup given by the master baker’s daughter who lives in France. It could make the legendary stews like the best mushroom stew in town!";
		}
		else if(DecorHit.currentDecor == "whisk") {
			currentTitle = "Whisk";
			currentInfo = "The cheapest whisk that I have ever bought. They are also the sturdiest. It is said to give more flavor into the baked pastry!";
		}
		else if(DecorHit.currentDecor == "mittens") {
			currentTitle = "Mittens";
			currentInfo = "The warmest of mittens. It is said to reduce the warmth from the surface, making it a perfect glove for baking!";
		}
		else if(DecorHit.currentDecor == "kettle") {
			currentTitle = "Golden Kettle";
			currentInfo = "A golden kettle that is said to produce the best of tea from fresh leaves. It is said that it could make a great blend even if only an extract were put in it together with water.";
		}
		else if(DecorHit.currentDecor == "spatula") {
			currentTitle = "Pink Spatula";
			currentInfo = "Baking spatula is used for frosting cakes and spreading toppings on the surface of the pastries and baked goods.";
		}
		else if(DecorHit.currentDecor == "muffin_tray") {
			currentTitle = "Special Muffin Tin";
			currentInfo = "A unique muffin tin made out of cast iron. It is said to shorten the baking time by half!";
		}
		else if(DecorHit.currentDecor == "vase") {
			currentTitle = "Vase";
			currentInfo = "A regular vase. It’s nice to have something regular in the shop every now and then.";
		}
		else if(DecorHit.currentDecor == "teapot") {
			currentTitle = "Flower designed Teapot";
			currentInfo = "A ceramic container perfect for freshly made tea.";
		}
		else if(DecorHit.currentDecor == "chalk_bucket") {
			currentTitle = "Chalk Bucket";
			currentInfo = "A bucket filled with colorful chalk. These are often used to change the “Today’s Menu!” Make good use of it!";
		}
		else if(DecorHit.currentDecor == "measuring_glass") {
			currentTitle = "Glass Measuring Cup";
			currentInfo = "In this time and age it’s not often you see glass measuring cups, for most already resorted to using plastic and wooden ones to avoid breaking them. Becareful! Don’t drop it!";
		}
		else if(DecorHit.currentDecor == "wooden_spoon") {
			currentTitle = "Wooden Spoon";
			currentInfo = "A wooden measuring spoon. Often used to mix the hot mixture for cakes, together with the fork!";
		}
		else if(DecorHit.currentDecor == "wooden_fork") {
			currentTitle = "Wooden Fork";
			currentInfo = "A fork made of wood. Wooden utensils prevent scratches on your cookware.";
		}
		else if(DecorHit.currentDecor == "plate") {
			currentTitle = "Flower designed Plate";
			currentInfo = "A great plate to pair with the Flower Teapot. However, this does not have a rumor about cheering up anyone who eats from it? I wonder if it was just a joke.";
		}
		else if(DecorHit.currentDecor == "mirror") {
			currentTitle = "Pink Porcelain Mirror";
			currentInfo = "Gotta still look good during work hours, let’s keep this. A presentable appearance is a must in running any shop.";
		}
		else if(DecorHit.currentDecor == "hourglass") {
			currentTitle = "Wooden Hourglass";
			currentInfo = "This won’t actually help us but it makes a good design to the bakeshop. It somehow brings magical and classic feels.";
		}
		else if(DecorHit.currentDecor == "bottle_stopper") {
			currentTitle = "Stopper";
			currentInfo = "Used as a bottle cover, this will come in handy for preserving our extracts in a bottle.";
		}
		else if(DecorHit.currentDecor == "thermometer") {
			currentTitle = "Boiler Thermometer";
			currentInfo = "A device used to measure the temperature. It is vital to check the room temperature in every bakeshop to avoid molds from bread or accidents.";
		}
		else if(DecorHit.currentDecor == "glass_container") {
			currentTitle = "Red and Yellow Candle Container";
			currentInfo = "A candle container for special occasions! It is said that the colors yellow and red are the appetizing colors. Putting these in display may make our customers eat more. ";
		}
		else if(DecorHit.currentDecor == "radio") {
			currentTitle = "Pink Radio";
			currentInfo = "A cute and colorful pink radio! Although it doesn’t work, it’s a great design for the kids! ";
		}
		else if(DecorHit.currentDecor == "sun_ornament") {
			currentTitle = "Sun Ornament";
			currentInfo = "A sun ornament! It’s apparently good luck if you put anything sun related to a newly-opened shop!";
		}
		else if(DecorHit.currentDecor == "icing_pipe") {
			currentTitle = "Icing Syringe";
			currentInfo = "An icing syringe is often used for finer details to be put on cake such as names and smaller flowers.";
		}
		else if(DecorHit.currentDecor == "chandelier") {
			currentTitle = "Chandelier";
			currentInfo = "Stylish and elegant. A nice and cool lighting is needed in every bakeshop.";
		}
		else if(DecorHit.currentDecor == "telephone") {
			currentTitle = "Ancient Phone";
			currentInfo = "A telephone with an old design, although it has the dial design, it works as well as a new, electronic phone. ";
		}
		else if(DecorHit.currentDecor == "utensil_jar") {
			currentTitle = "Utensil Jar";
			currentInfo = "An important jar with different utensils inside, it would help everyone know where to put back the items after using it.";
		}
		else if(DecorHit.currentDecor == "pie_pans") {
			currentTitle = "Pie Dishes";
			currentInfo = "One of the many types of pie dishes, most bakers use ceramic, however stainless is often highly recommended due to its durability and usefulness.";
		}
		else if(DecorHit.currentDecor == "weighing_scale") {
			currentTitle = "Weighing Scale";
			currentInfo = "This is used to measure the amount of ingredients in baking. Remember, the taste of food depends on the right amount of ingredients!";
		}
		else if(DecorHit.currentDecor == "mini_ferris_wheel") {
			currentTitle = "Mini Ferris Wheel";
			currentInfo = "Limited edition miniature collection of the town’s most famous landmark, The Ferris Wheel.";
		}
		else if(DecorHit.currentDecor == "rolling_pin") {
			currentTitle = "Wooden Rolling Pin";
			currentInfo = "A Rolling pin made out of wood. Using a wooden rolling pin makes it easier to make bread and pizza dough without the mixture sticking to the surface or the pin itself, compared to metallic ones.  ";
		}
		else if(DecorHit.currentDecor == "measuring_spoons") {
			currentTitle = "Bronze Measure Spoons";
			currentInfo = "An extremely lucky set of measuring spoons. These precisely measure each teaspoon and tablespoon very accurately to a T.";
		}
		else if(DecorHit.currentDecor == "coffee_mill") {
			currentTitle = "Coffee Mill";
			currentInfo = "Manual grinders produce less heat during the grinding process compared to electrical grinders, which is best for keeping the aroma and flavour of coffee beans.";
		}
		else if(DecorHit.currentDecor == "vintage_grater") {
			currentTitle = "Vintage Grater";
			currentInfo = "An old model cheese grater. It is said that the use of cheese grater dates back to 1540s. Apparently, this seems unusable, but we can use it as a decoration.";
		}
		else if(DecorHit.currentDecor == "measuring_cups") {
			currentTitle = "Rubberized Measuring Cups";
			currentInfo = "A safer set of measuring cups. Most people are afraid to use rubberized measuring cups due to the fright of them melting inside the oven. However, they are made with unique rubberized material, to be able to use them as a baking tool. ";
		}
		else if(DecorHit.currentDecor == "squeezer") {
			currentTitle = "Fruit Squeezer";
			currentInfo = "This is usually accompanied with juicers, however in order to get a fresh extract, the fruits must be freshly squeezed into the dough. And that is where this very handy item comes into.";
		}
		else if(DecorHit.currentDecor == "cookie_jar") {
			currentTitle = "Cookie Jar";
			currentInfo = "The famous cookie! It has been really popular with the children lately. It is also good for quick fixes while waiting for freshly baked bread! ";
		}
		else if(DecorHit.currentDecor == "cake_stand") {
			currentTitle = "Cake Stand";
			currentInfo = "A stainless cake stand often used for special occasions. ";
		}
		else if(DecorHit.currentDecor == "mixer") {
			currentTitle = "Mixer";
			currentInfo = "The tool often used to quickly mix the ingredients and achieve the perfect texture for your pastry. ";
		}
		else if(DecorHit.currentDecor == "tea_cups") {
			currentTitle = "Flower designed teacups ";
			currentInfo = "A perfect pair for the flower designed teapot.";
		}
		else if(DecorHit.currentDecor == "perfume_bottle") {
			currentTitle = "Perfume Bottle ";
			currentInfo = "A great shop design to go with the whole bakeshop’s look, and also with just one spray, the air turns into this nice lemony citrus scent!";
		}
		else if(DecorHit.currentDecor == "pitcher") {
			currentTitle = "Thin Neck Pitcher";
			currentInfo = "A unique collectible thin necked pitcher. It is often used to amicably pour liquid into an even thinner glass to avoid spills. ";
		}
		else if(DecorHit.currentDecor == "sugar_bowl") {
			currentTitle = "Sugar Dispenser";
			currentInfo = "A small container that has almost a hundred sugar cubes. They sometimes call it the “magic container” for it seems like it dispenses unlimited sugar.";
		}
		else if(DecorHit.currentDecor == "blender") {
			currentTitle = "Blender";
			currentInfo = "An electric appliance for grinding and mixing food. It can be used to make fruit juices and smoothies for customers!";
		}
		else if(DecorHit.currentDecor == "basket") {
			currentTitle = "Basket";
			currentInfo = "A hand-woven container made from the finest wicker material. It is often used in serving freshly baked bread.";
		}
		else if(DecorHit.currentDecor == "sifter") {
			currentTitle = "Sifter";
			currentInfo = "A tool used to separate thin, grated powder from clumps of powder. This is often used for separating solid from solid. A strainer is a kind of sifter that separates solids from liquid.";
		}
		else if(DecorHit.currentDecor == "samovar") {
			currentTitle = "Samovar";
			currentInfo = "A traditional heater and boiler originating from Russia. It makes heating and boiling around the bakeshop easier and faster, with no hands! ";
		}
		else if(DecorHit.currentDecor == "kerosene_lamp") {
			currentTitle = "Kerosene Lamp";
			currentInfo = "For emergency use only. We wouldn’t know when we will run out of power, so better be prepared with a kerosene lamp.";
		}
		else if(DecorHit.currentDecor == "cookie_cutter") {
			currentTitle = "Cookie Cutter";
			currentInfo = "Metal cutters often used to create fun biscuit shapes. Often comes with different sizes and shapes.";
		}
		else if(DecorHit.currentDecor == "palette_knife") {
			currentTitle = "Palette Knife";
			currentInfo = "A wide, flat knife with a rounded tip mainly used for smoothing substances like frosting on a cake.";
		}
		else if(DecorHit.currentDecor == "bench_scraper") {
			currentTitle = "Bench Scraper";
			currentInfo = "The bench scraper is either a metal or plastic rectangular tool used to scrape sticky dough or a pile of flour. It makes cleaning up a lot easier.";
		}
		else if(DecorHit.currentDecor == "bell") {
			currentTitle = "Bell";
			currentInfo = "Bells are also associated with clocks, indicating the hour by ringing.";
		}
	}

}
