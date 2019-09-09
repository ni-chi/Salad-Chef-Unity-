using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    [SerializeField] public float speed;
    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;
    public KeyCode PickKey = KeyCode.LeftShift;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(LeftKey)) transform.Translate(-1*speed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(RightKey)) transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(UpKey)) transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (Input.GetKey(DownKey)) transform.Translate(0f, -1 * speed * Time.deltaTime, 0f);
        //if (Input.GetKey(KeyCode.LeftShift)) playerOneTryingToInteract = true;

        //if (Input.GetKey(KeyCode.LeftArrow)) playerTwoDirection.x -= 1;
        //if (Input.GetKey(KeyCode.RightArrow)) playerTwoDirection.x += 1;
        //if (Input.GetKey(KeyCode.UpArrow)) playerTwoDirection.y += 1;
        //if (Input.GetKey(KeyCode.DownArrow)) playerTwoDirection.y -= 1;
        //if (Input.GetKey(KeyCode.RightShift)) playerTwoTryingToInteract = true;

    }
}
