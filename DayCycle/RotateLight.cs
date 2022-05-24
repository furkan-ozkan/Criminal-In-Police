using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    private float allDay = 1800;
    private float rnTime;
    // Start is called before the first frame update
    void Start()
    {
        rnTime = 8 * 75;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.onPause)
        {
            rnTime += Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(rnTime / 5, gameObject.transform.rotation.y, gameObject.transform.rotation.z);

            GameController.hour = rnTime / 75;

            if (rnTime > allDay)
            {
                rnTime = 0;
                GameController.day++;
                GameController.hour = 0;
            }
            /*if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("Day : " + GameController.day);
                Debug.Log("Hour : " + GameController.hour);
                Debug.Log("rnTime : " + rnTime);
            }*/
        }
    }
}
