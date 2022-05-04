using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropitens : MonoBehaviour
{

    [SerializeField] private GameObject item;
    [SerializeField] private int itemDropRate;
    [SerializeField] private int itemMinDrop;
    [SerializeField] private int itemMaxDrop;

    public void Drop(){
        int rand = Random.Range(1,100);

        print(rand);

        if(rand< itemDropRate){

            int amount = Random.Range(itemMinDrop,itemMaxDrop);

            for(int i = 0;i< amount;i++){
                
                Instantiate(item,transform.position,transform.rotation);

            }
        }
    }














    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
