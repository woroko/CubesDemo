using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCubeSpawner
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestCubeSpawnerSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestCubeSpawnerWithEnumeratorPasses()
        {
            SceneManager.LoadScene("CubesDemo");  // load CubesDemo scene in additive mode, so it preserves the test runner
            yield return new WaitForSeconds(18f);  // wait 18 seconds after start
            GameObject[] gameObjects = Object.FindObjectsOfType<GameObject>() as GameObject[];
            int cubes = 0;

            for (var i = 0; i < gameObjects.Length; i++)  // iterate through all gameobjects; quite inefficient but okay for a unit test
            {
                if (gameObjects[i].name.Contains("GrabbableCube"))
                {
                    cubes++;
                }
            }

            // Use the Assert class to test conditions.
            Assert.AreEqual(7, cubes); // test whether there are 7 cubes
            Debug.Log("TestCubeSpawner completed");
        }
    }
}
