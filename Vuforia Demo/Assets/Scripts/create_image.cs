using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create_image : MonoBehaviour
{
    private bool camAvailable;
    private WebCamTexture camera;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;
    // Start is called before the first frame update
    void Start()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0) {
            Debug.Log("No Camera");
            camAvailable = false;
            return;
        }
        for (int i = 0; i < devices.Length; i++) {
            if (!devices[i].isFrontFacing)
            {
                camera = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
           
        }
        if (camera == null) {
            Debug.Log("Unable to find backcamera");
        }
        camera.Play();
        background.texture = camera;

        camAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (camAvailable == false) {
            return;
        }

        float ratio = (float)(camera.width) / (float)camera.height;
        fit.aspectRatio = ratio;

        float scaleY = camera.videoVerticallyMirrored ? -1f: 1f;
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        int orient = -camera.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
    }
}
