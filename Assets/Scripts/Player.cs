using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {



	void Start () {
	
	}
	
	void Update () {

        PlayerMove();
	
	}

    public void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.A)&&transform.position.x>0)
        {
            gameObject.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S)&& transform.position.z>0)
        {
            gameObject.transform.Translate(0, 0, -1);
        }

    }
}
