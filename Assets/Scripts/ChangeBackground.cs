using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public Renderer groundRenderer;
    public Material mat;

    public void Change(float _amount)
    {
        float h,s,v;
        Color.RGBToHSV(mat.color, out h, out s, out v);
        mat.color = Color.HSVToRGB(h, s, v + _amount);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //        Change(0.05f);

    //    if (Input.GetKeyDown(KeyCode.B))
    //        Change(-0.05f);
    //}
}
