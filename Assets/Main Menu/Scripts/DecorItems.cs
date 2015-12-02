using UnityEngine;
using System.Collections;

public class DecorItems : MonoBehaviour {
	public static string[] decors;
	public static string[] furnNames;
	// Use this for initialization
	void Start () {
		setDecors ();
		setFurnNames ();
	}

	public static void setDecors() {
		decors = new string[] {
			"wall_clock",  "moneybox",  "telephone",  "chandelier",  "icing_pipe",  "sun_ornament",  "radio",  "glass_container",
			
			"thermometer",  "bottle_stopper",  "hourglass",  "mirror",  "plate",  "samovar",  "wooden_fork",  "wooden_spoon",
			
			"measuring_glass",  "teapot",  "vase",  "cupcake_cases",  "muffin_tray",  "spatula",  "mittens",  "whisk",
			
			"pear_shaped_pot",  "tureen",  "kettle",  "beating_bowl",  "pastry_brush",  "blackboard_sign",  "chalk_bucket",
			
			"pastry_cutter",  "utensil_jar",  "flower_mug",  "faucet",  "honey_jar",  "pie_pans",
			
			"weighing_scale",  "mini_ferris_wheel",  "rolling_pin",  "measuring_spoons",  "coffee_mill",  "grater",  "measuring_cups",
			
			"squeezer",  "cookie_jar",  "mixer",  "cake_stand",  "tea_cups",  "perfume_bottle",  "pitcher",  "sugar_bowl",
			
			"blender",  "basket",  "sifter",  "kerosene_lamp",  "cookie_cutter", "palette_knife", "bench_scraper", "bell"
		};
	}

	public static void setFurnNames () {
		furnNames = new string[12];
		furnNames[0] = "drawer";
		furnNames [1] = "sideTable";
		furnNames [2] = "floorLamp";
		furnNames [3] = "floor";
		furnNames [4] = "portrait";
		furnNames [5] = "landscape";
		furnNames [6] = "gasRange";
		furnNames [7] = "shelf";
		furnNames [8] = "frontTable";
		furnNames [9] = "kitchenTable";
		furnNames [10] = "wallpaper";
		furnNames[11] = "window";
	}
}
