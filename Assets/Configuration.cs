using UnityEngine;
using YVR.Core;

public class Configuration : MonoBehaviour
{
    private void Start() { YVRManager.instance.cameraRenderer.displayFrequency = 72.0f; }
}