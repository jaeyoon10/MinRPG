using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject light;
    public MeshRenderer ground;
    public Color lightColor;

    

    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Rigidbody>().mass = 1000;
        cube.GetComponent<Rigidbody>().useGravity = false;

    }

    public void CubeOn()
    {
        cube.SetActive(true);
    }

    public void CubeOff()
    {
        cube.SetActive(false);
    }

    public void CubeColor()
    {
        light.GetComponent <Light>().color = lightColor;
    }
    public void GroundColor()
    {
        ground.material.color = Color.gray;
    }
}
