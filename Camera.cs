using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject MainCamera;                   //メインカメラ
    public GameObject Target;                       //ターゲット




    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("LeftClick" + mousePosition);

            if(mousePosition.x < 700)
            {
                Debug.Log("LEFT");
                transform.LookAt(Target.transform.position);
                transform.RotateAround(Target.transform.position, new Vector3(0, 1, 0), 0.5f);
            }
            else if(mousePosition.x >= 700)
            {
                Debug.Log("RIGHT");
                transform.LookAt(Target.transform.position);
                transform.RotateAround(Target.transform.position, new Vector3(0, 1, 0), -0.5f);
            }
            
        }
    }
}
