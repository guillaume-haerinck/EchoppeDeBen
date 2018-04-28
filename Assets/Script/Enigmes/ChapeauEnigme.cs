using UnityEngine;
using System.Collections;


// To use on the porte manteaux

public class ChapeauEnigme : MonoBehaviour
{
    SpriteRenderer render;

    public Sprite one;
    public Sprite two;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        render.sprite = one;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PorteManteau")
        {
            render.sprite = two;
            Destroy(other.gameObject);
            Debug.Log("Enigme porte menteau réussie");
			FindObjectOfType<AudioManager>().Play("Ok1");
            GameManager.instance.EnigmaResolved();
        }
    }


}