using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    private GameObject lightSwitch;
    public GameObject monster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.gameObject.SetActive(false);
        lightSwitch = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (lightSwitch.GetComponent<LightSwitch>().lightOn == false) {
            monster.SetActive(true);
        }
        else {
            monster.SetActive(false);
        }
    }
}
