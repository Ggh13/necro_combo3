using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_any_one_part_anim : MonoBehaviour
{
    public Vector3 for_crocodil;
    public Vector3 for_bear;
    public Vector3 for_folf;

    public string who;

    public GameObject up_point;
    public GameObject down_point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    


    public void Dofolf()
    {
        transform.localPosition = for_folf;
    }

    public void Dobear()
    {
        transform.localPosition = for_bear;
    }

    public void Docroc()
    {
        transform.localPosition = for_crocodil;
    }


    public void Dofolf2()
    {
        transform.localPosition = for_folf - new Vector3(for_folf.x * 2, 0, 0);
    }

    public void Dobear2()
    {
        transform.localPosition = for_bear - new Vector3(for_bear.x * 2, 0, 0); ;
    }

    public void Docroc2()
    {
        transform.localPosition = for_crocodil - new Vector3(for_crocodil.x * 2, 0, 0); ;
    }


    /*  [ContextMenu("Use save coord folf")]
      void Dofolfr()
      {
          transform.localPosition = for_folf;
      }

      [ContextMenu("Use save coord bear")]
      void Dobearr()
      {
          transform.localPosition = for_bear;
      }

      [ContextMenu("Use save coord croc")]
      void Docrocr()
      {
          transform.localPosition = for_crocodil;
      }


      [ContextMenu("save coord folf")]
      void Dofolf_save()
      {
          for_folf = transform.localPosition;
      }

      [ContextMenu("save coord bear")]
      void Dobear_save()
      {
          for_bear = transform.localPosition;
      }

      [ContextMenu("save coord croc")]
      void Docroc_save()
      {
          for_crocodil = transform.localPosition;
      }

    */
}
