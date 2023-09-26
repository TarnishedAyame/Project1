using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float meanspeed = 100;
    public int Wahspeed = 2;
    public int pettanspeed = 21;
    // Start is called before the first frame update
    void Start()
    {

        meanspeed = Random.Range(Wahspeed, pettanspeed);
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(meanspeed * Time.deltaTime, 0, 0); sideways
        //transform.Translate(0, -meanspeed * Time.deltaTime, 0);

        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.down * meanspeed * Time.deltaTime, Space.World);
        
    }
}
