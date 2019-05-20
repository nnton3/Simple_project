using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

namespace Tests
{
    public class DefaultDamageTest
    {
        [SetUp]
        public void Setup()
        {
            EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
        }

        [Test]
        public void DefaulDamageTestSimplePasses()
        {
            var player = new InputDamageController(100);
            var defaultDamage = new DefaultDamage(20);

            float correctHealthValue = player.Health - defaultDamage.Damage;
            defaultDamage.SetDamage(player);

            Assert.AreEqual(correctHealthValue, player.Health);
        }
    }
}
