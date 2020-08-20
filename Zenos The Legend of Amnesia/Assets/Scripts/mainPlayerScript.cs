using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayerScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 20 ,0,Input.GetAxis("Vertical") * Time.deltaTime * 20);
    }

}
