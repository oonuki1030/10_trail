using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 3.0f;
	GameObject sword;

    void Start()
    {
        sword = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Swipe();
    }

    private void Swipe()
    {
        if(Input.GetMouseButton(0))
        {
        	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        	Vector3 target_pos = ray.GetPoint(5.0f);
        	
        	sword.transform.LookAt(target_pos);
        }
    }
}
