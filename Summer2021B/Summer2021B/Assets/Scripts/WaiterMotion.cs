using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaiterMotion : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject destination;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
        agent.SetDestination(destination.transform.position);
        animator.SetBool("Walk", true);
    }

    private void OnTriggerEnter(Collider other) 
    {
      if(other.tag == "DEST")
      {
        
        StartCoroutine(npcWait());
      }
    }

    IEnumerator npcWait(){
      animator.SetBool("Walk", false);
    yield return new WaitForSeconds(6);
      animator.SetBool("Walk", true);
      agent.SetDestination(destination.transform.position);
   }

     void Update()
    {
      if(animator.GetBool("Walk") && !audioSource.isPlaying)
      {
        audioSource.Play();
      }
    }
 
   
}