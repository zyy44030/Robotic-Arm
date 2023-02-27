using UnityEngine;

public class Transformer : MonoBehaviour
{
    public Vector3 translationRate;
    public Vector3 rotationRate;
    public Vector3 negRotationRate;
    public Vector3 negTranslationRate;
    public string key;

    void Update()
    {
        if(rotationRate.magnitude != 0){
            if(Input.GetKey(key) && Input.GetKey(KeyCode.LeftShift) == true){
                transform.Rotate(negRotationRate * Time.deltaTime);
                if(key == "u"){
                    transform.Find("SubArmNode/SubArm").Rotate(rotationRate * Time.deltaTime);
                }
            }
            else if(Input.GetKey(key))
            {
                transform.Rotate(rotationRate * Time.deltaTime);
                if(key == "u"){
                    transform.Find("SubArmNode/SubArm").Rotate(negRotationRate * Time.deltaTime);
                }
            }
        }

        if(translationRate.magnitude != 0){
            if(Input.GetKey(key) && Input.GetKey(KeyCode.LeftShift) == true){
                transform.Translate(negTranslationRate * Time.deltaTime);
            }
            else if(Input.GetKey(key))
            {
                transform.Translate(translationRate * Time.deltaTime);
            }
        }
    }
}