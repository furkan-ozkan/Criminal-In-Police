using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static List<GameObject> saveItems = new List<GameObject>();
    //******************************** Tecnical ************************************
    public static bool onPause = false;
    public static GameObject nowLookingObject=null;
    public static Vector3 nowLookingPlace;
    public static GameObject lastLookingObject = null;
    public static GameObject holdingObject = null;
    public static bool handsFree = true;
    public static GameObject activeCustomer = null;
    //******************************** Tecnical ************************************

    //******************************** NEEDS ***************************************
    public static float health=100, hunger=100, water=100, money=100;
    public static float healthMax=100, hungerMax=100, waterMax=100;
    public static bool dead=false;
    //******************************** NEEDS ***************************************
    
    //******************************** Pays ****************************************
    public static int rent=500, bills=100;
    public static int mustPayRent = 0, mustPayBills = 0;
    //******************************** Pays ****************************************

    //******************************** Thrust **************************************
    public static bool gangGetInfo = false;
    public static float gangThrust = 50,gangThrustMax=100;
    public static float policeThrust = 50, policeThrustMax = 100;
    public static float customerHappines = 5, customerHappinesMax = 10;
    //******************************** Thrust **************************************

    //******************************** Time  and etc *******************************
    public static int day = 0;
    public static float hour=12;
    public static bool storeOpen=true;
    public static bool thrashChecking = false;
    //******************************** Time  and etc *******************************

    //******************************** Enemy Gangs *********************************
    public static int activeGangNumber = 0;
    public static float activeGangPower = 56, activeGangPowerMax = 100;
    public static float suspicionRate = 27, suspicionRateMax=100;
    //******************************** Enemy Gangs *********************************
}
