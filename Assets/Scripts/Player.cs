using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer _spriteRenderer;
    public GameObject basket1;
    public GameObject basket2;
    public GameObject basket3;
    public GameObject basket4;
    // Start is called before the first frame update
    void Start()
    {
        basket1.SetActive(true);
        basket2.SetActive(false);
        basket3.SetActive(false);
        basket4.SetActive(false);
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            basket1.SetActive(true);
            basket2.SetActive(false);
            basket3.SetActive(false);
            basket4.SetActive(false);
            _spriteRenderer.sprite = sprite1;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            basket1.SetActive(false);
            basket2.SetActive(true);
            basket3.SetActive(false);
            basket4.SetActive(false);
            _spriteRenderer.sprite = sprite2;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            basket1.SetActive(false);
            basket2.SetActive(false);
            basket3.SetActive(true);
            basket4.SetActive(false);
            _spriteRenderer.sprite = sprite1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            basket1.SetActive(false);
            basket2.SetActive(false);
            basket3.SetActive(false);
            basket4.SetActive(true);
            _spriteRenderer.sprite = sprite2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _spriteRenderer.sprite = sprite2;
            basket1.SetActive(false);
            basket2.SetActive(true);
            basket3.SetActive(false);
            basket4.SetActive(false);
        }
        if ((_spriteRenderer.sprite == sprite2) && (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            basket1.SetActive(false);
            basket2.SetActive(true);
            basket3.SetActive(false);
            basket4.SetActive(false);
        }
        if ((_spriteRenderer.sprite == sprite2)&& (Input.GetKeyDown(KeyCode.DownArrow)))
            {
                basket1.SetActive(false);
                basket2.SetActive(false);
                basket3.SetActive(false);
                basket4.SetActive(true);
            }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _spriteRenderer.sprite = sprite1;
            basket1.SetActive(true);
            basket2.SetActive(false);
            basket3.SetActive(false);
            basket4.SetActive(false);
        }
        if ((_spriteRenderer.sprite == sprite1) && (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            basket1.SetActive(true);
            basket2.SetActive(false);
            basket3.SetActive(false);
            basket4.SetActive(false);
        }
        if ((_spriteRenderer.sprite == sprite1) && (Input.GetKeyDown(KeyCode.DownArrow)))
            {
                basket1.SetActive(false);
                basket2.SetActive(false);
                basket3.SetActive(true);
                basket4.SetActive(false);
            }
        }
    }


