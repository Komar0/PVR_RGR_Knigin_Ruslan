using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private bool Trigger;
    [SerializeField] private Animator Target = null;
    [SerializeField] private GameObject NextTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            StartCoroutine(WaitSec());
        }
    }

    IEnumerator WaitSec()
    {
        Target.Play("door_2_open", 0, 0.0f);
        NextTrigger.SetActive(false);

        yield return new WaitForSeconds(5);

        Target.Play("door_2_close", 0, 0.0f);
        NextTrigger.SetActive(true);
    }
}