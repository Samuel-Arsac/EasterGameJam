using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;


public class UIManager : MonoBehaviour
{
    #region Singleton:Profile

    public static UIManager Instance;

    void Awake ()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy (gameObject);
    }
    #endregion

    [SerializeField] private GameObject shopMenu;
    [SerializeField] private Button shopButton;

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
