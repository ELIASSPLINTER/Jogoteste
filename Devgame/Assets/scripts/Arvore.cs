using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore : MonoBehaviour
{

    [SerializeField] private int healht ;

    private Dropitens Drops;
    
    // Start is called before the first frame update
    void Start()
    {
        Drops = GetComponent<Dropitens>();
    }

    private void OnMouseDown() {
        Debug.Log("entrou mause");
         TakeDamage(1);
    }

    private void TakeDamage(int damage){
        healht -= damage;

        if(healht <= 0){
            Debug.Log("entrou if");
            OnEnemyDied();
        }
             

    }

    private void OnEnemyDied(){

        Drops.Drop();

        Destroy(gameObject);
        Debug.Log("entrou destroi");
    }


}
