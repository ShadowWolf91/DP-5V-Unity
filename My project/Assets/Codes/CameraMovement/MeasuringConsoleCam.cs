using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MeasuringConsoleCam : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    [SerializeField] private new GameObject camera;
    private CameraMovement cameraMovement;
    void Start()
    {
        cameraMovement = camera.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
    cameraMovement.SetNeedPosAndRot(new Vector3(0.2278434f, 1.41664f, 0.3f), Quaternion.Euler(19.594f, 0.366f, -0.01f));
    }
}
