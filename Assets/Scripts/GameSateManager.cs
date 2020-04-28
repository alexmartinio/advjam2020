using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSateManager : MonoBehaviour
{
    [SerializeField] GameObject cuckoo;
    [SerializeField] GameObject geoffrey;
    [SerializeField] GameObject tv;
    // Update is called once per frame

    bool tvOn = false;
    bool channelSwitched = false;

    // Cached objects
    Object _tv;
    Object _geoffrey;
    Object _cuckoo;

    private void Start()
    {
        // Cache the objects so it would run faster
        _tv = tv.GetComponent<Object>();
        _geoffrey = geoffrey.GetComponent<Object>();
        _cuckoo = cuckoo.GetComponent<Object>();

    }

    RaycastHit2D hitDetection()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        return hit;
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = hitDetection();
            if (hit.collider != null)
            {
                if ((hit.collider.gameObject.GetComponent("Object") as Object) != null)
                {
                    if(hit.collider.gameObject.name == "Cuckoo")
                    {
                        _geoffrey.Execute("Awake", true);
                        _cuckoo.Execute("ChangeColor", true);
                    }

                    if(hit.collider.gameObject.name == "Remote")
                    {
                        if (tvOn)
                        {
                            _tv.Execute("switchChannel", true);
                            if(channelSwitched)
                            {
                                _tv.Execute("switchChannel", false);
                                channelSwitched = false;
                            }
                            else
                            {
                                _tv.Execute("switchChannel", true);
                                channelSwitched = true;
                            }
                        }
                        else if(!tvOn)
                        {
                            _tv.Execute("tvOn", true);
                        }    
                        tvOn = true;
                    }
                }
            }   
        }
    }
}
