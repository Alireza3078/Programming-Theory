using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract
    class Shape : MonoBehaviour
{
    public abstract string Name { get; }
    public virtual Color color
    {
        get => Color.white;
        protected set => color = value;
    }
    public virtual int Faces
    {
        get => 1;
        private set => Faces = value < 1 ? 1 : value;
    }
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
    string GetColor()
    {
        if (color == Color.red)
        {
            return "red";
        }
        else if (color == Color.blue)
        {
            return "blue";
        }
        else if (color == Color.gray)
        {
            return "gray";
        }
        return color.ToString();
    }
    public virtual string DisplayText()
    {
        string result = $"The {GetColor()} {Name} has {Faces} face";
        result = Faces > 1 ? result + "s." : result + ".";

        return result;
    }
}
