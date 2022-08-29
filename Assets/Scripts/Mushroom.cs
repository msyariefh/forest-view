using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float upForce = 1f;
    public float sideForce = .1f;
    [SerializeField] float _disableAfterSeconds = 3.0f;

    //void Start()
    //{
    //    float xForce = Random.Range(-sideForce, sideForce);
    //    float yForce = Random.Range(upForce / 2f, upForce);
    //    float zForce = Random.Range(-sideForce, sideForce);

    //    Vector3 force = new Vector3(xForce, yForce, zForce);

    //    GetComponent<Rigidbody>().velocity = force;
        
    //}
    private void OnEnable()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
        StartCoroutine(DisableAfter());
    }


    IEnumerator DisableAfter ()
    {
        yield return new WaitForSeconds(_disableAfterSeconds);
        gameObject.SetActive(false);
    }
}
