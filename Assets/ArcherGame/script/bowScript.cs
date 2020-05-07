 using UnityEngine;
 using System.Collections;
 
 public class bowScript : MonoBehaviour {
void Start()
{
    StartCoroutine(rotateForever());
}

IEnumerator rotateForever() //agar panah bergerak secara looping sesuai derajat
{
    while (true)
    {
        StartCoroutine(RotateMe1(Vector3.forward * 30f, 1f));
        yield return new WaitForSeconds(1);
        StartCoroutine(RotateMe2(Vector3.forward * -30f, 1f));
        yield return new WaitForSeconds(1);
    }
}

IEnumerator RotateMe1(Vector3 byAngles1, float inTime1)
{
    var fromAngle1 = transform.rotation;
    var toAngle1 = Quaternion.Euler(transform.eulerAngles + byAngles1);
    for (var t = 0f; t < 1; t += Time.deltaTime / inTime1)
    {
        transform.rotation = Quaternion.Lerp(fromAngle1, toAngle1, t);
        yield return null;
    }
}

IEnumerator RotateMe2(Vector3 byAngles2, float inTime2)
{
    var fromAngle2 = transform.rotation;
    var toAngle2 = Quaternion.Euler(transform.eulerAngles + byAngles2);
    for (var t = 0f; t < 1; t += Time.deltaTime / inTime2)
    {
        transform.rotation = Quaternion.Lerp(fromAngle2, toAngle2, t);
        yield return null;
    }
}
// source code :
// https://stackoverflow.com/questions/44637766/rotate-object-0-to-90-with-speed-1-then-wait-then-90-to-0-degree-with-1-speed-un/44645290
 }