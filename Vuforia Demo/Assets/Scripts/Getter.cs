using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Getter : MonoBehaviour
{
    public string host = "nothing";
    public string datasetURL = "";
    public static DatasetNames datasetNames;

    public string email;
    public string hobby;
    public string major;
    public string name;
    public string nametag;
    public string superpower;

    // Start is called before the first frame update
    void Start()
    {
        email = "";
        hobby = "";
        major = "";
        name = "";
        nametag = "";
        superpower = "";
    }
    


}
[System.Serializable]
public class DatasetNames
{
    public string email;
    public string hobby;
    public string major;
    public string name;
    public string nametag;
    public string superpower;
}
