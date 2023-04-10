using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createobj : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    private float random;
    private Vector2 coord;
    private float sp1 = 2f;
    private float sp2 = 0.0f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > sp2)
        {

            sp2 = Time.time + sp1;
            random = Random.Range(0, 4);
            switch(random)
            {
                case 0:
                    coord = new Vector2(-7.79f, 3.2f);
                    break;
                case 1:
                    coord = new Vector2(-7.87f, -0.24f);
                    break;
                case 2:
                    coord = new Vector2(7.93f, 3.48f);
                    break;
                case 3:
                    coord = new Vector2(7.93f, -0.5f);
                    break;
            }
            Instantiate(obj, coord, Quaternion.identity);
        }



    }


}



