using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;


public class UIManager : MonoBehaviour
{
    #region Singleton:Profile

    public static UIManager instance;

    void Awake ()
    {
        if (instance == null)
            instance = this;
        else
            Destroy (gameObject);
    }
    #endregion

    [SerializeField] private GameObject shopMenu;
    [SerializeField] private Button shopButton;
    [SerializeField] private GameObject[] purchasableItems;

    private void Start()
    {
        hideShop();
    }

    public void displayShop()
    {
        shopMenu.SetActive (true);
        shopButton.onClick.RemoveAllListeners();
        shopButton.onClick.AddListener(hideShop);
    }

    public void hideShop()
    {
        shopButton.onClick.RemoveAllListeners();
        shopButton.onClick.AddListener(displayShop);
        shopMenu.SetActive(false);
    }


}
