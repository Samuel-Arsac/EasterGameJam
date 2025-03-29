using System;
using UnityEngine;

public class Pomme : MonoBehaviour, IFarmable
{
    public GameObject pomme;
    private const string TYPE = "pomme";
    private int state;
    private int level;
    private int collectNumber;
    private const double growTime = 5;
    private double timer;

    public string getType()
    {
        return TYPE;
    }

    public int getState()
    {
        return state;
    }

    public void upgrade()
    {
        return;
    }

    public int collect()
    {
        state = 0;
        timer = 0;
        return collectNumber;
    }

    public int getCollectNumber()
    {
        return collectNumber;
    }

    public int getLevel()
    {
        return level;
    }

    public Pomme(int st, int lv)
    {
        state = st;
        level = lv;
          
        //Calcul of the timer
        if (state != 2)
        {
            if (state == 0)
                timer = (double)0;
            else
                timer = growTime / 2;
        }

        //Calcul of the collectNumber
        collectNumber = (int)Math.Ceiling(Math.Pow(level, 2));
    }

    // Update is called once per frame
    void Update()
    {
        if (state != 2)
        {
            timer += Time.deltaTime;

            if (timer >= growTime && state == 1)
                state = 2;

            if (timer >= (growTime / 2) && state == 0)
                state = 1;
        }
    }
}
