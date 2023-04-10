using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public Image im1;
    public Image im2;
    public Image im3;
    public Count count;
    public Text text;
    public Menu menu;
    // Start is called before the first frame update
    void Start()
    {
       count.Score = 0;
       count.Health = 3;
        im1.enabled = false;
        im2.enabled = false;
        im3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"{count.Score}";
        if (count.Health == 2) im1.enabled = true;
        if (count.Health == 1) im2.enabled = true;
        if (count.Health == 0) im3.enabled = true;
        if (count.Health <= 0)
        {
            menu.Pause();
        }
    }
}
