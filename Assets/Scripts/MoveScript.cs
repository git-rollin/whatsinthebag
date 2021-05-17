using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Mathf;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // private PlayerCharacterBase PlayerCharacterBase;
    // private void Awake(){
    //     PlayerCharacterBase = gameObject.getComponent<PlayerCharacterBase>();
    //     }

    //Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;
        Vector3 spot = transform.position;
        //Debug.Log(spot);
        if(Input.GetKeyDown(KeyCode.W)){
            if(spot.x>=0) moveX-=8;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            if(spot.z>=-18) moveZ-=12;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            if(spot.x<=0) moveX+=8;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(spot.z<=-18) moveZ+=12;
        }
        Vector3 movin = new Vector3(moveX, 0, moveZ);

        transform.position += movin;
    }
}
