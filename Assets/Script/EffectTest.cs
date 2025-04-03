using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTest : MonoBehaviour
{

    //1.오브젝트 접근
    //  a. public 변수로 만들어서 연결하는 방법
    //  b. 코드를 통해서 찾는 방법 - Resources
    //2. 선택한 리소스를 생성

    public Transform target;
    public GameObject effect; 
    void Start()
    {
        Instantiate(effect, target.position + Vector3.back, effect.transform.rotation);

        //Resources.Load
        GameObject effectRes = Resources.Load<GameObject>("Particles/Hit 2");
        Instantiate(effectRes, target.position + Vector3.back, effect.transform.rotation);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
