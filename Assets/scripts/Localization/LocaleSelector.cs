using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using JetBrains.Annotations;

public class LocaleSelector : MonoBehaviour
{
    private void Start()
    {
        int ID = PlayerPrefs.GetInt("play", 0);
    }
    private bool active = false;
    public void ChangeLocal(int localeID)
    {
        if (active)
            return;
        StartCoroutine(SetLocal(localeID));
    }

    IEnumerator SetLocal(int _localeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        PlayerPrefs.SetInt("play", _localeID);
        active = false;
    }
}
