using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{
    [SerializeField] [Range(0, 6)] private float timer;
    private float time;
    [SerializeField] List<GameObject> customerList;
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = timer;
            float temp = Random.Range(0, 101);
            if (GameController.activeCustomer == null && (temp < (30 + (6 * GameController.customerHappines))) && GameController.storeOpen && !GameController.onPause)
            {
                Instantiate(customerList[Random.Range(0, customerList.Count)], new Vector3(30.5f, 1, 41.5f), new Quaternion(0, 0, 0, 0));
            }
        }
    }
}
