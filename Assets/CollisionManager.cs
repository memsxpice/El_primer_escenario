using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    Animator coins_Animator;
    GameObject coin;
    GameObject[] coins;

    void Awake(){
        coins = GameObject.FindGameObjectsWithTag("CoinsDrop");
    }

    void OnTriggerEnter2D(Collider2D coll){
        Debug.Log("Toco la moneda!");

        foreach(GameObject coin in coins){
            coins_Animator = coin.GetComponent<Animator>();
            coins_Animator.SetBool("isDroping", true);
        }

    }

    void OnTriggerExit2D(Collider2D coll){
        Debug.Log("Toco la moneda!");

        foreach(GameObject coin in coins){
            coins_Animator = coin.GetComponent<Animator>();
            coins_Animator.SetBool("isDroping", false);
        }

    }
}
