using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(NavMesh))]

public class GhostBlueController : MonoBehaviour {

    NavMeshAgent NMA;
    bool enemyCollision;
    private float DistanceWV;
    private float DistanceWR;
    private float DistanceWL;
    private float DistanceWH;
    public bool Bewegbarkeit;
    public float E;
    public int Speed;
    public int Phase;
    private int t;
    private int q;
    public float v;
    private Vector3 p;


    // Use this for initialization
    void Start()
    {
        E = 1;
        Phase = 2;
        Bewegbarkeit = true;
        enemyCollision = false;
        RaycastingWalls();
        t = 0;
        q = 0;
        BV(E);
    }

    // Update is called once per frame
    void Update() {
        if (Phase == 1)
        {
            NMA = GetComponent<NavMeshAgent>();
        }
        if (Phase == 2)
        {
            RaycastingWalls();
            Debug.Log(DistanceWV);
            PacManVerfolgen();
          if (Bewegbarkeit)
           {
                if (t == 0 && (DistanceWR > 110 || DistanceWL > 110))
                {
                   t++;
                   v = Mathf.Round(DistanceWV);
                }
                if (t == 1 && Mathf.Round(DistanceWV) == (v - 25))
                {
                   BewegenBeiKreuzungen();
                   t++;
                }
                if (t == 2 && (DistanceWL < 110 && DistanceWR < 110))
                {
                   t = 0;
                }
                if (!enemyCollision)
                {
                    BV(E);
                }
                if (q == 0 && enemyCollision)
                {
                   p = transform.position;
                   q++;
                }
                if (q == 1 && (transform.position.x != p.x || transform.position.y != p.y))
                {
                    enemyCollision = false;
                }
           }
        }
    }

    private void PacManVerfolgen()
    {
        GameObject pacman = GameObject.FindWithTag("Pacman");
        Vector3 PP = pacman.transform.position;
        Vector3 GP = transform.position;
        float PlayerDistance = Mathf.Sqrt((PP.z*PP.z) + (GP.x*GP.x));
        if(Phase==2)
        {
            if (PlayerDistance < 200)
            {
                Bewegbarkeit = false;
                Phase = 1;
                Update();
                NMA.enabled = true;
                NMA.SetDestination(PP);
            }
        }
        else
        {
            if (Phase == 1)
            {
                NMA.enabled = false;
            }
            Phase = 2;
            Bewegbarkeit = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!enemyCollision)
        {
            if (other.gameObject.tag == "Ghost")
            {
                transform.Rotate(0, 180, 0);
                enemyCollision = true;
            }
        }
    }

    public void BewegenBeiKreuzungen()
    {
        if ((DistanceWR > 110 || DistanceWL > 110))
        {
            GetNewRandomPosition();
        }
    }

    private void RaycastingWalls()
    {
        RaycastingWV();
        RaycastingWR();
        RaycastingWL();
        RaycastingWH();
    }

    private float RaycastingWV()
    {
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out TheHit))
        {
            if (TheHit.collider.gameObject.tag == "Wall")
            {
                DistanceWV = TheHit.distance;
            }
        }
        return DistanceWV;
    }

    private float RaycastingWR()

    {
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out TheHit))
        {
            if (TheHit.collider.gameObject.tag == "Wall")
            {
                DistanceWR = TheHit.distance;
            }
        }
        return DistanceWR;
    }

    private float RaycastingWL()
    {
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out TheHit))
        {
            if (TheHit.collider.gameObject.tag == "Wall")
            {
                DistanceWL = TheHit.distance;
            }
        }
        return DistanceWL;
    }

    private float RaycastingWH()
    {
        RaycastHit TheHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out TheHit))
        {
            if (TheHit.collider.gameObject.tag == "Wall")
            {
                DistanceWH = TheHit.distance;
            }
        }
        return DistanceWH;
    }

    public void GetNewRandomPosition()
    {
        int a = RandomNumber(1, 4);
        bool bewegt = false;
        if (Bewegungsfreiheit())
        {
            while (!bewegt)
            {
                if (a == 1)
                {
                    if (DistanceWV > 110)
                    {
                        bewegt = true;
                    }
                    else
                    {
                        a = a + RandomNumber(1, 3);
                    }
                }
                if (a == 2)
                {
                    if (DistanceWH < 110 || RandomNumber(0,5)>1)
                    {
                        a = a + RandomNumber(1, 3);
                        if (a == 5)
                        {
                            a = 1;
                        }
                    }
                    else
                    {
                        transform.Rotate(0, 180, 0);
                        bewegt = true;
                    }
                }
                if (a == 3)
                {
                    if (DistanceWR < 110)
                    {
                        a = a + RandomNumber(0, 1);
                        if (a == 3)
                        {
                            a = a + RandomNumber(-2, -1);
                        }
                    }
                    else
                    {
                        transform.Rotate(0, 90, 0);
                        bewegt = true;
                    }
                }
                if (a == 4)
                {
                    if (DistanceWL < 110)
                    {
                        a = a + RandomNumber(-3, -1);
                    }
                    else
                    {
                        transform.Rotate(0, -90, 0);
                        bewegt = true;
                    }
                }
            }
            RaycastingWalls();
            BV(E);
        }
    }

    public bool Bewegungsfreiheit()
    {
        if (DistanceWV > 50 || DistanceWR > 50 || DistanceWL > 50 || DistanceWH > 50)
        {
            return true;
        }
        return false;
    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }

    
    //Entfernung nach vorn bewegen
    public void BV(float e)
    {
        transform.Rotate(0, -(transform.eulerAngles.y - Mathf.RoundToInt(transform.eulerAngles.y / 90) * 90), 0);
        transform.Translate(new Vector3(0, 0, e * Speed * Time.deltaTime));
        RaycastingWalls();
        Debug.Log(DistanceWV);
        if (DistanceWV < 51)
        {
            GetNewRandomPosition();
        } 
    }
}