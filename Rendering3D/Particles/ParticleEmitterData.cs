﻿using System.IO;
using DeltaEngine.Content;
using DeltaEngine.Core;
using DeltaEngine.Datatypes;

namespace DeltaEngine.Rendering3D.Particles
{
	/// <summary>
	/// Data for ParticleEmitter, usually created and saved in the Editor.
	/// </summary>
	public class ParticleEmitterData : ContentData
	{
		protected ParticleEmitterData(string contentName)
			: base(contentName) {}

		public ParticleEmitterData()
			: base("<GeneratedParticleEmitterData>")
		{
			StartVelocity = new RangeGraph<Vector3D>(Vector3D.Zero);
			Acceleration = new RangeGraph<Vector3D>(Vector3D.Zero);
			Size = new RangeGraph<Size>(new Size(0.1f));
			Color = new RangeGraph<Color>(Datatypes.Color.White);
			StartPosition = new RangeGraph<Vector3D>(Vector3D.Zero);
			StartRotation = new RangeGraph<ValueRange>(new ValueRange(0.0f));
			RotationSpeed = new RangeGraph<ValueRange>(new ValueRange(0.0f));
			EmitterType = "PointEmitter";
			ParticlesPerSpawn = new RangeGraph<ValueRange>(new ValueRange(1, 1));
		}

		public float SpawnInterval { get; set; }
		public float LifeTime { get; set; }
		public int MaximumNumberOfParticles { get; set; }
		public string EmitterType { get; set; }
		public RangeGraph<Vector3D> StartVelocity { get; set; }
		public RangeGraph<Vector3D> Acceleration { get; set; }
		public RangeGraph<Size> Size { get; set; }
		public RangeGraph<ValueRange> StartRotation { get; set; }
		public RangeGraph<ValueRange> RotationSpeed { get; set; }
		public RangeGraph<Color> Color { get; set; }
		public Material ParticleMaterial { get; set; }
		public BillboardMode BillboardMode { get; set; }
		public RangeGraph<Vector3D> StartPosition { get; set; }
		public RangeGraph<ValueRange> ParticlesPerSpawn { get; set; }
		public bool DoParticlesTrackEmitter { get; set; }

		protected override void LoadData(Stream fileData)
		{
			var emitterData = (ParticleEmitterData)new BinaryReader(fileData).Create();
			SpawnInterval = emitterData.SpawnInterval;
			LifeTime = emitterData.LifeTime;
			MaximumNumberOfParticles = emitterData.MaximumNumberOfParticles;
			StartVelocity = emitterData.StartVelocity;
			Acceleration = emitterData.Acceleration;
			Size = emitterData.Size;
			StartRotation = emitterData.StartRotation;
			Color = emitterData.Color;
			ParticleMaterial = emitterData.ParticleMaterial;
			ParticlesPerSpawn = emitterData.ParticlesPerSpawn;
			RotationSpeed = emitterData.RotationSpeed;
			EmitterType = emitterData.EmitterType;
			StartPosition = emitterData.StartPosition;
			BillboardMode = emitterData.BillboardMode;
			ParticlesPerSpawn = emitterData.ParticlesPerSpawn;
			DoParticlesTrackEmitter = emitterData.DoParticlesTrackEmitter;
		}

		protected override void DisposeData() {}

		public static ParticleEmitterData CopyFrom(ParticleEmitterData otherData)
		{
			var newEmitterData = new ParticleEmitterData();
			newEmitterData.SpawnInterval = otherData.SpawnInterval;
			newEmitterData.LifeTime = otherData.LifeTime;
			newEmitterData.MaximumNumberOfParticles = otherData.MaximumNumberOfParticles;
			newEmitterData.StartVelocity = new RangeGraph<Vector3D>(otherData.StartVelocity.Values);
			newEmitterData.Acceleration = new RangeGraph<Vector3D>(otherData.Acceleration.Values);
			newEmitterData.Size = new RangeGraph<Size>(otherData.Size.Values);
			newEmitterData.StartRotation = new RangeGraph<ValueRange>(otherData.StartRotation.Values);
			newEmitterData.Color = otherData.Color = new RangeGraph<Color>(otherData.Color.Values);
			newEmitterData.ParticleMaterial = otherData.ParticleMaterial;
			newEmitterData.ParticlesPerSpawn = otherData.ParticlesPerSpawn;
			newEmitterData.RotationSpeed = new RangeGraph<ValueRange>(otherData.RotationSpeed.Values);
			newEmitterData.EmitterType = otherData.EmitterType;
			newEmitterData.StartPosition = new RangeGraph<Vector3D>(otherData.StartPosition.Values);
			newEmitterData.BillboardMode = otherData.BillboardMode;
			newEmitterData.ParticlesPerSpawn = otherData.ParticlesPerSpawn;
			newEmitterData.DoParticlesTrackEmitter = otherData.DoParticlesTrackEmitter;
			return newEmitterData;
		}
	}
}