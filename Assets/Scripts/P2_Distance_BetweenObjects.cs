using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class P2_Distance_BetweenObjects : MonoBehaviour
{
    Transform obj_a_calc_distance;
    public float distance;

    private void Awake() {
        obj_a_calc_distance = GameObject.Find("Personaje").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(obj_a_calc_distance.position,
             transform.position);
        Debug.Log("Distancia: " + distance);
    }
}
