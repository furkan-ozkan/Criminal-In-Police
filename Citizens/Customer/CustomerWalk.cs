using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerWalk : MonoBehaviour
{
    [SerializeField] private List<GameObject> path;
    [Range(0, 0.1f)] [SerializeField] private float walkSpeed;
    public int currentPoint=0;
    [SerializeField] private RuntimeAnimatorController idle, walk;

    void Update()
    {
        if (!GameController.onPause)
        {
            if (currentPoint < 3)
            {
                if (Vector3.Distance(gameObject.transform.position, path[currentPoint].transform.position) < 0.1f)
                {
                    currentPoint++;
                }
                transform.LookAt(path[currentPoint].transform);
                transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].transform.position, walkSpeed);
            }
            if (currentPoint == 3)
            {
                transform.LookAt(new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x,gameObject.transform.position.y, GameObject.FindGameObjectWithTag("Player").transform.position.z));
                if (!gameObject.GetComponent<Animator>().runtimeAnimatorController.Equals(idle))
                {
                    gameObject.GetComponent<Animator>().runtimeAnimatorController = idle;
                }
            }
            if (currentPoint > 3 && currentPoint < 6)
            {
                if (!gameObject.GetComponent<Animator>().runtimeAnimatorController.Equals(walk))
                {
                    gameObject.GetComponent<Animator>().runtimeAnimatorController = walk;
                }
                if (Vector3.Distance(gameObject.transform.position, path[currentPoint].transform.position) < 0.1f)
                {
                    currentPoint++;
                }
                transform.LookAt(path[currentPoint].transform);
                transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].transform.position, walkSpeed);
            }
            if (currentPoint >= 6)
            {
                Destroy(gameObject);
            }
        }
    }
}
