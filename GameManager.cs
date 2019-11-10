using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject HintMenu;
    public Button HintMenuButton;
    public Button CloseMenuButton;



    void Start(){
        Button btn = HintMenuButton.GetComponent<Button>();
        Button btn2 = CloseMenuButton.GetComponent<Button>();
        HintMenuButton.onClick.AddListener(OpenMenu);
        CloseMenuButton.onClick.AddListener(CloseMenu);
    }

    void OpenMenu(){
        
        HintMenu.gameObject.SetActive(true);
        HintMenuButton.gameObject.SetActive(false);
        CloseMenuButton.gameObject.SetActive(true);
    }
    void CloseMenu() {
        HintMenu.gameObject.SetActive(false);
        HintMenuButton.gameObject.SetActive(true);
        CloseMenuButton.gameObject.SetActive(false);
    }

}
