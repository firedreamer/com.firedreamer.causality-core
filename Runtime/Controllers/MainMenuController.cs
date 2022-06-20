using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MainMenuController : MonoBehaviour
{
    private static MainMenuController instance;
    public static MainMenuController Instance { get => instance; }
    [SerializeField]
    private TMP_Text versionInfo;

    public void Init()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        versionInfo.text = GameController.Instance.GetActivePlatform() + Application.version;
    }
}
