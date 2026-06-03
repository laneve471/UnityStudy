using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch13TestCollider : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color hitColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D PlayerHead)
    {
        /*if (PlayerHead.CompareTag("PlayerHead"))
        {
            //if 
        }   */
    }
}
