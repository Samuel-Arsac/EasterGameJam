using System;
using Unity.VisualScripting;
using UnityEngine;

public interface ICulture
{ 
    public string getType();
    public int getState();

    public int getLevel();
    public int getCollectNumber();

    public void upgrade();
    public int collect();

}
