using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
  public abstract class State
    {
        public virtual IEnumerator Start()
        {
            yield break;
        }
        public virtual IEnumerator Attack()
        {
            yield break;
        }
        public virtual IEnumerator Skill()
        {
            yield break;
        }
    }
}
