using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //transform.Translate(vector3.forward) = transform.Translate (0, 0, 1);
        //Time.deltaTime vas faire en sorte que ca soit plus par frame mais par sec donc si vector3.forward le vehicule avancera de 1m chaque seconde
        transform.Translate(Vector3.forward *Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
