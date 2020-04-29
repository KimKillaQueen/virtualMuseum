using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class interactionScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textObj;
    private List<displayScript> displays;
    void Start()
    {
        textObj = FindObjectOfType<Text>();
        displays = new List<displayScript>(FindObjectsOfType<displayScript>());
    }

    // Update is called once per frame
    void Update()
    {
        var currentDis = searchForDisplay();
        if(currentDis != null) {
            currentText = currentDis.description;
        } else {
            currentText = "";
        }

        updateGUI();
    }

    displayScript searchForDisplay() {
        // Vector3 currentPos = transform.position.x * Vector3.right + transform.position.z * Vector3.forward;

        var targetDisplay = displays.Find(delegate (displayScript dis) {
            // Vector3 disPos = dis.transform.position.x * Vector3.right + dis.transform.position.z * Vector3.forward;
            
            
            return (dis.transform.position - transform.position).magnitude < 1.25f;
        });

        return targetDisplay;
    }
    private string currentText = "";

    
private void updateGUI() {
    textObj.text = currentText;
}

}
