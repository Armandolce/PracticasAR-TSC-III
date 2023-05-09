// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class RotacionModelo : MonoBehaviour
// {
//     public GameObject ARObject;

//     [SerializeField] private Camera aRCamera;
//     private bool isARObjectSelected;
//     private string tarARObject = "ARObject";
//     private Vector2 initialTouchPos;


//     [SerializeField] private float speedMovement = 4.0f;
//     [SerializeField] private float speedRotation = 5.0f;
//     [SerializeField] private float scaleFactor = 0.1f;
    
//     private float screenFactor = 0.0001f;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.touchCount > 0)
//         {
//             Touch touchOne = Input.GetTouch(0);

//             if(Input.touchCount == 1)
//             {
                
//                 if(touchOne.phase == TouchPhase.Began)
//                 {
//                     initialTouchPos = touchOne.position;
//                     isARObjectSelected = CheckTouchOnARObject(initialTouchPos);
//                 }
//                 if(touchOne.phase == TouchPhase.Moved && isARObjectSelected)
//                 {
//                     Vector2 diffPos = (touchOne.position - initialTouchPos) * screenFactor;
//                     ARObject.transform.position = ARObject.transform.position +
//                         new Vector3(diffPos.x* speedMovement, diffPos.y* speedMovement, 0);
                    
//                     initialTouchPos = touchOne.position;
//                 }
//             }
//         }
//     }
//     private bool CheckTouchOnARObject(Vector2 touchPosition)
//     {
//         Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        
//         if(Physics.Raycast(ray, out RaycastHit hitARObject))
//         {
//             if(hitARObject.collider.CompareTag(tarARObject))
//             {
//                 ARObject = hitARObject.transform.gameObject;
//                 return true;
//             }
//         }
//         return false;
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionModelo : MonoBehaviour
{
    public GameObject ARObject;
    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    [SerializeField] private Camera aRCamera;
    private bool isARObjectSelected;
    private string tagARObjects = "ARObject";
    private Vector2 initialTouchPos;

    public void rotateIf(){
        if (rotateStatus == false){
            rotateStatus = true;
        }else{
            rotateStatus = false;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            Touch touchOne = Input.GetTouch(0);

            if (Input.touchCount == 1){
                
                if (touchOne.phase == TouchPhase.Began){
                    initialTouchPos = touchOne.position;
                    isARObjectSelected = CheckTouchOnArObject(initialTouchPos);
                    rotateIf();
                }
            }
        }

        if (rotateStatus == true){
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

    private bool CheckTouchOnArObject(Vector2 touchPosition){
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);

        if (Physics.Raycast(ray, out RaycastHit hitARObject)){
            if (hitARObject.collider.CompareTag(tagARObjects)){
                ARObject = hitARObject.transform.gameObject;
                return true;
            }
        }

        return false;
    }
}
