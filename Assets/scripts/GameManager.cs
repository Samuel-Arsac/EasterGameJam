using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Singleton:Profile

    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    #endregion
}
