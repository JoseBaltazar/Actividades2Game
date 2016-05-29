using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int vol = 10;
    public AudioClip playerStep;
    public AudioClip lifeUp;
    public AudioClip lifeDown;
    public AudioClip die;
	public int lives;
    public GUIText livesText;


    private AudioSource source;
    



    void Start()
    {
        lives = 3;
        displayLives();
        source = GetComponent<AudioSource>();

        lives = 3;



    }

    void Update()
    {



        displayLives();

        if (lives <= 0) { 
        Debug.Log("GG");
        source.PlayOneShot(die, vol);
      }
        else
        {
            PlayerMove();
        }
    }

    public void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > 0)
        {
            gameObject.transform.Translate(-1, 0, 0);
            source.PlayOneShot(playerStep, vol);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(1, 0, 0);
            source.PlayOneShot(playerStep, vol);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
           
            gameObject.transform.Translate(0, 0, 1);
            source.PlayOneShot(playerStep, vol);
        }

        if (Input.GetKeyDown(KeyCode.S) && transform.position.z > 0)
        {

            gameObject.transform.Translate(0, 0, -1);
            source.PlayOneShot(playerStep, vol);
        }

    }

    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            source.PlayOneShot(lifeDown, vol);
            lives--;
        }
        if (other.gameObject.tag == "MasVida")
        {
            source.PlayOneShot(lifeUp, vol);
            lives++;
        }

		if (other.gameObject.tag == "Win")
		{
			lives = 3; 
		}

    }
    void displayLives()
    {
        livesText.text = "Lives: " + lives;
    }
}
