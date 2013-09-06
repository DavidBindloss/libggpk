﻿using System;
using System.IO;

namespace LibDat.Files
{
	public class ShopItem : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		[UserStringIndex]
		public int Name { get; set; }
		[UserStringIndex]
		public int Description { get; set; }
		public int Unknown3 { get; set; }
		public int Unknown4 { get; set; }
		public bool Flag0 { get; set; }
		public int Unknown5 { get; set; }
		public int Unknown6 { get; set; }
		public int Unknown7 { get; set; }
		public int Unknown8 { get; set; }
		public int Unknown9 { get; set; }
		[StringIndex]
		public int ArtPath { get; set; }
		public Int64 Unknown11 { get; set; }
		[StringIndex]
		public int YoutubeVideo { get; set; }
		[StringIndex]
		public int LargeArtPath { get; set; }


		public ShopItem(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Name = inStream.ReadInt32();
			Description = inStream.ReadInt32();
			Unknown3 = inStream.ReadInt32();
			Unknown4 = inStream.ReadInt32();
			Flag0 = inStream.ReadBoolean();
			Unknown5 = inStream.ReadInt32();
			Unknown6 = inStream.ReadInt32();
			Unknown7 = inStream.ReadInt32();
			Unknown8 = inStream.ReadInt32();
			Unknown9 = inStream.ReadInt32();
			ArtPath = inStream.ReadInt32();
			Unknown11 = inStream.ReadInt64();
			YoutubeVideo = inStream.ReadInt32();
			LargeArtPath = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Name);
			outStream.Write(Description);
			outStream.Write(Unknown3);
			outStream.Write(Unknown4);
			outStream.Write(Flag0);
			outStream.Write(Unknown5);
			outStream.Write(Unknown6);
			outStream.Write(Unknown7);
			outStream.Write(Unknown8);
			outStream.Write(Unknown9);
			outStream.Write(ArtPath);
			outStream.Write(Unknown11);
			outStream.Write(YoutubeVideo);
			outStream.Write(LargeArtPath);
		}

		public override int GetSize()
		{
			return 0x3D;
		}
	}
}