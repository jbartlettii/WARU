using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openPanel : MonoBehaviour
{

    public Button button_test;
    public GameObject PanelOpener;

    // Start is called before the first frame update
    public void Start()
    {
        Button btn = button_test.GetComponent<Button>();
        GameObject pnl = PanelOpener.GetComponent<GameObject>();
        btn.onClick.AddListener(TaskOnClick);
        btn.onClick.AddListener(OpenPanel);
    }

    public void TaskOnClick()
    {
        name = button_test.name;
        Debug.Log("You have clicked the button!" + name);

    }

    public void OpenPanel()
    {

        if (PanelOpener != null)
        {
            bool isActive = PanelOpener.activeSelf;
            PanelOpener.SetActive(!isActive);
            Debug.Log("The Panel is now open!");
        }

        /*  PanelOpener.SetActive(true);
            Debug.Log("The Panel is now open!");
        }else {
            PanelOpener.SetActive(false);
            Debug.Log("The Panel was closed!");
        }*/
    }
}
