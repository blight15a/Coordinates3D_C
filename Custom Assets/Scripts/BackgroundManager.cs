using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coordinate3D
{

public class BackgroundManager : MonoBehaviour
{
    
    //////////////////////////////////////////////////////////////////////
    // types
    //////////////////////////////////////////////////////////////////////
    #region types
    
    public enum GameState_En
    {
        Nothing, Inited
    }

    #endregion

    //////////////////////////////////////////////////////////////////////
    // fields
    //////////////////////////////////////////////////////////////////////
    #region fields

    //-------------------------------------------------- SerializeField
    [SerializeField]
    Animator curtainAnim_Cp;

    //-------------------------------------------------- public fields
    public GameState_En gameState;

    //-------------------------------------------------- private fields

    #endregion

    //////////////////////////////////////////////////////////////////////
    // properties
    //////////////////////////////////////////////////////////////////////
    #region properties

    //-------------------------------------------------- public properties

    //-------------------------------------------------- private properties

    #endregion

    //////////////////////////////////////////////////////////////////////
    // methods
    //////////////////////////////////////////////////////////////////////

    //-------------------------------------------------- Start is called before the first frame update
    void Start()
    {
        
    }

    //-------------------------------------------------- Update is called once per frame
    void Update()
    {
        
    }
    
    //////////////////////////////////////////////////////////////////////
    // Init
    //////////////////////////////////////////////////////////////////////
    #region Init

    //-------------------------------------------------- Init
    public void Init()
    {
        // 
        if(!curtainAnim_Cp.gameObject.activeInHierarchy)
        {
            curtainAnim_Cp.gameObject.SetActive(true);
        }

        curtainAnim_Cp.transform.SetAsLastSibling();

        // 
        gameState = GameState_En.Inited;
    }

    #endregion

    //////////////////////////////////////////////////////////////////////
    // Play
    //////////////////////////////////////////////////////////////////////
    #region Play

    //--------------------------------------------------
    public void Play()
    {
        CurtainUp();
    }

    #endregion
    
    //////////////////////////////////////////////////////////////////////
    // Curtain
    //////////////////////////////////////////////////////////////////////
    #region Curtain

    //-------------------------------------------------- 
    void CurtainUp()
    {
        curtainAnim_Cp.SetTrigger("up");
    }

    //--------------------------------------------------
    void CurtainDown()
    {
        curtainAnim_Cp.SetTrigger("down");
    }

    #endregion
}

}