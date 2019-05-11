using Zenject;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine;
using System.Collections;

[TestFixture]
public class CriticalDamageTest : ZenjectUnitTestFixture
{
    [SetUp]
    public void Setup()
    {
        EditorSceneManager.LoadScene(0);
    }

    [UnityTest]
    public IEnumerator CriticalDamageRunTest()
    {
        var player = GameObject.FindObjectOfType<Player>();
        var enemy = GameObject.Find("Enemy");
        var defaultDamage = enemy.GetComponent<DefaultDamage>();
        var criticalDamage = enemy.GetComponent<CriticalDamage>();

        var correctHealthValue = player.Health - (defaultDamage.Damage * criticalDamage.DamageScale);

        criticalDamage.SetDamage(player);
        yield return new WaitForSeconds(1f);
        Assert.AreEqual(correctHealthValue, player.Health);
    }
}