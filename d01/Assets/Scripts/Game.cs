using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Game : MonoBehaviour
{
    private CinemachineVirtualCamera myCinemachine;
    
    public GameObject ItsCinemachine;
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    private Transform tFollowTarget;
    private playerScript_ex00 _scriptR;
    private playerScript_ex00 _scriptB;
    private playerScript_ex00 _scriptY;
    
    // Start is called before the first frame update
    void Start()
    {
        myCinemachine = ItsCinemachine.gameObject.GetComponent<CinemachineVirtualCamera>();
        _scriptR = red.gameObject.GetComponent<playerScript_ex00>();
        _scriptB = blue.gameObject.GetComponent<playerScript_ex00>();
        _scriptY = yellow.gameObject.GetComponent<playerScript_ex00>();
        tFollowTarget = red.transform;
        
        myCinemachine.LookAt = tFollowTarget;
        myCinemachine.Follow = tFollowTarget;
        _scriptR._play = true;
        _scriptB._play = false;
        _scriptY._play = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            // myCinemachine.m_Follow = red;
            
            tFollowTarget = red.transform;
            myCinemachine.LookAt = tFollowTarget;
            myCinemachine.Follow = tFollowTarget;
            _scriptR._play = true;
            _scriptB._play = false;
            _scriptY._play = false;
        }
        if (Input.GetKeyDown("2"))
        {
            // myCinemachine.m_Follow = blue;
            tFollowTarget = blue.transform;
            myCinemachine.Follow = tFollowTarget;
            _scriptB._play = true;
            _scriptR._play = false;
            _scriptY._play = false;
        }
        if (Input.GetKeyDown("3"))
        {
            // myCinemachine.m_Follow = yellow;
            tFollowTarget = yellow.transform;
            myCinemachine.Follow = tFollowTarget;
            _scriptY._play = true;
            _scriptR._play = false;
            _scriptB._play = false;
        }
    }
}
