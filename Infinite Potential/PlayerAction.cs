using System;
using System.Collections.Generic;
using System.Text;

namespace Infinite_Potential
{
    class PlayerAction
    {
        private readonly string name, tName, gName;
        private int tValue, gValue;
        private bool active;
        public const int SELF = 0, GIVE = 1, TAKE = 2;

        public PlayerAction(string[] names, int[] values)
        {
            name = names[0];
            tName = names[1];
            gName = names[2];
            tValue = values[0];
            gValue = values[1];
            active = false;
        }

        public string GetName(int s)
        {
            return s switch { 
                SELF => name,
                GIVE => gName,
                TAKE => tName,
                _ => null
            };
        }

        public int GetValue(int s)
        {
            return s switch {
                GIVE => gValue,
                TAKE => tValue,
                _ => -1
            };
        }

        public bool IsActive()
        {
            return active;
        }

        public bool SetValue(int s, int val)
        {
            switch (s) {
                case TAKE:
                    tValue = val;
                    break;
                case GIVE:
                    gValue = val;
                    break;
                default:
                    return false;
            }
            return true;

        }

        public void Switch()
        {
            if (active)
            {
                active = false;
            }
            else
            {
                active = true;
            }
        }
        
        public int[] Run(int[] values)
        {
            switch (values.Length){
                case 1:
                    values[0] += gValue;
                    return values;
                case 2:
                    if(values[0] >= tValue)
                    {
                        values[0] -= tValue;
                        values[1] += gValue;
                    }
                    return values;
                case 3:
                    if(values[0] >= tValue && values[1] + gValue <= values[2])
                    {
                        values[0] -= tValue;
                        values[1] += gValue;
                    }
                    return values;
                default:
                    return values;
            }


        }
        
    }
}
