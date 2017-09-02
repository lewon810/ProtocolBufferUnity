using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Google.Protobuf;

using System.IO;

public class TestScene : MonoBehaviour {

    [SerializeField]
    UnityEngine.UI.Text _label;

	// Use this for initialization
	void Start () {
        var person = new Person();
        person.Id = 1;
        person.Name = "だいき";

        //scerialize
        byte[] ouputBytes = person.ToByteArray();

        //descerialize
        Person person2 = new Person();
		person2 = Person.Parser.ParseFrom(ouputBytes);

        //log
        _label.text = person2.ToString();

	}

    private Person TestFunc()
    {
        return new Person();
    }


	// Update is called once per frame
	void Update () {
		
	}
}
