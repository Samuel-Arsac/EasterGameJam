using UnityEngine;

public  abstract class Structures : MonoBehaviour
{
    new string name; // Nom de la structure
    uint slots; // Nombre de slots maximums pour la structure
    uint freeSlots; // Nombre de slots disponnibles actuellement
    uint timer; // Timer depuis le d�but de la construction (plus utilis� et n'augmente plus apr�s la structure construite)
    uint time; // Temps requis pour la construction
    ulong cost; // Co�t pour pouvoir construire la structure
    ulong upgradeCost; // Co�t n�c�ssaire pour am�liorer la structure (pas utilis� pour le moment)
    //Recipes recipies[]; (pas impl�ment� pour l'instant)
    bool isFree = true;
    public Structures(string name, uint slots, uint time, ulong cost, ulong upgradeCost)
    {
        this.name = name;
        this.slots = slots;
        this.freeSlots = slots;
        this.time = time;
        this.cost = cost;
        this.upgradeCost = upgradeCost;
    }
    // bool createRecipe (Recipies recipe){ 
            // if (isFree() && recipie.canCreate()){
                 // this.freeSlots--;
                 // recipie.create;
                 // retur true;
           // } return false;
    // }

    public string getName()
    {
        return name;
    }

    public uint getSlots()
    {
        return slots;
    }

    public uint getFreeSlots()
    {
        return freeSlots;
    }

    public uint getTimer()
    {
        return timer;
    }

    public uint getTime()
    {
        return time;
    }

    public ulong getCost()
    {
        return cost;
    }

    public ulong getUpgradeCost()
    {
        return upgradeCost;
    }

    public bool getIsFree()
    {
        return isFree;
    }
    public void setSlots(uint slots)
    {
        this.slots = slots;
    }

    public void setUpgradeCost (ulong newCost){
        this.upgradeCost = newCost;
    }

    public void setIsFree(bool newFree)
    {
        this.isFree = newFree;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
