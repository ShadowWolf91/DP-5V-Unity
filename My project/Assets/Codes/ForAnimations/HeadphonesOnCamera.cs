using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class HeadphonesOnCamera : MonoBehaviour
{
    Animator anim;
    private CameraMovement cameraMovement_;
    [SerializeField] private new GameObject camera;
    public GameObject gameObject;
    bool move = false;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cameraMovement_ = camera.GetComponent<CameraMovement>();
        cameraMovement_.GetComponent<AudioListener>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && cameraMovement_.transform.position == new Vector3(-0.3954054f, 1.656074f, 0.7469103f) && cameraMovement_.transform.rotation == Quaternion.Euler(56.412f, 7.314f, -0.002f))
        {
            cameraMovement_.GetComponent<AudioListener>().enabled = true;
            anim.SetInteger("HPOC", 1);
            anim.enabled = false;
            move = true;
        }
        if (move)
        {
            gameObject.transform.position = cameraMovement_.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.enabled = true;
            cameraMovement_.GetComponent<AudioListener>().enabled = false;
            anim.SetInteger("HPOC", 0);
            move = false;
        }
        if (!move)
        {
            gameObject.transform.position = new Vector3( -0.3f, 1.22f, 1.1f);
        }
    }
}
