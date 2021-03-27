using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeBackground : MonoBehaviour
{
    
    public Renderer groundRenderer;
    public Material mat;
    float h, s, v;
    public TMP_Text gameOverText;
    public spawning spawn;
   

    private void Start()
    {
        gameOverText.text = "";
        groundRenderer = GetComponent<Renderer>();
        Color.RGBToHSV(mat.color, out h, out s, out v);
        mat.color = Color.HSVToRGB(h, s, 0.5f);
    }

    public void Change(float _amount)
    {
        
        Color.RGBToHSV(mat.color, out h, out s, out v);
        mat.color = Color.HSVToRGB(h, s, v + _amount);
        Debug.Log(v + _amount);

        if (v + _amount >= 1)
        {
            gameOverText.text = "WINNER";
            gameOverText.color = Color.black;
            spawn.StopSpawning();

        }
        if (v + _amount <= 0)
        {
            gameOverText.text = "LOSER";
            gameOverText.color = Color.white;
            spawn.StopSpawning();

        }

    }

   

   
    
}
