using Zenject;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine;
using System.Collections;

[TestFixture]
public class PoisonDamageTest : ZenjectUnitTestFixture
{
    [SetUp]
    public void Setup()
    {
        EditorSceneManager.LoadScene(0);
    }

    [UnityTest]
    public IEnumerator PoisonDmageRunTest()
    {
        var player = GameObject.FindObjectOfType<Player>();
        var enemy = GameObject.Find("Enemy");
        var poisonDamage = enemy.GetComponent<PoisonDamage>();

        var correctHealthValue = player.Health;

        poisonDamage.SetDamage(player);

        yield return new WaitForSeconds(1f);
        Debug.Log(player.Health);
        correctHealthValue -= poisonDamage.DamageOnTick;
        Assert.AreEqual(correctHealthValue, player.Health);

        yield return new WaitForSeconds(poisonDamage.PoisonEffectDuration -1);
        correctHealthValue -= poisonDamage.DamageOnTick * (poisonDamage.PoisonEffectDuration - 1);
        Assert.AreEqual(correctHealthValue, player.Health);
    }
}