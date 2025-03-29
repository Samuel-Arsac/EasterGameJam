using System;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using Math.round;

public class Champ : MonoBehaviour
{
    private const int MAX_CULTURE = 25;
    private int cost;
    private int number = 0;
    private int upgradePointer = 0;
    private IFarmable[] cultures = new IFarmable[25];
    private IFarmable cultureTester;


    /*
     * method name: addCulture
     * param: IFarmable culture
     * return: void
     * 
     * Add culture to a Champ, if the max number of culture is already there,
     * upgrade the first upgradable culture in the list.
     * 
     * Called when the player want to add a new culture to his champ.
     */
    public void AddCulture(IFarmable culture)
    { 
        if (cultureTester.getType() != culture.getType()){
            Debug.Log("Warning: Try to add wrong culture type " + culture.getType() + " to the Champs of type : " + cultureTester.getType());
            return;
        }
        if (number < MAX_CULTURE){
            cultures[number] = culture;
            number++;
        }else{
			cultures[upgradePointer].upgrade();
            upgradePointer = (upgradePointer + 1)%MAX_CULTURE;
        }
		cost = Math.Round(cost*1.25);
    }
	
	public bool isFull(){
		return number == MAX_CULTURE;
	}

    void Start(IFarmable tester)
    {
		this.cultureTester = tester;
    }

    void Update(){
        
    }
}
