using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using pocos;
using UnityEngine.UI;
using UnityEngine.Networking;

public class get_JSON : MonoBehaviour
{
    public Button btn_upperLeft;
    public Text name;
    public User user;
    private String resource;
    public String uri;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            resource = "smirand6@asu.edu";
            uri = "localhost:5000/getUser/" + resource;

            var request = UnityWebRequest.Get(uri);
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");
            StartCoroutine(onGetResponse(request));
        }
        catch (Exception e) { Debug.Log("ERROR : " + e.Message); }
    }
    private IEnumerator onGetResponse(UnityWebRequest req)
    {

        yield return req.SendWebRequest();
        if (req.isError)
            Debug.Log("Network error has occured: " + req.GetResponseHeader(""));
        else
            Debug.Log("Success " + req.downloadHandler.text);
        byte[] results = req.downloadHandler.data;
        Debug.Log("Second Success");
        // Some code after success
        string result = System.Text.Encoding.UTF8.GetString(results);
        Debug.Log("get result: " + result);

        //creating poco
        User user = JsonUtility.FromJson<User>(result);

        Debug.Log("Using poco: " + user.Name);
        Debug.Log("Using poco: " + user.Favorite_Hobby);

    }
}
