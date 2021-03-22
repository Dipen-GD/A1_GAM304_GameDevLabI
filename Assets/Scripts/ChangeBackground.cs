using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeBackground : MonoBehaviour
{
    
    public Renderer groundRenderer;
    public Material mat;
    float h, s, v;
   

    private void Start()
    {
        
        groundRenderer = GetComponent<Renderer>();
       
    }

    public void Change(float _amount)
    {
        
        Color.RGBToHSV(mat.color, out h, out s, out v);
        mat.color = Color.HSVToRGB(h, s, v + _amount);

    }

   

   
    
}
