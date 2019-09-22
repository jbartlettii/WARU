using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class main_btn_handler : MonoBehaviour
{
    public void onClick() {
        SceneManager.LoadScene("Screen_Scanner");
    }
}
