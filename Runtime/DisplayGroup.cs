using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.A9.Displayable
{
    public class DisplayGroup
    {
        public static void PresentList<T>(Transform grid, List<T> data_stream)
        {
            IDisplayable[] comp = grid.GetComponentsInChildren<IDisplayable>();

            for (int i = 0; i < comp.Length; i++)
            {
                comp[i].Clear();
            }

            if (data_stream == null)
            {
                return;
            }

            for (int i = 0; i < comp.Length; i++)
            {
                if (i >= data_stream.Count)
                {
                    break;
                }
                comp[i].Display<T>(data_stream[i]);
            }
        }

        public static void PresentInterleavedList<T>(Transform grid, List<T> data_stream)
        {
            if (data_stream == null)
            {
                return;
            }
            IDisplayable[] comp = grid.GetComponentsInChildren<IDisplayable>();
            for (int i = 0; i < comp.Length; i++)
            {
                comp[i].Clear();
            }

            for (int i = 0; i < comp.Length; i++)
            {
                if (i >= data_stream.Count)
                {
                    break;
                }
                comp[i].Display<T>(data_stream[i]);
            }
        }
    }
}

