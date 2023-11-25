using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in X")]
    public float speedX;
    public int directionX;
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    public int directionY;
    private SpriteRenderer _compSpriteRenderer;
    void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") == true)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") == true)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        else 
        {
            directionX = 0;
        }
        if (Input.GetKey("w") == true)
        {
            directionY = 1;
            _compSpriteRenderer.flipY = true;
        }
        else if (Input.GetKey("s") == true)
        {
            directionY = -1;
            _compSpriteRenderer.flipY = false;
        }
        else
        {
            directionY = 0;
        }
        transform.position = new Vector2(transform.position.x + speedX * directionX * Time.deltaTime, transform.position.y + speedY * directionY * Time.deltaTime);
    }
}
