using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Champ : MonoBehaviour
{
    private const int MAX_CULTURE = 25;
    private int cost;
    private int number = 0;
    private int upgradePointer = 0;
    private ICulture[] cultures = new ICulture[25];
    private ICulture cultureTester;


    /*
     * method name: addCulture
     * param: Culture culture
     * return: void
     * 
     * Add culture to a Champ, if the max number of culture is already there,
     * upgrade the first upgradable culture in the list.
     * 
     * Called when the player want to add a new culture to his champ.
     */
    public void AddCulture(ICulture culture)
    { 
        if (cultureTester.getType() != culture.getType()){
            Debug.Log("Warning: Try to add wrong culture type " + culture.getType() + " to the Champs of type : " + cultureTester.getType());
            return;
        }
        if (number < MAX_CULTURE){
            cultures[number] = culture;
            number++;
        }else{ //TODO: Uncomment the line when method "upgrade()" is implemented in the Culture class.
            //cultures[upgradePointer].upgrade();
            upgradePointer = (upgradePointer + 1)%MAX_CULTURE;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
