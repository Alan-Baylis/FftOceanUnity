﻿using UnityEngine;
using System.Collections;

public class OceanUtil {
	public const float GRAVITY = 9.81f;
	public const float TWO_PI = 2f * Mathf.PI;
	public const float ONE_OVER_SQRT_TWO = 0.70710678118f;

	public static Vector2 StandardNormalDistribution() {
		var u1 = Random.value;
		var u2 = Random.value;
		var sqrt = Mathf.Sqrt(-2f * Mathf.Log(u1));
		var theta = TWO_PI * u2;
		var z0 = sqrt * Mathf.Cos(theta);
		var z1 = sqrt * Mathf.Sin(theta);
		return new Vector2(z0, z1);
	}
}
