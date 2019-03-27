using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMoveFundo : MonoBehaviour
{
    public float velocidadeCenario = -0.5f;
    public float limiteCenario = -10f;
    public float spawCenario = 10;
    public float alturaCenario = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeCenario,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= limiteCenario){
            transform.position = new Vector2(spawCenario,alturaCenario);
        }
    }
}
