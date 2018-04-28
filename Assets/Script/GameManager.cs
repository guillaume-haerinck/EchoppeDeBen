using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; //Static instance of GameManager which allows it to be accessed by any other script.
    public GameObject progressionBar;

    public Sprite defaut;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;

    private SpriteRenderer render;
    private int enigmaResolved = 0;

    //Awake is always called before any Start functions
    private void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }

        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        render = progressionBar.GetComponent<SpriteRenderer>();
        render.sprite = defaut;
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void EnigmaResolved()
    {
        // Debug.Log("Game manager, 1 enigme en plus résolue");
        enigmaResolved++;
        Debug.Log("Total enigme résolue : " + enigmaResolved);
        
        switch (enigmaResolved)
        {
            case 1:
                render.sprite = one;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                break;

            case 2:
                render.sprite = two;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                break;

            case 3:
                render.sprite = three;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                break;

            case 4:
                render.sprite = four;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                break;

            case 5:
                render.sprite = five;
				FindObjectOfType<AudioManager> ().Play ("LightOn");    
				break;

            case 6:
                render.sprite = six;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                SceneManager.LoadScene("Ending");
                break;

            case 7:
                render.sprite = seven;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                SceneManager.LoadScene("Ending");
                break;

            default:
                render.sprite = defaut;
				FindObjectOfType<AudioManager> ().Play ("LightOn");
                break;
        }
    }
}
