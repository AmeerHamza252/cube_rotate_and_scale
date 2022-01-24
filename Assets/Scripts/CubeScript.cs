using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private float turnspeed ;
    private float cubeSize ;


    // Start is called before the first frame update
    void Start()
    {
        cubeSize = 8.0f;
        turnspeed = 70.0f;
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Input.GetAxis("Vertical") * Time.deltaTime * turnspeed);
        transform.Rotate(Vector3.down * Input.GetAxis("Horizontal") * Time.deltaTime * turnspeed);
        var size = transform.localScale;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale + new Vector3(size.x * cubeSize * Time.deltaTime, size.y * cubeSize * Time.deltaTime, size.z * cubeSize * Time.deltaTime);
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale = transform.localScale - new Vector3(size.x * cubeSize * Time.deltaTime, size.y * cubeSize * Time.deltaTime, size.z * cubeSize * Time.deltaTime);
       }
       
    }
}
