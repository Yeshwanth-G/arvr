using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class act_as_button : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent event1 = new UnityEvent();
    public GameObject button;
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit) && hit.collider.gameObject == button)
            {
                event1.Invoke();
            }
        }
    }
}
