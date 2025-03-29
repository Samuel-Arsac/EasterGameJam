using UnityEngine;

public class Ble : ICulture
{
    public GameObject ble;
    private string type;
    private int state;
    private int level;
    private int collectNumber;
    

    public string getType()
    {
        return type;
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
        return -1;
    }

    public int getCollectNumber()
    {
        return collectNumber;
    }

    public int getLevel()
    {
        return level;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
