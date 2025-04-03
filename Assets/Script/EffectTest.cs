using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTest : MonoBehaviour
{

    //1.������Ʈ ����
    //  a. public ������ ���� �����ϴ� ���
    //  b. �ڵ带 ���ؼ� ã�� ��� - Resources
    //2. ������ ���ҽ��� ����

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
