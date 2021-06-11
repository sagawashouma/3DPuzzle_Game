using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cube : MonoBehaviour
{
    
    Vector3 Player_position;
  
    public GameObject UnityChan;
    bool isstop = false;
    public GameObject BoxSmall;




    // Start is called before the first frame update
    void Start()
    {
       
        /*Vector3 tmp = GameObject.Find("BoxSmall").transform.position;
        GameObject.Find("BoxSmall").transform.position = new Vector3(tmp.x, tmp.y = 0.1f, tmp.z);*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))//押してる間にするべき？
        {

        }*/

        /*if (isstop == true)
        {
            Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x, Player_position.y + 3, Player_position.z);

            if (transform.position.y <= 2.8f)
            {
                this.gameObject.transform.Translate(0, 0, 0);
                isstop = false;
            }
        }*/

         float x = Player_position.x;
         float y = Player_position.y;
         float z = Player_position.z;

         if (Input.GetMouseButton(0))//押してる間にするべき？
         {
             BoxSmall = transform.root.gameObject;
             isstop = true;
         }
        if (isstop == true)
        {
                 Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x, Player_position.y + 3, Player_position.z);
            if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.W)|| Input.GetMouseButton(1) && Input.GetKey(KeyCode.A)|| Input.GetMouseButton(1) && Input.GetKey(KeyCode.S)|| Input.GetMouseButton(1) && Input.GetKey(KeyCode.D))
            {
                isstop = false;
            }
        }




        if (Input.GetMouseButton(1)&& Input.GetKey(KeyCode.W))//前方向に置く
        {
            Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x+2, Player_position.y+1f, Player_position.z);
        }
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.A))//左側に置く
        {
            Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x, Player_position.y + 1f, Player_position.z+2);
        }
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.S))//後ろ側に置く
        {
            Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x-2, Player_position.y + 1f, Player_position.z);
        }
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.D))//右側に置く
        {
            Vector3 Player_position = GameObject.Find("unitychan").transform.position;
            GameObject.Find("BoxSmall").transform.position = new Vector3(Player_position.x, Player_position.y + 1f, Player_position.z - 2);
        }


        // Cubemotu.gameObject.transform.Translate(0, this.speed, 0);

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isstop = true;
        }
    }*/
}
