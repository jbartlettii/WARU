using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string Scene; 
    public void GotoDemo() {
        SceneManager.LoadScene("Vuforia");
    }
    public void goToUserForm() {
        SceneManager.LoadScene("UserForm");
    }
}
