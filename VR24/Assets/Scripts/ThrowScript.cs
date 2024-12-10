using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowScript : MonoBehaviour
{
    public int z;
    public int y;
    public int c;
    public int g;
    public Text Mytxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mytxt.text = g.ToString();
    }

    public void fisrt()
    {
        g = g + 2;
    }

    public void second()
    {
        g--;
    }

    public void nul()
    {
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y, (byte)c, 1);
    }
}
