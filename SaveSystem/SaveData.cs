using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public List<int> saveItemsId = new List<int>();
    public List<Vector3> saveItemsPos = new List<Vector3>();
    public List<Quaternion> saveItemsRot = new List<Quaternion>();
    //************************* NEEDS ****************************************
    public bool onPause = true;
    //************************* NEEDS ****************************************

    //************************* NEEDS ****************************************
    public int health = 100, hunger = 100, water = 100, money = 100;
    public int healthMax = 100, hungerMax = 100, waterMax = 100;
    //************************* NEEDS ***************************************

    //************************* Pays ****************************************
    public int rent = 500, bills = 100;
    //************************* Pays ****************************************

    //************************* Thrust **************************************
    public int gangThrust = 50, gangThrustMax = 100;
    public int policeThrust = 50, policeThrustMax = 100;
    public int customerHappines = 1, customerHappinesMax = 10;
    //************************* Thrust **************************************

    //************************* Time ****************************************
    public int day = 0;
    public float hour = 12;
    //************************* Time ****************************************

    //************************* Enemy Gangs *********************************
    public int activeGangNumber = 0;
    public int activeGangPower = 100, activeGangPowerMax = 100;
    public float suspicionRate = 0;
    //******************************** Enemy Gangs **************************
    public SaveData()
    {
        
    }
}
