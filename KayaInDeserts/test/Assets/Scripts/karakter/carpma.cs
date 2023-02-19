using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpma : MonoBehaviour
{
    private Collider myCollider;
    public Animator m_Animator;
    void Start() 
    {
        myCollider=GetComponent<Collider>();
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("ragdoll=" + other.name);
        myCollider.isTrigger = false;
        m_Animator.enabled = false;
    }
}
