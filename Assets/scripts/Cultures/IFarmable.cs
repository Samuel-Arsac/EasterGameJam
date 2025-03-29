using System;
using Unity.VisualScripting;
using UnityEngine;

public interface IFarmable
{ 
    public string getType();
    public int getState();

    public int getLevel();
    public int getCollectNumber();

    public void upgrade();
    public int collect();
}
