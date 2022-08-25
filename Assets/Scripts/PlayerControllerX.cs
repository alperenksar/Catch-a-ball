using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] private bool _deneme = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _deneme) 
        {   
            _deneme = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(Deneme());
        }
    }


    private IEnumerator Deneme()
    {
        yield return new WaitForSeconds(1f);
        _deneme = true;                     
    }
}
