using UnityEngine;
using System.Collections;

public class player_script : MonoBehaviour
{
	//MAIN MOVEMENTS
	public static string forward_keymain = "W";
	public static string left_keymain = "A";
	public static string right_keymain = "D";
	public static string back_keymain = "S";
	public static string forward_keyalt = "Up";
	public static string left_keyalt = "Left";
	public static string right_keyalt = "Right";
	public static string back_keyalt = "Back";
	//on reverse rotate camera a full 180 degrees to see objects behind. Enable reverse lights. Slow down vehicle.
	
	//SHIFTING CONTROLS
	public static string shiftup_keymain = "Left Shift";
	public static string shiftdown_keymain = "Left Control";
	public static string shiftup_keyalt = "Right Shift";
	public static string shiftdown_keyalt = "Right Control";
	
	//BRAKING CONTROLS
	public static string braking_keymain = "B";
	public static string breaking_keyalt = "Space";
	//enable taillights. Emergency braking. 
	
	//VEHICLE START
	public static string start_keymain = "E";
	
	//BLINKER CONTROLS
	//	public static string leftblinker_keymain = "[";
	//	public static string rightblinker_keymain = "]";
	//	public static string flashers_keymain = "F";
	
	//HORN CONTROLS
	public static string horn_keymain = "H";
	
	//CAMERA CONTROLS
	public static string camera_keymain = "c";
	
	//CURRENT GEAR THAT CAR IS IN
	public static string gear_string;
	
	//CAR IS ON ELSE OFF
	public static bool isRunning;
	
	//GEARS
	public static bool isManual;
	public static bool gear1;
	public static bool gear2;
	public static bool gear3;
	public static bool gear4;
	public static bool gear5;
	public static bool neutral;
	public static bool reverse;
	
 	//CONDITION COUNTERS
	public int condition_engine = 100;//IF = 0, CAR WILL NOT MOVE.GAME OVER
	public int condition_transmission = 100;//IF = 0, CAR WILL NOT MOVE.GAME OVER.REDUCE HEALTH ON HEAVY HITS
	public int condition_clutch = 100;//IF MANUAL = TRUE && ON POOR SHIFT REDUCE HEALTH.IF = 0, GAME OVER
	
	//IF ANY OF THE TIRES REACHES 0, JUST MAKE CONTROLS DIFFICULT. IF ALL TIRES = 0,SLOW SPEED AND MAKE CONTROLS DIFFICULT
	public int condition_tire1 = 100;
	public int condition_tire2 = 100;
	public int condition_tire3 = 100;
	public int condition_tire4 = 100;
	
	//LIQUIDS
	public int ammount_gas = 100;//IF = 0, GAME OVER UNLESS DURING RACE. RACE WILL ALLOW REFUEL
	public int ammount_oil = 100;//IF = 0, GAME OVER. 
	
	//COUNTER FOR REVS AND SPEED
	public int counter_speed = 0;//OVERALL SPEED OF VEHICLE
	public int counter_revs = 0;//NOTHING SPECIAL. IF > X, REDUCE ENGINE HEALTH. 
	
	//GAMEOBJECTS-LIGHTS-
	public GameObject headlights;
	public GameObject taillights;
	
	//CAMERAS
	public Camera main;
	//IN CAR CAM?
	//HOOD CAM?
	//ROOF CAM?
	//FRONT GROUND CAM?


	//Use this for initialization
	void Start ()
	{
		isRunning = false;
		isManual = true;
		gear1 = true;
		gear2 = false;
		gear3 = false;
		gear4 = false;
		gear5 = false;
		neutral = false;
		reverse = false;
		headlights.light.enabled = false;
		taillights.light.enabled = false;
	}
	
	void gearup ()
	{
		
	}
	
	void damager ()
	{
		//collides with front. remove hood. engine damage causes oil to leak. no oil causes quicker death.
		//collides with left_side. remove doors
		//collides with right side.remove doors
		//collides with rear.remove trunk
		//upside down.create boolean for upside damagers.
		//If upside damage until it blows up or automatically flips over to prevent damage
	}
	
	void geardown ()
	{
		
	}
	
	void manualshift ()
	{
		
	}
	
	void automaticshift ()
	{
		
	}

	void playercontrols ()
	{
		if (Input.GetKey (forward_keymain) || Input.GetKey (forward_keyalt)) {//FORWARD	
			
		}
		
		if (Input.GetKey (left_keymain) || Input.GetKey (left_keyalt)) {//LEFT	
			
		}
		
		if (Input.GetKey (right_keymain) || Input.GetKey (right_keyalt)) {//RIGHT	
			
		}
		
		if (Input.GetKey (back_keymain) || Input.GetKey (back_keyalt)) {//BACK	
			
		}
		
		if (Input.GetKey (shiftup_keymain) || Input.GetKey (shiftup_keyalt)) {//SHIFT UP
			
		}
		
		if (Input.GetKey (shiftdown_keymain) || Input.GetKey (shiftdown_keyalt)) {//SHIFT DOWN	
			
		}
		
		if (Input.GetKey (braking_keymain)) {//EMERGENCY BRAKING	
			
		}
		
		if (Input.GetKey (horn_keymain)) {//HORN
			
		}
		
		if (Input.GetKey (camera_keymain)) {//CAMERA
			
		}
		
		if (isRunning == false && Input.GetKey (start_keymain)) {//RUNNING	
			isRunning = true;
		}else{
			return;//CAR IS ALREADY RUNNING.
		}
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
