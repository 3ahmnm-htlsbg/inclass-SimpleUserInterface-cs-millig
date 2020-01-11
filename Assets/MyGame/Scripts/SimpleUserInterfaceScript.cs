
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserInterfaceScript : MonoBehaviour
{

        public InputField input;
        public Button textButton;
        public Text result;

        public Text counterText;
        public int counter = 0;

        public void CopyText()
        {
                result.text = input.text;

        }

        public void Counter()
        {
        counter++;
        counterText.text = counter.ToString();
        }
}
