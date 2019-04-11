using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(NavMesh))]

public class GhostController : MonoBehaviour {

    NavMeshAgent nMA;
    BoxCollider boxC;
    public float timerForNewPath;
    bool wallCollision;
    bool enemyCollision;
    bool playerCollision;
    public float TargetDistance;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
        new WaitForSeconds(timerForNewPath);
        nMA = GetComponent<NavMeshAgent>();
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out TheHit))
        {
            TargetDistance = TheHit.distance;
        }
        if(TargetDistance<100)
        {
                transform.Rotate(0, 90, 0);
        }
        if (wallCollision)
        {
            StartCoroutine(DoSomething());
        } 
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "wall")
        {
            wallCollision = true;
            Debug.Log(c.transform.name + "Collision with a wall!");
        }
        else
        {
            wallCollision = false;
        }
        if (c.tag == "enemy")
        {
            enemyCollision = true;
            Debug.Log(c.transform.name + "Collision with an enemy!");
        }
        else
        {
            enemyCollision = false;
        }
        if (c.tag == "player")
        {
            playerCollision = true;
            Debug.Log(c.transform.name + "Collision with Pac-Man!");
        }
        else
        {
            playerCollision = false;
        }
    }

    IEnumerator DoSomething()
    {
        yield return new WaitForSeconds(timerForNewPath);
        GetNewPath();
    }

    Vector3 getNewRandomPosition()
    {
        if(RandomNumber(0, 1)==0)
        {
            if(RandomNumber(0,1)==0)
            {
                int x = 1000;
                Vector3 pos = new Vector3(x, 100, 0);
                return pos;
            } 
            else
            {
                int x = -1000;
                Vector3 pos = new Vector3(x, 100, 0);
                return pos;
            }
        }
        else
        {
            if(RandomNumber(0,1)==0)
            {
                int z = 1000;
                Vector3 pos = new Vector3(0, 100, z);
                return pos;
            }
            else
            {
                int z = -1000;
                Vector3 pos = new Vector3(0, 100, z);
                return pos;
            }
        }            
    }

    void GetNewPath()
    {

        if (playerCollision || enemyCollision)
        {
            nMA.SetDestination(getNewRandomPosition());
            playerCollision = false;
            enemyCollision = false;
        }
       
    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}