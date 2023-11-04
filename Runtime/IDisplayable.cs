using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.A9.Displayable
{
    public interface IDisplayable
    {
        public void Display<T>(T data);
        public void Clear();
    }


}
