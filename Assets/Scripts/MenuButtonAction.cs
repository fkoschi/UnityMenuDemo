using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonAction : MonoBehaviour
{
    public int target = -1;
    public Canvas mainMenuReference;
	public Canvas optionsMenuReference;

    // Start is called before the first frame update
    void Start()
    {
        if(optionsMenuReference) {
            optionsMenuReference.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return)) {
            switch (target)
            {
                case 0: switchMenu(true); break;
                case 1: switchMenu(false); break;
                default: break;
            }
        }
    }

    void switchMenu(bool state) {
        mainMenuReference.gameObject.SetActive(state);
		optionsMenuReference.gameObject.SetActive(!state);
    }
}
