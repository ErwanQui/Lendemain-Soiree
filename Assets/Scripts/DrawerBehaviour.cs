using UnityEngine;
using Valve.VR.InteractionSystem;

public class DrawerBehaviour : MonoBehaviour
{
    [Tooltip("The key to unlock the chest.")]
    public GameObject key;

    protected Transform Drawer;
    protected Transform DrawerUnlock;

    // Start is called before the first frame update
    void Start()
    {
        Drawer = transform.parent.Find("drawer");
        DrawerUnlock = transform.parent.Find("drawerUnlock");
        //Drawer.GetComponent<Interactable>().enabled = false;
        //Drawer.GetComponent<LinearDrive>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            //Drawer.GetComponent<Interactable>().enabled = true;
            //Drawer.GetComponent<LinearDrive>().enabled = true;
            Drawer.gameObject.SetActive(false);
            DrawerUnlock.gameObject.SetActive(true);
            key.GetComponent<Interactable>().attachedToHand.DetachObject(key);
            key.GetComponent<Interactable>().enabled = false;
            key.GetComponent<Throwable>().enabled = false;
            key.GetComponent<Collider>().enabled = false;
            key.GetComponent<Rigidbody>().isKinematic = true;
            key.transform.eulerAngles = new Vector3(0, 180, 90);
            key.transform.position = transform.position - transform.right/7;
            key.transform.SetParent(DrawerUnlock, true);
            GetComponent<AudioSource>().Play();
        }
    }
}
