using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using pocos;
using UnityEngine.Networking;
using System;

public class userform_button : MonoBehaviour
{
    public InputField getName;
    public InputField getSuperPower;
    public InputField getMajor;
    public InputField getColor;
    public InputField getHobby;
    public InputField Email;


    public void onbtnclick()
    {
        User user =  new User(getName.text, Email.text, getColor.text, getSuperPower.text,getMajor.text,getHobby.text);
        try
        {
            string url = "http://whoaru-env.brurrpfnfu.us-east-2.elasticbeanstalk.com/addUser";

            string json = JsonUtility.ToJson(user);

            Debug.Log("payload: " + json);

            var request = UnityWebRequest.Put(url, json);
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");
            StartCoroutine(onResponse(request));
        }
        catch (Exception e) { Debug.Log("ERROR : " + e.Message); }
        SceneManager.LoadScene("Vuforia");
    }
    private IEnumerator onResponse(UnityWebRequest req)
    {
        yield return req.SendWebRequest();
        if (req.isNetworkError)
            Debug.Log("Network error has occured: " + req.GetResponseHeader(""));
        else
            Debug.Log("Success " + req.downloadHandler.text);
        byte[] results = req.downloadHandler.data;
        Debug.Log("Second Success");
        // Some code after success
        string result = System.Text.Encoding.UTF8.GetString(results);
        Debug.Log("post result: " + result);
    }
}
