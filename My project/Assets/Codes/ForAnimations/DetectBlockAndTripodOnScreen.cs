using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class DetectBlockAndTripodOnScreen : MonoBehaviour
{
    GameObject GameObject;
    RangeSwitch rangeSwitch;
    Animator anim;
    private CameraMovement cameraMovement_;
    [SerializeField] private new GameObject camera;
    public GameObject gameObject;
    GameObject mm;
    bool move = false;
    private Ray ray;
    TripodMove tripodMove;
    MonitorMove monitorMove;
    GameObject gg;
    GameObject rheadPhones;
    GameObject lheadPhones;
    AudioSource left;
    AudioSource right;
    private Vector3 vector3;
    private Quaternion quaternion;
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        GameObject = GameObject.FindGameObjectWithTag("switcher");
        mm = GameObject.FindGameObjectWithTag("monitor");
        gg = GameObject.FindGameObjectWithTag("divArr");
        anim = GetComponent<Animator>();
        cameraMovement_ = camera.GetComponent<CameraMovement>();
        vector3 = new Vector3 (transform.position.x - cameraMovement_.transform.position.x, transform.position.y - cameraMovement_.transform.position.y/1.2f, transform.position.z - (cameraMovement_.transform.position.z + 1.5f));
        quaternion = Quaternion.Euler(transform.rotation.x + (cameraMovement_.transform.rotation.x + 30), transform.rotation.y + (cameraMovement_.transform.rotation.y - 180), transform.rotation.z + cameraMovement_.transform.rotation.z);
        monitorMove = mm.GetComponent<MonitorMove>();
        rangeSwitch = GameObject.GetComponent<RangeSwitch>();
        rheadPhones = GameObject.FindWithTag("rhp");
        lheadPhones = GameObject.FindWithTag("lhp");
        right = rheadPhones.GetComponent<AudioSource>();
        left = lheadPhones.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && cameraMovement_.transform.position == new Vector3(0.76f, 1.6f, 0.17f) && cameraMovement_.transform.rotation == Quaternion.Euler(35.683f, -38.757f, -0.008f))
        {
            anim.SetInteger("DBaTOS", 1);
        }
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    //gameObject.transform.position = new Vector3 (cameraMovement_.transform.position.x - 0.6f, cameraMovement_.transform.position.y - 0.4f, cameraMovement_.transform.position.z + 0.1f);
        //    //gameObject.transform.rotation = new Quaternion(cameraMovement_.transform.rotation.x, cameraMovement_.transform.rotation.y - 90, cameraMovement_.transform.rotation.z, cameraMovement_.transform.rotation.w - 90);
        //    anim.enabled = false;
        //    move = true;
        //}
        //if (move)
        //{
        //    transform.position = cameraMovement_.transform.position + vector3;
        //    transform.rotation = cameraMovement_.transform.rotation * quaternion;
        //}
        if (Input.GetKeyDown(KeyCode.N))
        {
            anim.enabled = true;
            anima.enabled = true;
            anim.SetInteger("DBaTOS", 2);
            if (monitorMove.rotation == 1)
            {
                if (rangeSwitch.move == 2 || rangeSwitch.move == 3 || rangeSwitch.move == 4 || rangeSwitch.move == 5 || rangeSwitch.move == 6 || rangeSwitch.move == 7)
                {
                    anima.enabled = false;
                    gg.transform.rotation = Quaternion.Euler(Random.Range(-49.0f, -123.0f), -90f, 90f);
                    //rh = rnd.Next(1, 200)*1000;
                }
                //Debug.Log(gamma.rh);
                left.Play();
                right.Play();
            }
            else
            {
                left.Stop();
                right.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.enabled = true;
            anima.enabled = true;
            anim.SetInteger("DBaTOS", 3);
            if (monitorMove.rotation == 2)
            {
                if (rangeSwitch.move == 2 || rangeSwitch.move == 3 || rangeSwitch.move == 4 || rangeSwitch.move == 5 || rangeSwitch.move == 6 || rangeSwitch.move == 7)
                {
                    anima.enabled = false;
                    gg.transform.rotation = Quaternion.Euler(Random.Range(-49.0f, -123.0f), -90f, 90f);
                    //rh = rnd.Next(1, 200)*1000;
                }
                left.Play();
                right.Play();
            }
            else 
            {
                left.Stop();
                right.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.enabled = true;
            anima.enabled = true;
            anim.SetInteger("DBaTOS", 0);
        //    move = false;
        //}
        //if (!move)
        //{
        //    gameObject.transform.position = new Vector3(-0.3f, 1.22f, 1.1f);
        }
    }
}
