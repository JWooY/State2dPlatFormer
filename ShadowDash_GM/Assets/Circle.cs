using UnityEngine;

public class Circle : Shape
{

    public override void Start() // virtual을 override 해서 부모의 Start를 가져옴
    {
        base.Start();  // base.Start()는 부모의 Start를 가져옴

        Debug.Log("나는 도형 상속받은 자식이다.");


    }
}
