using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override string Name { get => "cube"; }
    public override Color color => Color.red;
    public override int Faces => 6;

}
