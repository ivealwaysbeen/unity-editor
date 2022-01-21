using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Editor
{
    /// <summary>
    /// priority define in UnityEditor.MenuItem
    /// </summary>
    public enum Define
    {
        //Editor MenuItem Attribute는 priority 값의 오름차순으로 정렬이 된다.
        File = -900000,
        Edit = -800000,
            내부캐시모두삭제,

        Assets = -700000,
        GameObject = -600000,
        Component = -500000,

        /// <summary>
        /// -400000 ~ 
        /// </summary>
        
        기능 = -400000,
            비활성화_오브젝트_모으기,
        검색 = -300000,
            
        Windoow = 800000,
        Help = 900000
    }
}

