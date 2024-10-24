using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    private LightSwitch lightSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.SetActive(false);
        lightSwitch = GameObject.FindGameObjectWithTag("player").GetComponent<LightSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("player").GetComponent<LightSwitch>() == false) {
            Debug.Log("Hello");
            this.gameObject.SetActive(true);
        }
        else {
            this.gameObject.SetActive(false);
        }
    }
}
