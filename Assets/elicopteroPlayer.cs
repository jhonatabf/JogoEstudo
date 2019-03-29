using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elicopteroPlayer : MonoBehaviour
{
    bool inicioJogo = false;
    bool fimJogo = false; 
    Vector2 forcaImpulso= new Vector2(0,300);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !fimJogo){
            if(!inicioJogo){
                inicioJogo = true;
                GetComponent<Rigidbody2D>().simulated = true;
            }
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(forcaImpulso);
            Vector2 limites = Camera.main.WorldToScreenPoint(transform.position);
            if(limites.y <= 0){                                  
                
            }
        }

        Vector2 limite = Camera.main.WorldToScreenPoint(transform.position);
        if(limite.y <= 0 || limite.y > Screen.height){
                Vector2 novoY = transform.position;
                novoY.y = 0f;
                transform.position = novoY;
                inicioJogo = false;
                GetComponent<Rigidbody2D>().simulated = false;
        }
            
    }
}
