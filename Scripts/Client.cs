using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{

    public Text output;

    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            iPho pho = new BasicPho();
            output.text = "Basic Pho\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("s"))
        {
            iPho pho = new BasicPho();
            pho = new withBeanSprouts(pho);
            output.text = "Pho with bean sprouts\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("c"))
        {
            iPho pho = new BasicPho();
            pho = new withCilantro(pho);
            output.text = "Pho with cilantro\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("p"))
        {
            iPho pho = new BasicPho();
            pho = new withChiliPeppers(pho);
            output.text = "Pho with chili peppers\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("a"))
        {
            iPho pho = new BasicPho();
            pho = new withBasil(pho);
            output.text = "Pho with basil\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("l"))
        {
            iPho pho = new BasicPho();
            pho = new withSqueezOfLime(pho);
            output.text = "Pho with a squeeze of lime\nRating: " + pho.getRating() + " stars";
        }

        if (Input.GetKeyDown("u"))
        {
            iPho pho = new BasicPho();
            pho = new withBeanSprouts(new withCilantro(new withChiliPeppers(new withBasil(new withSqueezOfLime(pho)))));
            output.text = "Pho with all of the toppings\nRating: " + pho.getRating() + " stars";
        }
    }
}
