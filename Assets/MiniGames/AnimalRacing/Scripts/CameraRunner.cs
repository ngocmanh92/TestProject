using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunner : MonoBehaviour
{

    Transform player;
    float offSetX;

    void Start()
    {
        GameObject player_go = GameObject.FindGameObjectWithTag("Tho");

        if (player_go == null)
        {
            Debug.LogError("Couldn't find an object with tag 'Player'!");
        }
        else
		{
            player = player_go.transform;
            offSetX = transform.position.x - player.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
			if(player.position.x>(MyCameraController.instance.sizeOfCamera.x/2-2)){
				Vector3 pos = transform.position;
				pos.x = player.position.x;
				transform.position = pos;
			}  
        }
    }
}
