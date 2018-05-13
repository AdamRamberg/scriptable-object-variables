using UnityEngine;

namespace ScriptableObjectVariables
{
    public class ScriptableObjectVariable<T> : ScriptableObject
    {
        [Multiline]
        public string DeveloperDescription = "";
        
        public T Value;
        public bool useAsConstant = true; // If true it is only possible to change the variable via the Inspector

        public bool SetValue(T value)
        {
            if (useAsConstant) return false;
            Value = value;
            return true;
        }

        public bool SetValue(ScriptableObjectVariable<T> value)
        {
            if (useAsConstant) return false;
            Value = value.Value;
            return true;
        }

        public virtual bool ApplyChange(T amount) 
        { 
            if (useAsConstant) return false;
            return true;
        }
        public virtual bool ApplyChange(ScriptableObjectVariable<T> amount) 
        { 
            if (useAsConstant) return false;
            return true;
        }
    }
}