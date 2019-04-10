using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

public class GhostBlue : MonoBehaviour {

    NavMeshAgent nMA;
    BoxCollider boxC;
    public float timerForNewPath;
    bool inCoRoutine;
    bool wallCollision;
    bool enemyCollision;
    bool playerCollision;
    bool anfang;
    public float TargetDistance;

    // Use this for initialization
    void Start()
    {
        nMA = GetComponent<NavMeshAgent>();
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out TheHit))
        {
            TargetDistance = TheHit.distance;
            //console.log(TheHit);
        }
    }

    // Update is called once per frame
    void Update() {
        
          if (anfang)
        {
            nMA.SetDestination(new Vector3(-350, 100, 0));
            //new WaitForSeconds(timerForNewPath);
            anfang = false;
        } 
        /*if (!inCoRoutine)
        {
            if (!wallCollision)
            {
                StartCoroutine(DoSomething());
            }
        } */
    } 

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(0, 1000-transform.position.x);
        float z = Random.Range(0, 1000-transform.position.z);

        
        Vector3 pos = new Vector3(x, 100, z);
        return pos;
    }

    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerForNewPath);
        GetNewPath();
        inCoRoutine = false;
    }

    void GetNewPath()
    {
        if(!wallCollision)
        {
            nMA.SetDestination(getNewRandomPosition());
        }
    }

    private void OnCollisionExit (Collision c)
    {
        if (c.collider.tag == "wall")
        {
            wallCollision = true;
        }
        else
        {
            wallCollision = false;
        }
        if (c.collider.tag == "enemy")
        {
            enemyCollision = true;
        }
        else
        {
            enemyCollision = false;
        }
        if (c.collider.tag == "player")
        {
            playerCollision = true;
        }
        else
        {
            playerCollision = false;
        }
    }
}