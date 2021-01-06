﻿using System.Numerics;
using Aliquip.Sandbox;

using var sandbox = Sandbox.Create();

for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        for (int k = 0; k < 20; k++)
        {
            var cube = sandbox.AddPrimitive(Primitive.Cube, 0, 1, 0);
            cube.Position = new Vector3(i * 2, j * 2, k * 2);
        }
    }
}

sandbox.Run();
