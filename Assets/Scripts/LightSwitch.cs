using Unity.VisualScripting;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private GameObject _light;
    private bool atSwitch = false;
    public bool lightOn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _light = GameObject.FindGameObjectWithTag("Light");
        _light.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (atSwitch) {
                if (lightOn) {
                    _light.SetActive(false);
                    lightOn = false;
                }
                else {
                    _light.SetActive(true);
                    lightOn = true;
                }
                
                
            }
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Switch")) {
            atSwitch = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Switch")) {
            atSwitch = false;
        }
    }
}
