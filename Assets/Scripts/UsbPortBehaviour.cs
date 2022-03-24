using System.Diagnostics;
using UnityEngine;
using UnityEngine.Video;
using Valve.VR.InteractionSystem;

public class UsbPortBehaviour : MonoBehaviour
{
    [Tooltip("The key to unlock the pc.")]
    public GameObject key1;

    [Tooltip("The key to unlock the pc.")]
    public GameObject key2;

    public VideoClip video1;
    public VideoClip video2;

    public GameObject phone;

    private bool isVideo2;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Debug.Log("DedansTart");
        //chestTopDrive = transform.parent.GetComponentInChildren<CircularDrive>();
    }

    private void OnCollisionEnter(Collision other)
    {
        UnityEngine.Debug.Log("Dedans0");

        if (other.gameObject == key1 || (isVideo2 = (other.gameObject == key2)))
        {
            UnityEngine.Debug.Log("Dedans1");
            UnityEngine.Debug.Log(other.gameObject.GetComponent<Interactable>().attachedToHand);
            other.gameObject.GetComponent<Interactable>().attachedToHand = null;//.DetachObject(key1);
            UnityEngine.Debug.Log(other.gameObject.GetComponent<Interactable>().attachedToHand);

            other.gameObject.GetComponent<Interactable>().enabled = false;
            other.gameObject.GetComponent<Throwable>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = false;

            rb = other.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = true;

            other.gameObject.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.SetParent(transform, true);

            VideoPlayer vPlayer = transform.parent.parent.GetChild(1).GetChild(0).GetChild(0).GetComponent<VideoPlayer>();

            vPlayer.clip = (isVideo2 ? video2 : video1);


            Destroy(other.gameObject.GetComponent<Throwable>());



            phone.GetComponent<PhoneScript>().PhoneCall();
        }
    }
}
